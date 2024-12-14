using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Medii.Data;
using Proiect_Medii.Models;

namespace Proiect_Medii.Pages.Terenuri
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect_Medii.Data.Proiect_MediiContext _context;

        public DeleteModel(Proiect_Medii.Data.Proiect_MediiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Teren Teren { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teren = await _context.Teren.FirstOrDefaultAsync(m => m.ID == id);

            if (teren == null)
            {
                return NotFound();
            }
            else
            {
                Teren = teren;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teren = await _context.Teren.FindAsync(id);
            if (teren != null)
            {
                Teren = teren;
                _context.Teren.Remove(Teren);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

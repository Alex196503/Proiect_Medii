﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Medii.Data;
using Proiect_Medii.Models;

namespace Proiect_Medii.Pages.Terenuri
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Medii.Data.Proiect_MediiContext _context;

        public CreateModel(Proiect_Medii.Data.Proiect_MediiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Teren Teren { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Teren.Add(Teren);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
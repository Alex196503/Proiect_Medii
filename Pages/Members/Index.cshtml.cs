﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Medii.Data;
using Proiect_Medii.Models;

namespace Proiect_Medii.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Medii.Data.Proiect_MediiContext _context;

        public IndexModel(Proiect_Medii.Data.Proiect_MediiContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Member = await _context.Member
                .Include(m=>m.Membership)
                .ToListAsync();
        }
    }
}

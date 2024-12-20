﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Medii.Models;

namespace Proiect_Medii.Data
{
    public class Proiect_MediiContext : DbContext
    {
        public Proiect_MediiContext (DbContextOptions<Proiect_MediiContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Medii.Models.Member> Member { get; set; } = default!;
        public DbSet<Proiect_Medii.Models.Membership> Membership { get; set; } = default!;
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JAWS.Models;

namespace JAWS.Data
{
    public class JAWSContext : DbContext
    {
        public JAWSContext (DbContextOptions<JAWSContext> options)
            : base(options)
        {
        }

        public DbSet<JAWS.Models.LoyalKartica> LoyalKartica { get; set; }

        public DbSet<JAWS.Models.Kontakt> Kontakt { get; set; }

        public DbSet<JAWS.Models.Pacijent> Pacijent { get; set; }
    }
}

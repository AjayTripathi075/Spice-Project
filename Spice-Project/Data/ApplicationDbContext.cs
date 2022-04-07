﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Spice_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spice_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using IsTeYazilim.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IsTeYazilim.Data
{
    public class ApplicationDbContext : IdentityDbContext <WebUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}

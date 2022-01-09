using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Zamowienia_w_restauracji.Models;

namespace Zamowienia_w_restauracji.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Zamowienia_w_restauracji.Models.Danie> Danie { get; set; }
        public DbSet<Zamowienia_w_restauracji.Models.Kategorie> Kategorie { get; set; }
        public DbSet<Zamowienia_w_restauracji.Models.Adres> Adres { get; set; }
        public DbSet<Zamowienia_w_restauracji.Models.Zamowienie> Zamowienie { get; set; }
        
    }
}

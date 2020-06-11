using Microsoft.EntityFrameworkCore;
using Parcial1_Ap2_Garcia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Garcia.DAL
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"DataSource= c:\Databases\Articulos_DB");
        }

        public DbSet<Articulos> articulos { get; set; }

    }
}

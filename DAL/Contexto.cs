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
        DbSet<Articulos> articulos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"DataSource=c:Articulos_DB");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Articulos>().HasData(new Articulos
            {
                ID = 1,
                Descripcion = "Mouse Inalambrico",
                Existencia = 34,
                Costo = Convert.ToDecimal(345.34),
                Inventario = Convert.ToDecimal(11741.56)
            });
        }
    }
}

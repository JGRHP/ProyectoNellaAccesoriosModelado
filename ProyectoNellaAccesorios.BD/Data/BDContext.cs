using Microsoft.EntityFrameworkCore;
using ProyectoNellaAccesorios.BD.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNellaAccesorios.BD.Data
{
    public class BDContext : DbContext
    {
        public DbSet <Usuario> Usuarios { get; set;}   
        public BDContext(DbContextOptions options) : base(options)
        {
        }
    }
}

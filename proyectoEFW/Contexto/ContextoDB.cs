using Microsoft.EntityFrameworkCore;
using proyectoEFW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoEFW.Contexto
{
    public class ContextoDB :DbContext, IContextoDB
    {
        public ContextoDB(DbContextOptions<ContextoDB> options): base(options)
        {

        }
        //establecer dbset
        public DbSet<Cancion> Canciones { get; set; }
        // creamos la sobrecarga
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}

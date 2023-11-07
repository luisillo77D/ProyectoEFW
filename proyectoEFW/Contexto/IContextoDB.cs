using Microsoft.EntityFrameworkCore;
using proyectoEFW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace proyectoEFW.Contexto
{
    public interface IContextoDB
    {
        //Acceson a traves de la inyeccion

        DbSet<Cancion> Canciones { get; set; }

        //pegaremos los metodos copiados desde la clase
        int SaveChanges();      
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));
        

    }
}

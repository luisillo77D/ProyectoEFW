using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoEFW.Models
{
    public class Cancion
    {
        //definimos las propiedades autoimplementadas
        public int CancionId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public TimeSpan Duracion { get; set; }

    }
}

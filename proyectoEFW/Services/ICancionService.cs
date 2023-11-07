using proyectoEFW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoEFW.Services
{
    public interface ICancionService
    {
        //invocaremos todos los metodos que realiazan todas las operaciones CRUD
        void AddCancion(Cancion cancion);

        void DeleteCancion(int cancionId);

        void DeleteCancion(Cancion cancion);

        List<Cancion> GetCanciones();

        Cancion GetCancion(int cancionId);

        Cancion UpdateCancion(Cancion cancion);
    }
}

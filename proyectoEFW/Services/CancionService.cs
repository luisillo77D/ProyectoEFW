using proyectoEFW.Contexto;
using proyectoEFW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoEFW.Services
{
    //establecemos la herencia con la interface
    public class CancionService:ICancionService
    {
        //solicitar agregar una cancion al repositorio
        private readonly IContextoDB _contextoDB;

        //creamos un construxtor
        public CancionService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        //crearemos un metodo con el cual agregaremos la cancion
        public void AddCancion(Cancion cancion) {
            //Accesaremos al repositorio
            _contextoDB.Canciones.Add(cancion);

            //guardamos los cambios
            _contextoDB.SaveChanges();
        }
        //crearemos el metodo que permita borrar un registro
        public void DeleteCancion(int cancionId)
        {
            //asignamos el valor contenido en el parametro hacia una variable
            var cancion = GetCancion(cancionId);
            //borrar el valor especifico
            DeleteCancion(cancion);
        }

        public void DeleteCancion(Cancion cancion)
        {
            //utilizaremos el repositorio
            _contextoDB.Canciones.Remove(cancion);
            //guarda los cambios
            _contextoDB.SaveChanges();
        }

        //Metodo que permita listar los datos del objeto
        public List<Cancion> GetCanciones()
        {
            //retornamos los valores encontrados
            return _contextoDB.Canciones.Select(x => x).ToList();
        }

        //crearemos un metodo que permita retornar un solo registro
        public Cancion GetCancion(int cancionId)
        {
            //retornamos el registro encontrado
            return _contextoDB.Canciones.Where(x => x.CancionId == cancionId).FirstOrDefault();
        }

        //creamos el metodo que nos permita guardar cambios
        public Cancion UpdateCancion(Cancion cancion)
        {
            //declaramos una varible
            var cancionUpdated = _contextoDB.Canciones.Update(cancion).Entity;

            //guardamos los cambios
            _contextoDB.SaveChanges();
            //retornamos el valor actualizado
            return cancionUpdated;
        }

        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proyectoEFW.Services;

namespace proyectoEFW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //establecemos la interface
        private readonly ICancionService _cancionService;

        //crearemos un constructor
        public ValuesController(ICancionService cancionService) {
            _cancionService = cancionService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //Haremos uso del servicio
            _cancionService.AddCancion(
                new Models.Cancion
                {
                    Descripcion="1Corridos tumbados",
                    Titulo ="1Sin ti",
                    Duracion = new TimeSpan(0,3,10)
                }
                );

            _cancionService.AddCancion(
                new Models.Cancion
                {
                    Descripcion = "Cancion bonita1",
                    Titulo = "Arriba2",
                    Duracion = new TimeSpan(2, 3, 10)
                }
                );

            var canciones = _cancionService.GetCanciones();
            //retornaremos un valor especifico
            //declaramos una varible 
            var cancion = _cancionService.GetCancion(1);

            //modificar Registro
            cancion.Descripcion = "Musica cambiada1";
            //actualizacion del registro
            _cancionService.UpdateCancion(cancion);

            //eliminar un registro
            _cancionService.DeleteCancion(1);

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using FirstAppEf.Business.Interfaces;
using FirstAppEf.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace FirstAppEf.Controllers
{
    public class AlquilerController : Controller
    {
        public IPeliculaBusiness PeliculaBusiness { get; }
        public IPersonaBusiness PersonaBusiness { get; }
        public IAlquilerBusiness AlquilerBusiness { get; }

        public AlquilerController(IPeliculaBusiness peliculaBusiness, IPersonaBusiness personaBusiness, IAlquilerBusiness alquilerBusiness)
        {
            PeliculaBusiness = peliculaBusiness;
            PersonaBusiness = personaBusiness;
            AlquilerBusiness = alquilerBusiness;
        }

        public IActionResult CrearAlquiler([FromBody]AlquilerDto alquiler)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new {error = "errorModel"});
            }

            alquiler.Fecha = DateTime.Now;

            this.AlquilerBusiness.CrearAlquiler(alquiler);

            return Json(new {result = "ok"});

        }


        public IActionResult Index(int id)
        {
            var res = this.PeliculaBusiness.GetPeliculaById(id);

            var res2 = this.PeliculaBusiness.GetPeliculaByName("La odisea");

            var alquiler = new AlquilerViewModel()
            {
                Pelicula = res,

            };

            return View(alquiler);
        }

        public async Task<IActionResult> GetPerson(string datoBusqueda)
        {
            if (datoBusqueda.IsNullOrEmpty())
            {
                return Json(new {});
            }
           var result = this.PersonaBusiness.FindByData(datoBusqueda).Take(10);

            return Ok(new { data = result });
            //return Json(result);

        }
    }
}

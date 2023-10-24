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

        public AlquilerController(IPeliculaBusiness peliculaBusiness, IPersonaBusiness personaBusiness)
        {
            PeliculaBusiness = peliculaBusiness;
            PersonaBusiness = personaBusiness;
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

            return Json(result);

        }
    }
}

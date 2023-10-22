using FirstAppEf.Business.Interfaces;
using FirstAppEf.Models;
using FirstAppEf.Repository.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FirstAppEf.Controllers
{
    public class PeliculaController : Controller
    {
        public IPeliculaBusiness PeliculaBusiness;
        public PeliculaController(IPeliculaBusiness peliculaBusiness)
        {
            PeliculaBusiness = peliculaBusiness;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IngresoPelicula(PeliculaDto pelicula)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", pelicula);
            }
            try
            {
                var result = this.PeliculaBusiness.Crear(pelicula);
                ModelState.Clear();

                return View("Index");
            }
            catch (Exception ex)
            {

                // Maneja la excepción y muestra un mensaje de error amigable
                ViewBag.ErrorMessage = "Error generico" + ex;
                return View("Index", pelicula);
            }
           
        }

        public IActionResult ObtenerGeneros()
        {
            var generos = this.PeliculaBusiness.GetGeneros();

            return Json(generos);
        }

        public IActionResult MostrarPeliculas(string name)
        {
            var peliculas = this.PeliculaBusiness.GetPeliculas(name);
            return View("PeliculasListado", peliculas);
        }

        [HttpGet]
        public async Task<ActionResult> GetPeliculaByName(string name)
        {
            var peliculas =  name != null ? this.PeliculaBusiness.GetPeliculasByName(name) : this.PeliculaBusiness.GetPeliculas(name);
            return View("PeliculasListado", peliculas);
        }
    }
}

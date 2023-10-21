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

        public IActionResult MostrarPeliculas()
        {
            var peliculas = this.PeliculaBusiness.GetPeliculas();
            return View("PeliculasListado", peliculas);
        }
    }
}

using AutoMapper;
using FirstAppEf.Business.ExceptionDni;
using FirstAppEf.Business.Interfaces;
using FirstAppEf.Models;
using FirstAppEf.Repository.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Data.Common;

namespace FirstAppEf.Controllers
{
    public class PersonaController : Controller
    {

        public IPersonaBusiness PersonaBusiness { get; }

        public PersonaController(IPersonaBusiness personaBusiness)
        {
            PersonaBusiness = personaBusiness;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(PersonaDto persona)
        {

            if (!ModelState.IsValid)
            {
                return View("Index",persona);
            }

            try
            {
                var res = this.PersonaBusiness.Crear(persona);
                ModelState.Clear();
                ViewBag.Success = "Los datos fueron ingresados correctamente.";

                return View("Index");
            }
            catch (DniException dniException)
            {

                // Maneja la excepción y muestra un mensaje de error amigable
                ViewBag.ErrorMessage = dniException.Message;
                return View("Index", persona);
            }
            catch (Exception ex)
            {

                // Maneja la excepción y muestra un mensaje de error amigable
                ViewBag.ErrorMessage = "Error generico" + ex;
                return View("Index", persona);
            }

        }

        [HttpPost]

        public IActionResult Actualizar([FromBody] PersonaDto persona)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("error en los datos de entrada");
                }

                var update = this.PersonaBusiness.Actualizar(persona);

                return Json(update);
            }
            catch (Exception)
            {

                return BadRequest("error en los datos de entrada");
            }

            
        }

        [HttpPost]
        public async Task<ActionResult> DeletePersona([FromBody] int id)
        {
            try
            {
                this.PersonaBusiness.DeletePersona(id);

                return Json("La persona fue eliminada");
            }
            catch (Exception ex)
            {

                return Json("hubo un error");
            }
        }




    }
}

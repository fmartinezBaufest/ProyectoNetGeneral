using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MiServicioWebDePruebita;
using System.Web;
using WebServicePrueba;

namespace FirstAppEf.Controllers
{
    public class PruebasController : Controller
    {
        public IMiWebServiceDePrueba MiWebServiceDePrueba { get; }

        public PruebasController(IMiWebServiceDePrueba miWebServiceDePrueba )
        {
            MiWebServiceDePrueba = miWebServiceDePrueba;
        }

        [HttpPost]
        public async Task<IActionResult> Crear()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Ver()
        {
        // Simular una operación asincrónica, como una llamada a una base de datos.

            var result = await GetDataAsync();

            return Ok(result);
        }

        public async Task<IActionResult> GizmosAsync()
        {
            ViewBag.SyncOrAsync = "Asynchronous";
           // var gizmoService = new GizmoService();
            return View();
        }

        [HttpGet]
        public ActionResult GetAsync2()
        {
            // Simular una operación asincrónica, como una llamada a una base de datos.
            

            return Ok("ok");
        }
        public  IActionResult Index()
        {          
            //var r = this.MiWebServiceDePrueba.DevolvemeElNombreAsync().Result;
            return View();
        }
        
            [HttpPost]
        public IActionResult CargarImg(IFormFile file)
        {

            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Lee el contenido del archivo y lo copia en memoryStream.
                file.CopyTo(memoryStream);

                // Convierte el contenido a un arreglo de bytes.
                byte[] bytes = memoryStream.ToArray();

                // Convierte los bytes en una cadena Base64.
                string base64String = Convert.ToBase64String(bytes);

                // Ahora 'base64String' contiene la representación Base64 del archivo.
                // Puedes hacer lo que desees con esta cadena, como almacenarla en una base de datos o mostrarla en una vista.

                ViewBag.ImageData = base64String;

                // Redirige a la vista Index o realiza otras operaciones según sea necesario.
                return View("Index");
            }
        }

        private async Task<IEnumerable<string>> GetDataAsync()
        {
            await Task.Delay(1000); // Simular una demora de 1 segundo.
            return new List<string> { "Dato 1", "Dato 2", "Dato 3" };
        }
    }
}

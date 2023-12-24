using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PruebaController : ControllerBase
    {
       
        public PruebaController()
        {
        }

        [HttpGet]
        [Route("ProbandoGet")]
        public void ProbandoGet()
        {
            var d = "test";
        }

        [HttpGet]
        [Route("ProbandoGet2")]
        public void ProbandoGet2()
        {
            var d = "test";
        }

        [HttpPost]
        [Route("ProbandoPost")]
        public IActionResult ProbandoGet3(int num1, int num2)
        {
            var res = num1 + num2;

            try
            {
                var r4 = new ServicioComandosClient();

                r4.EjecutarAsync(new Comando { });

                if (res == 4)
                {
                    throw new Exception("Error la suma da 4 y no deberia");
                }

                var r = new JsonResult(new { result = res });

                return r;
            }
            catch (Exception ex)
            {
                var errorResponse = new
                {
                    ErrorMessage = "Error",
                    Error = ex.Message,
                };

                return BadRequest(errorResponse);
            }
           
        }
    }
}
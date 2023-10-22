using AutoMapper;
using FirstAppEf.Business.Interfaces;
using FirstAppEf.Models;
using FirstAppEf.Repository.Entities;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Collections.Generic;

namespace FirstAppEf.Controllers
{
    public class ReportsController : Controller
    {
        public IPersonaBusiness PersonaBusiness { get; }

        public ReportsController(IPersonaBusiness personaBusiness)
        {
            PersonaBusiness = personaBusiness;
        }

        public IActionResult Index(PaginacionViewModel p)
        {
            var result = this.PersonaBusiness.GetAllPaginado(p);

            var countReg = this.PersonaBusiness.GetTotalPersonas();

            var paginacionRespuesta = new PaginacionRespuesta<PersonaDto>
            {
                CantidadTotalDeRecords = countReg,
                Elementos = result,
                Pagina = p.Pagina,

            };


            return View(paginacionRespuesta);
        }


        [HttpPost]
    //    public IActionResult ExportarExcel()
    //{

    //        var personas = this.PersonaBusiness.GetAll().OrderByDescending(x => x.Id).ToList();

    //        using (var package = new ExcelPackage())
    //    {

    //        var worksheet = package.Workbook.Worksheets.Add("Informe de Personas");

    //        // Encabezados de columna
    //        worksheet.Cells[1, 1].Value = "ID";
    //        worksheet.Cells[1, 2].Value = "Nombre";
    //        worksheet.Cells[1, 3].Value = "Apellido";
    //        worksheet.Cells[1, 4].Value = "DNI";
    //        worksheet.Cells[1, 5].Value = "Edad";

    //        // Formato de encabezados
    //        using (var range = worksheet.Cells[1, 1, 1, 5])
    //        {
    //            range.Style.Font.Bold = true;
    //            range.Style.Fill.PatternType = ExcelFillStyle.Solid;
    //            range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Gray);
    //        }

    //        // Llenar los datos
    //        var row = 2;
    //        foreach (var persona in personas)
    //        {
    //            worksheet.Cells[row, 1].Value = persona.Id;
    //            worksheet.Cells[row, 2].Value = persona.Name;
    //            worksheet.Cells[row, 3].Value = persona.LastName;
    //            worksheet.Cells[row, 4].Value = persona.Dni;
    //            worksheet.Cells[row, 5].Value = persona.Age;
    //            row++;
    //        }

    //        // Configurar tamaño automático de columnas
    //        worksheet.Cells.AutoFitColumns();

    //        // Guardar el archivo Excel
    //        var stream = new System.IO.MemoryStream();
    //        package.SaveAs(stream);

    //        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "InformeDePersonas.xlsx");
    //    }
    //}

        public IActionResult Editar(int id)
        {
            var v = id;

            var p = new PersonaDto
            {
                Age = "11",
                Dni = "23243234",
                Id = 1,
                LastName = "fewfewf",
                Name = "fwefwr"
            };
            return View(p);

        }

        public IActionResult GetById(int id)
        {
            var result = new PersonaDto();
            try
            {
                result = this.PersonaBusiness.GetPersonById(id);
            }
            catch (Exception)
            {

                return BadRequest("error");

               //return Json("error");
            }

            return Json(result);
        }

        
    }
}

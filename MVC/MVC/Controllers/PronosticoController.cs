using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
        [Route("Pronostico")]

    public class PronosticoController : Controller
    {
        //[Route("Partido")]
        //[Route("Partido/Index")]
        //[HttpGet("")]
        //[HttpPost("crear")]

        //public string Index()
        //{
        //    return View();
        //}

        //[Route("Detalle/{id:int?}")]
        [HttpGet("Detalle/{id:int?}")]

        public string Detalle([FromQuery] string equipoLocal, [FromQuery] string equipoVisitante, int? id)
        {

            return $"Este es el detalle del partido {equipoLocal} - {equipoVisitante} {id}";
        }
    }
}
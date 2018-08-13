using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.ControllersAPI
{
    [Route("api/pronostico")]
    
    public class PronosticoController : ControllerBase
    {
        
        //[HttpPost("crear")]

        public IActionResult Crear(PronosticoVM pronostico)
        {
            return Ok(pronostico);
        }
    }
}
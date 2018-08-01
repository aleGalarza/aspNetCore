using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto.Codigo;

namespace Proyecto.Controllers
{
    [Route("[controller]")]
    public class Partido2Controller : Controller
    {
        public ILogger _logger;

        [Route("{equipo1}-{equipo2}")]
        public IActionResult Detalle(string equipo1, string equipo2)
        {
            if (equipo1.Length > 3)
            {
                throw new ArgumentException("El equipo 1 es incorrecto");
            }

            if (equipo1.Equals("RIB", StringComparison.CurrentCultureIgnoreCase) || equipo2.Equals("RIB", StringComparison.CurrentCultureIgnoreCase))
            {
                var ex = new PartidoMalformadoException
                {
                    Equipo1 = equipo1,
                    Equipo2 = equipo2
                };
                _logger.LogError(ex.ToString());
            }

            try { 
            var resultado = equipo1.Length / (equipo2.Length -1);
            ViewBag.Resultado = resultado;
        }
         catch (DivideByZeroException ex)
            {

                //LOGGER
            }
        
        catch(Exception ex)
            {
                //LOGGER
            }
         

            
            return View();
        }
    }
}
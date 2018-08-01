using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prode.Core.Entidades;
using Prode.Core.Entidades.Interface;

namespace Proyecto.Controllers
{
    public class EquipoController : Controller
    {

        private IFormateador _formateador;

        public EquipoController(IFormateador formateador)
        {
            _formateador = formateador;
        }
        
        public IActionResult Index()
        {
            var argentina = new Equipo
            {
                Nombre = "Argentina",
                Abreviatura = "ARG"
            };

            var francia = new Equipo
            {
                Nombre = "Francia",
                Abreviatura = "FRA"
            };


            ViewData["Nombre"] = _formateador.NombreCompleto(argentina);
            ViewData["Nombre1"] = _formateador.NombreCompleto(francia);
            return View();
        }
    }
}
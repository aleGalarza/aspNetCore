using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prode.Core.Entidades;
using Prode.Core.Entidades.Interface;

namespace Proyecto.Controllers
{
    public class PartidoController : Controller
    {
        private IFormateador _formateador;

        public PartidoController(IFormateador formateador)
        {
            _formateador = formateador;
        }

        public ActionResult ResultadoPartido()
        {
            var argentina = new Equipo
            {
                Nombre = "Argentina",
                Abreviatura = "ARG"
            };


            ViewData["Nombre"] = _formateador.NombreCompleto(argentina);
            return View();
            //Equipo equipo1 = new Equipo
            //{
            //    EquipoId = 1,
            //    Nombre = "Argentina"

            //};

            //Equipo equipo2 = new Equipo { };
            //equipo2.EquipoId = 2;
            //equipo2.Nombre = "Nigeria";

            //Partido partido = new Partido
            //{
            //    EquipoLocal = equipo1,
            //    EquipoVisitante = equipo2,
            //    GolesLocal = 2,
            //    GolesVisitante = 1
            //};
            //ViewData["EquipoLocal"] = partido.EquipoLocal;
            //ViewData["idEquipo"] = partido.EquipoLocal.EquipoId;
            //ViewData["EquipoLocalDescripcion"] = partido.EquipoLocal.Nombre;
            //ViewBag.MostrarResultado = true;

            //var x = partido.InformarResultado;

            //return View();
        }

    }
}
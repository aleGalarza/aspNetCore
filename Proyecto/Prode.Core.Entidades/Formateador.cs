using Prode.Core.Entidades.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prode.Core.Entidades
{
    public class Formateador : IFormateador
    {
        public string NombreCompleto(IEquipo equipo)
        {
            return $"Nombre Completo {equipo.Nombre} ({equipo.Abreviatura})";
        }
    }
}

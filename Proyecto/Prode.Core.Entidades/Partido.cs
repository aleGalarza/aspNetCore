using System;
using System.Collections.Generic;
using System.Text;

namespace Prode.Core.Entidades
{
    public class Partido
    {
        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public DateTime   Fecha{ get; set; }
        public String InformarResultado {
            get
            {
                var resultado = "";
                if (GolesLocal>GolesVisitante)
                {
                    resultado = $"Gano {EquipoLocal.Nombre}";
                }
                else if (GolesLocal<GolesVisitante)
                {
                    resultado = $"Gano {EquipoLocal.Nombre}";
                }
                else
                {
                    resultado = "Empate";
                }
                return resultado;
            }
           

            set; }


    }
}

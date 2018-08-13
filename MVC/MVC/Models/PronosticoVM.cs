using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class PronosticoVM
    {
        [DisplayName("Equipo Local")]
        public string EquipoLocal { get; set; }
        [DisplayName("Equipo Visitante")]
        public string EquipoVisitante { get; set; }
        [Required()]
        public int GolesLocales { get; set; }
        [Required()]

        public int GolesVisitantes { get; set; }
    }
}

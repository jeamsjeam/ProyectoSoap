using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSoap.Models
{
    public class SDTimportesAingresarItem
    {
        public string Trabajo { get; set; }
        public string Planilla { get; set; }
        public string estadoPlanilla { get; set; }
        public string importeEnviado { get; set; }
        public string importeCobrado { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSoap.Models
{
    public class SDTdeudasItem
    {
        public string Tipo { get; set; }
        public string NroDeuda { get; set; }
        public string Cuota { get; set; }
        public string FechaCreada { get; set; }
        public string FechaVencimiento { get; set; }
        public string Saldo { get; set; }
        public string SaldoSinMora { get; set; }
        public string SaldoCapital { get; set; }
        public string SaldoInteres { get; set; }
        public string SaldoIVA { get; set; }
        public string SaldoMora { get; set; }
        public string Planilla { get; set; }
        public string DiasAtraso { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSoap.Models
{
    public class ExecuteResponseResultado
    {
        public SDTdeudas Xmldelsdtdeudas { get; set; }
        public SDTimportesAingresar Xmldelsdtimportesaingresar { get; set; }
        public double Saldocapitalsinvencer { get; set; }
        public double Saldointeresessinvencer { get; set; }
        public double Deudacuotsocsinven { get; set; }
        public double Saldototalsinvencer { get; set; }
        public double Saldocapitalvencido { get; set; }
        public double Saldointeresvencidos { get; set; }
        public double Saldomora { get; set; }
        public double Deudacuotsocven { get; set; }
        public double Saldototalvencido { get; set; }
        public bool Usuariovalido { get; set; }
        public bool Tienepermiso { get; set; }
        public string Mensajeerror { get; set; }

        public ExecuteResponseResultado()
        {
            Xmldelsdtdeudas = new SDTdeudas();
            Xmldelsdtimportesaingresar = new SDTimportesAingresar();
        }
    }
}
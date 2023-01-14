using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSoap.Models
{
    public class SDTdeudas
    {
        public List<SDTdeudasItem> SDTdeudasItem { get; set; }
        public SDTdeudas()
        {
            SDTdeudasItem = new List<SDTdeudasItem>();
        }
    }
}
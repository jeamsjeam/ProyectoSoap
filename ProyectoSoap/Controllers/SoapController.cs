using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;
using ProyectoSoap.Models;
using ProyectoSoap.ServicioSoap;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using System.Web.Http;
using System.Web.UI.WebControls;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace ProyectoSoap.Controllers
{ 
    public class SoapController : ApiController
    {
        // GET api/Soap/
        [EnableCors("AllPolicy")]
        public ExecuteResponseResultado GetAsync(string codigo)
        {
            var regex = new Regex("^[0-9]+$");
            if (regex.IsMatch(codigo))
            {

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback = (snder, cert, chain, error) => true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicioSoap.WSSocDeuSoapPortClient soap = new ServicioSoap.WSSocDeuSoapPortClient("WSSocDeuSoapPort");
                var respuesta = soap.ExecuteAsync("requiro", "R3qu1R0/C0p4C_2022", codigo).Result;

                var transactDeudaLista1 = new SDTdeudas();
                var transactDeudaLista2 = new SDTimportesAingresar();

                bool bandera1 = true;
                bool bandera2 = true;

                string xml = "";
                string xml2 = "";

                try
                {  
                    //--------------------Parte de Xmldelsdtdeudas--------------------
                    if (respuesta.Body.Xmldelsdtdeudas != null && respuesta.Body.Xmldelsdtdeudas != "")
                    {
                        xml = respuesta.Body.Xmldelsdtdeudas;
                        //Se remplazan caracteres que dan problemas en el C#
                        var xmlReplace = xml.Replace("SDTdeudas.SDTdeudasItem", "SDTdeudasItem");
                        //var xmlReplace = respuesta.Body.Xmldelsdtdeudas.Replace("SDTdeudas.SDTdeudasItem", "SDTdeudasItem");
                        xmlReplace = xmlReplace.Replace(@"<SDTdeudas xmlns=""CopacWeb"">", "<SDTdeudas>");
                        xmlReplace = xmlReplace.Replace(@"<SDTdeudasItem xmlns=""CopacWeb"">", "<SDTdeudasItem>");

                        //Se convierte en XML el la primer aversion del string
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(xmlReplace);

                        //se serializa de nuevo en un string
                        /*var __cdata = JsonConvert.SerializeXmlNode(xmlDoc, Formatting.None, true);
                        var cdataString = __cdata.ToString();

                        //Se remplazan nombres y caracteres que dan problemas en el C#
                        cdataString = cdataString.Replace(@"{""#cdata-section"":""", "");
                        cdataString = cdataString.Replace(@"""}", "");

                        //se serializa la version final de la primera lista
                        XmlDocument xmlDocLista1 = new XmlDocument();
                        xmlDocLista1.LoadXml(cdataString);*/

                        var jsonDeudaLista1 = JsonConvert.SerializeXmlNode(xmlDoc, Formatting.None, true);
                        transactDeudaLista1 = JsonConvert.DeserializeObject<SDTdeudas>(jsonDeudaLista1);

                        //--------------------Fin de la Parte de Xmldelsdtdeudas--------------------
                    }
                    else
                    {
                        transactDeudaLista1 = null; 
                        bandera1 = false;
                    }   
                }
                catch (System.Exception e)
                {
                    transactDeudaLista1 = null;
                    bandera1 = false;
                }

                try
                {
                    //--------------------Parte de Xmldelsdtimportesaingresar--------------------
                    if (respuesta.Body.Xmldelsdtimportesaingresar != null && respuesta.Body.Xmldelsdtimportesaingresar != "")
                    {
                        xml2 = respuesta.Body.Xmldelsdtimportesaingresar;
                        //Se remplazan caracteres que dan problemas en el C#
                        var xmlReplace2 = xml2.Replace("SDTimportesAingresar.SDTimportesAingresarItem", "SDTimportesAingresarItem");
                        //var xmlReplace2 = respuesta.Body.Xmldelsdtimportesaingresar.Replace("SDTimportesAingresar.SDTimportesAingresarItem", "SDTimportesAingresarItem");
                        xmlReplace2 = xmlReplace2.Replace(@"<SDTimportesAingresar xmlns=""CopacWeb"">", "<SDTimportesAingresar>");
                        xmlReplace2 = xmlReplace2.Replace(@"<SDTimportesAingresarItem xmlns=""CopacWeb"">", "<SDTimportesAingresarItem>");

                        //Se convierte en XML el la primer aversion del string
                        XmlDocument xmlDoc2 = new XmlDocument();
                        xmlDoc2.LoadXml(xmlReplace2);

                        //se serializa de nuevo en un string
                        /*var __cdata2 = JsonConvert.SerializeXmlNode(xmlDoc2, Formatting.None, true);
                        var cdataString2 = __cdata2.ToString();

                        //Se remplazan nombres y caracteres que dan problemas en el C#
                        cdataString2 = cdataString2.Replace(@"{""#cdata-section"":""", "");
                        cdataString2 = cdataString2.Replace(@"""}", "");
                        cdataString2 = cdataString2.Replace(@"\\r\\n\\t\\t\\t", "");

                        //se serializa la version final de la primera lista
                        XmlDocument xmlDocLista2 = new XmlDocument();
                        xmlDocLista2.LoadXml(cdataString2);*/

                        var jsonDeudaLista2 = JsonConvert.SerializeXmlNode(xmlDoc2, Formatting.None, true);
                        transactDeudaLista2 = JsonConvert.DeserializeObject<SDTimportesAingresar>(jsonDeudaLista2);

                        //--------------------Fin de la Parte de Xmldelsdtimportesaingresar--------------------
                    }
                    else
                    {
                        transactDeudaLista2 = null;
                        bandera2 = false;
                    }
                }
                catch (System.Exception e)
                {
                    transactDeudaLista2 = null;
                    bandera2 = false;
                }

                var respuestaSoap = new ExecuteResponseResultado();
                respuestaSoap.Saldocapitalsinvencer = respuesta.Body.Saldocapitalsinvencer;
                respuestaSoap.Saldointeresessinvencer = respuesta.Body.Saldointeresessinvencer;
                respuestaSoap.Deudacuotsocsinven = respuesta.Body.Deudacuotsocsinven;
                respuestaSoap.Saldototalsinvencer = respuesta.Body.Saldototalsinvencer;
                respuestaSoap.Saldocapitalvencido = respuesta.Body.Saldocapitalvencido;
                respuestaSoap.Saldointeresvencidos = respuesta.Body.Saldointeresvencidos;
                respuestaSoap.Saldomora = respuesta.Body.Saldomora;
                respuestaSoap.Deudacuotsocven = respuesta.Body.Deudacuotsocven;
                respuestaSoap.Saldototalvencido = respuesta.Body.Saldototalvencido;
                respuestaSoap.Usuariovalido = respuesta.Body.Usuariovalido;
                respuestaSoap.Tienepermiso = respuesta.Body.Tienepermiso;
                respuestaSoap.Mensajeerror = respuesta.Body.Mensajeerror;
                if (bandera1 == true)
                {
                    respuestaSoap.Xmldelsdtdeudas = transactDeudaLista1;
                    CultureInfo es = new CultureInfo("es-ES");

                    foreach (var deuda in respuestaSoap.Xmldelsdtdeudas.SDTdeudasItem)
                    {
                        deuda.Saldo = Math.Round(Convert.ToDouble(deuda.Saldo.Replace(".", ",")), 0).ToString("c", es).Replace(",00 €", "");
                        deuda.SaldoSinMora = Math.Round(Convert.ToDouble(deuda.SaldoSinMora.Replace(".", ",")), 0).ToString("c", es).Replace(",00 €", "");
                        deuda.SaldoCapital = Math.Round(Convert.ToDouble(deuda.SaldoCapital.Replace(".", ",")), 0).ToString("c", es).Replace(",00 €", "");
                        deuda.SaldoInteres = Math.Round(Convert.ToDouble(deuda.SaldoInteres.Replace(".", ",")), 0).ToString("c", es).Replace(",00 €", "");
                        deuda.SaldoIVA = Math.Round(Convert.ToDouble(deuda.SaldoIVA.Replace(".", ",")), 0).ToString("c", es).Replace(",00 €", "");
                        deuda.SaldoMora = Math.Round(Convert.ToDouble(deuda.SaldoMora.Replace(".", ",")), 0).ToString("c", es).Replace(",00 €", "");
                    }
                }
                else
                {
                    respuestaSoap.Xmldelsdtdeudas = null;
                }

                if (bandera2 == true)
                {
                    respuestaSoap.Xmldelsdtimportesaingresar = transactDeudaLista2;
                }
                else
                {
                    respuestaSoap.Xmldelsdtimportesaingresar = null;
                }

                return respuestaSoap;
            }
            else{
                return null;
            }
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoSoap.ServicioSoap {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="CopacWeb", ConfigurationName="ServicioSoap.WSSocDeuSoapPort")]
    public interface WSSocDeuSoapPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="CopacWebaction/AWSSOCDEU.Execute", ReplyAction="*")]
        ProyectoSoap.ServicioSoap.ExecuteResponse Execute(ProyectoSoap.ServicioSoap.ExecuteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="CopacWebaction/AWSSOCDEU.Execute", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoSoap.ServicioSoap.ExecuteResponse> ExecuteAsync(ProyectoSoap.ServicioSoap.ExecuteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSSocDeu.Execute", Namespace="CopacWeb", Order=0)]
        public ProyectoSoap.ServicioSoap.ExecuteRequestBody Body;
        
        public ExecuteRequest() {
        }
        
        public ExecuteRequest(ProyectoSoap.ServicioSoap.ExecuteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="CopacWeb")]
    public partial class ExecuteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Wsusucod;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Passsinencriptar;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Socdoc;
        
        public ExecuteRequestBody() {
        }
        
        public ExecuteRequestBody(string Wsusucod, string Passsinencriptar, string Socdoc) {
            this.Wsusucod = Wsusucod;
            this.Passsinencriptar = Passsinencriptar;
            this.Socdoc = Socdoc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSSocDeu.ExecuteResponse", Namespace="CopacWeb", Order=0)]
        public ProyectoSoap.ServicioSoap.ExecuteResponseBody Body;
        
        public ExecuteResponse() {
        }
        
        public ExecuteResponse(ProyectoSoap.ServicioSoap.ExecuteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="CopacWeb")]
    public partial class ExecuteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Xmldelsdtdeudas;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Xmldelsdtimportesaingresar;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public double Saldocapitalsinvencer;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public double Saldointeresessinvencer;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public double Deudacuotsocsinven;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public double Saldototalsinvencer;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public double Saldocapitalvencido;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public double Saldointeresvencidos;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public double Saldomora;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=9)]
        public double Deudacuotsocven;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=10)]
        public double Saldototalvencido;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=11)]
        public bool Usuariovalido;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=12)]
        public bool Tienepermiso;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public string Mensajeerror;
        
        public ExecuteResponseBody() {
        }
        
        public ExecuteResponseBody(string Xmldelsdtdeudas, string Xmldelsdtimportesaingresar, double Saldocapitalsinvencer, double Saldointeresessinvencer, double Deudacuotsocsinven, double Saldototalsinvencer, double Saldocapitalvencido, double Saldointeresvencidos, double Saldomora, double Deudacuotsocven, double Saldototalvencido, bool Usuariovalido, bool Tienepermiso, string Mensajeerror) {
            this.Xmldelsdtdeudas = Xmldelsdtdeudas;
            this.Xmldelsdtimportesaingresar = Xmldelsdtimportesaingresar;
            this.Saldocapitalsinvencer = Saldocapitalsinvencer;
            this.Saldointeresessinvencer = Saldointeresessinvencer;
            this.Deudacuotsocsinven = Deudacuotsocsinven;
            this.Saldototalsinvencer = Saldototalsinvencer;
            this.Saldocapitalvencido = Saldocapitalvencido;
            this.Saldointeresvencidos = Saldointeresvencidos;
            this.Saldomora = Saldomora;
            this.Deudacuotsocven = Deudacuotsocven;
            this.Saldototalvencido = Saldototalvencido;
            this.Usuariovalido = Usuariovalido;
            this.Tienepermiso = Tienepermiso;
            this.Mensajeerror = Mensajeerror;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSSocDeuSoapPortChannel : ProyectoSoap.ServicioSoap.WSSocDeuSoapPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSSocDeuSoapPortClient : System.ServiceModel.ClientBase<ProyectoSoap.ServicioSoap.WSSocDeuSoapPort>, ProyectoSoap.ServicioSoap.WSSocDeuSoapPort {
        
        public WSSocDeuSoapPortClient() {
        }
        
        public WSSocDeuSoapPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSSocDeuSoapPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSSocDeuSoapPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSSocDeuSoapPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoSoap.ServicioSoap.ExecuteResponse ProyectoSoap.ServicioSoap.WSSocDeuSoapPort.Execute(ProyectoSoap.ServicioSoap.ExecuteRequest request) {
            return base.Channel.Execute(request);
        }
        
        public string Execute(
                    string Wsusucod, 
                    string Passsinencriptar, 
                    string Socdoc, 
                    out string Xmldelsdtimportesaingresar, 
                    out double Saldocapitalsinvencer, 
                    out double Saldointeresessinvencer, 
                    out double Deudacuotsocsinven, 
                    out double Saldototalsinvencer, 
                    out double Saldocapitalvencido, 
                    out double Saldointeresvencidos, 
                    out double Saldomora, 
                    out double Deudacuotsocven, 
                    out double Saldototalvencido, 
                    out bool Usuariovalido, 
                    out bool Tienepermiso, 
                    out string Mensajeerror) {
            ProyectoSoap.ServicioSoap.ExecuteRequest inValue = new ProyectoSoap.ServicioSoap.ExecuteRequest();
            inValue.Body = new ProyectoSoap.ServicioSoap.ExecuteRequestBody();
            inValue.Body.Wsusucod = Wsusucod;
            inValue.Body.Passsinencriptar = Passsinencriptar;
            inValue.Body.Socdoc = Socdoc;
            ProyectoSoap.ServicioSoap.ExecuteResponse retVal = ((ProyectoSoap.ServicioSoap.WSSocDeuSoapPort)(this)).Execute(inValue);
            Xmldelsdtimportesaingresar = retVal.Body.Xmldelsdtimportesaingresar;
            Saldocapitalsinvencer = retVal.Body.Saldocapitalsinvencer;
            Saldointeresessinvencer = retVal.Body.Saldointeresessinvencer;
            Deudacuotsocsinven = retVal.Body.Deudacuotsocsinven;
            Saldototalsinvencer = retVal.Body.Saldototalsinvencer;
            Saldocapitalvencido = retVal.Body.Saldocapitalvencido;
            Saldointeresvencidos = retVal.Body.Saldointeresvencidos;
            Saldomora = retVal.Body.Saldomora;
            Deudacuotsocven = retVal.Body.Deudacuotsocven;
            Saldototalvencido = retVal.Body.Saldototalvencido;
            Usuariovalido = retVal.Body.Usuariovalido;
            Tienepermiso = retVal.Body.Tienepermiso;
            Mensajeerror = retVal.Body.Mensajeerror;
            return retVal.Body.Xmldelsdtdeudas;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoSoap.ServicioSoap.ExecuteResponse> ProyectoSoap.ServicioSoap.WSSocDeuSoapPort.ExecuteAsync(ProyectoSoap.ServicioSoap.ExecuteRequest request) {
            return base.Channel.ExecuteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoSoap.ServicioSoap.ExecuteResponse> ExecuteAsync(string Wsusucod, string Passsinencriptar, string Socdoc) {
            ProyectoSoap.ServicioSoap.ExecuteRequest inValue = new ProyectoSoap.ServicioSoap.ExecuteRequest();
            inValue.Body = new ProyectoSoap.ServicioSoap.ExecuteRequestBody();
            inValue.Body.Wsusucod = Wsusucod;
            inValue.Body.Passsinencriptar = Passsinencriptar;
            inValue.Body.Socdoc = Socdoc;
            return ((ProyectoSoap.ServicioSoap.WSSocDeuSoapPort)(this)).ExecuteAsync(inValue);
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.BanxicoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.dgie.banxico.org.mx", ConfigurationName="BanxicoService.DgieWSPort")]
    public interface DgieWSPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        string reservasInternacionalesBanxico();
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        System.Threading.Tasks.Task<string> reservasInternacionalesBanxicoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        string tasasDeInteresBanxico();
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        System.Threading.Tasks.Task<string> tasasDeInteresBanxicoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        string tiposDeCambioBanxico();
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        System.Threading.Tasks.Task<string> tiposDeCambioBanxicoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        string udisBanxico();
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        System.Threading.Tasks.Task<string> udisBanxicoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DgieWSPortChannel : App.BanxicoService.DgieWSPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DgieWSPortClient : System.ServiceModel.ClientBase<App.BanxicoService.DgieWSPort>, App.BanxicoService.DgieWSPort {
        
        public DgieWSPortClient() {
        }
        
        public DgieWSPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DgieWSPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DgieWSPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DgieWSPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string reservasInternacionalesBanxico() {
            return base.Channel.reservasInternacionalesBanxico();
        }
        
        public System.Threading.Tasks.Task<string> reservasInternacionalesBanxicoAsync() {
            return base.Channel.reservasInternacionalesBanxicoAsync();
        }
        
        public string tasasDeInteresBanxico() {
            return base.Channel.tasasDeInteresBanxico();
        }
        
        public System.Threading.Tasks.Task<string> tasasDeInteresBanxicoAsync() {
            return base.Channel.tasasDeInteresBanxicoAsync();
        }
        
        public string tiposDeCambioBanxico() {
            return base.Channel.tiposDeCambioBanxico();
        }
        
        public System.Threading.Tasks.Task<string> tiposDeCambioBanxicoAsync() {
            return base.Channel.tiposDeCambioBanxicoAsync();
        }
        
        public string udisBanxico() {
            return base.Channel.udisBanxico();
        }
        
        public System.Threading.Tasks.Task<string> udisBanxicoAsync() {
            return base.Channel.udisBanxicoAsync();
        }
    }
}
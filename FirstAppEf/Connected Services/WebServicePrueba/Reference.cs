﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServicePrueba
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServicePrueba.IMiWebServiceDePrueba")]
    public interface IMiWebServiceDePrueba
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMiWebServiceDePrueba/DevolvemeElNombre", ReplyAction="http://tempuri.org/IMiWebServiceDePrueba/DevolvemeElNombreResponse")]
        System.Threading.Tasks.Task<string> DevolvemeElNombreAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IMiWebServiceDePruebaChannel : WebServicePrueba.IMiWebServiceDePrueba, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class MiWebServiceDePruebaClient : System.ServiceModel.ClientBase<WebServicePrueba.IMiWebServiceDePrueba>, WebServicePrueba.IMiWebServiceDePrueba
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MiWebServiceDePruebaClient(EndpointConfiguration endpointConfiguration) : 
                base(MiWebServiceDePruebaClient.GetBindingForEndpoint(endpointConfiguration), MiWebServiceDePruebaClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MiWebServiceDePruebaClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MiWebServiceDePruebaClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MiWebServiceDePruebaClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MiWebServiceDePruebaClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MiWebServiceDePruebaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        public System.Threading.Tasks.Task<string> DevolvemeElNombreAsync()
        {
            return base.Channel.DevolvemeElNombreAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMiWebServiceDePrueba))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IMiWebServiceDePrueba))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMiWebServiceDePrueba))
            {
                return new System.ServiceModel.EndpointAddress("http://nbar15227/WcfService1/MiWebServiceDePrueba.svc");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IMiWebServiceDePrueba))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost/WcfService1/MiWebServiceDePrueba.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMiWebServiceDePrueba,
            
            BasicHttpsBinding_IMiWebServiceDePrueba,
        }
    }
}

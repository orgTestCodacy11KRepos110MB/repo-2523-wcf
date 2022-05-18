//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReliableSessionService_NS
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReliableSessionService_NS.IWcfReliableService")]
    public interface IWcfReliableService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfReliableService/GetNextNumber", ReplyAction="http://tempuri.org/IWcfReliableService/GetNextNumberResponse")]
        System.Threading.Tasks.Task<int> GetNextNumberAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfReliableService/Echo", ReplyAction="http://tempuri.org/IWcfReliableService/EchoResponse")]
        System.Threading.Tasks.Task<string> EchoAsync(string echo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    public interface IWcfReliableServiceChannel : ReliableSessionService_NS.IWcfReliableService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "99.99.99")]
    public partial class WcfReliableServiceClient : System.ServiceModel.ClientBase<ReliableSessionService_NS.IWcfReliableService>, ReliableSessionService_NS.IWcfReliableService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WcfReliableServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(WcfReliableServiceClient.GetBindingForEndpoint(endpointConfiguration), WcfReliableServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WcfReliableServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WcfReliableServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WcfReliableServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WcfReliableServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WcfReliableServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<int> GetNextNumberAsync()
        {
            return base.Channel.GetNextNumberAsync();
        }
        
        public System.Threading.Tasks.Task<string> EchoAsync(string echo)
        {
            return base.Channel.EchoAsync(echo);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetHttpOrdered_WSReliableMessaging11_IWcfReliableService))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.ReliableSessionBindingElement reliableBindingElement = new System.ServiceModel.Channels.ReliableSessionBindingElement();
                reliableBindingElement.ReliableMessagingVersion = System.ServiceModel.ReliableMessagingVersion.WSReliableMessaging11;
                result.Elements.Add(reliableBindingElement);
                result.Elements.Add(new System.ServiceModel.Channels.BinaryMessageEncodingBindingElement());
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.NetHttpUnordered_WSReliableMessaging11_IWcfReliableService))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.ReliableSessionBindingElement reliableBindingElement = new System.ServiceModel.Channels.ReliableSessionBindingElement();
                reliableBindingElement.Ordered = false;
                reliableBindingElement.ReliableMessagingVersion = System.ServiceModel.ReliableMessagingVersion.WSReliableMessaging11;
                result.Elements.Add(reliableBindingElement);
                result.Elements.Add(new System.ServiceModel.Channels.BinaryMessageEncodingBindingElement());
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.NetHttpOrdered_WSReliableMessagingFebruary2005_IWcfReliableService))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.ReliableSessionBindingElement reliableBindingElement = new System.ServiceModel.Channels.ReliableSessionBindingElement();
                result.Elements.Add(reliableBindingElement);
                result.Elements.Add(new System.ServiceModel.Channels.BinaryMessageEncodingBindingElement());
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.NetHttpUnordered_WSReliableMessagingFebruary2005_IWcfReliableService))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.ReliableSessionBindingElement reliableBindingElement = new System.ServiceModel.Channels.ReliableSessionBindingElement();
                result.Elements.Add(reliableBindingElement);
                result.Elements.Add(new System.ServiceModel.Channels.BinaryMessageEncodingBindingElement());
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.NetTcpOrdered_WSReliableMessaging11_IWcfReliableService))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.ReliableSessionBindingElement reliableBindingElement = new System.ServiceModel.Channels.ReliableSessionBindingElement();
                reliableBindingElement.ReliableMessagingVersion = System.ServiceModel.ReliableMessagingVersion.WSReliableMessaging11;
                result.Elements.Add(reliableBindingElement);
                result.Elements.Add(new System.ServiceModel.Channels.BinaryMessageEncodingBindingElement());
                System.ServiceModel.Channels.TcpTransportBindingElement tcpBindingElement = new System.ServiceModel.Channels.TcpTransportBindingElement();
                tcpBindingElement.MaxBufferSize = int.MaxValue;
                tcpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(tcpBindingElement);
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.NetTcpUnordered_WSReliableMessaging11_IWcfReliableService))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.ReliableSessionBindingElement reliableBindingElement = new System.ServiceModel.Channels.ReliableSessionBindingElement();
                reliableBindingElement.Ordered = false;
                reliableBindingElement.ReliableMessagingVersion = System.ServiceModel.ReliableMessagingVersion.WSReliableMessaging11;
                result.Elements.Add(reliableBindingElement);
                result.Elements.Add(new System.ServiceModel.Channels.BinaryMessageEncodingBindingElement());
                System.ServiceModel.Channels.TcpTransportBindingElement tcpBindingElement = new System.ServiceModel.Channels.TcpTransportBindingElement();
                tcpBindingElement.MaxBufferSize = int.MaxValue;
                tcpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(tcpBindingElement);
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.NetTcpOrdered_WSReliableMessagingFebruary2005_IWcfReliableService))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                result.ReliableSession.Enabled = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.NetTcpUnordered_WSReliableMessagingFebruary2005_IWcfReliableService))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                result.ReliableSession.Enabled = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WSHttpOrdered_WSReliableMessaging11_IWcfReliableService))
            {
                System.ServiceModel.WS2007HttpBinding result = new System.ServiceModel.WS2007HttpBinding();
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.ReliableSession.Enabled = true;
                result.ReliableSession.Ordered = true;
                result.ReliableSession.InactivityTimeout = new System.TimeSpan(6000000000);
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WSHttpUnordered_WSReliableMessaging11_IWcfReliableService))
            {
                System.ServiceModel.WS2007HttpBinding result = new System.ServiceModel.WS2007HttpBinding();
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.ReliableSession.Enabled = true;
                result.ReliableSession.Ordered = false;
                result.ReliableSession.InactivityTimeout = new System.TimeSpan(6000000000);
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WSHttpOrdered_WSReliableMessagingFebruary2005_IWcfReliableService))
            {
                System.ServiceModel.WSHttpBinding result = new System.ServiceModel.WSHttpBinding();
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.ReliableSession.Enabled = true;
                result.ReliableSession.Ordered = true;
                result.ReliableSession.InactivityTimeout = new System.TimeSpan(6000000000);
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WSHttpUnordered_WSReliableMessagingFebruary2005_IWcfReliableService))
            {
                System.ServiceModel.WSHttpBinding result = new System.ServiceModel.WSHttpBinding();
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.ReliableSession.Enabled = true;
                result.ReliableSession.Ordered = true;
                result.ReliableSession.InactivityTimeout = new System.TimeSpan(6000000000);
                result.Security.Mode = System.ServiceModel.SecurityMode.None;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetHttpOrdered_WSReliableMessaging11_IWcfReliableService))
            {
                return new System.ServiceModel.EndpointAddress("http://wcfcoresrv5.westus2.cloudapp.azure.com/WcfTestService1/ReliableSessionServ" +
                        "ice.svc/NetHttpOrdered_WSReliableMessaging11");
            }
            if ((endpointConfiguration == EndpointConfiguration.NetHttpUnordered_WSReliableMessaging11_IWcfReliableService))
            {
                return new System.ServiceModel.EndpointAddress("http://wcfcoresrv5.westus2.cloudapp.azure.com/WcfTestService1/ReliableSessionServ" +
                        "ice.svc/NetHttpUnordered_WSReliableMessaging11");
            }
            if ((endpointConfiguration == EndpointConfiguration.NetHttpOrdered_WSReliableMessagingFebruary2005_IWcfReliableService))
            {
                return new System.ServiceModel.EndpointAddress("http://wcfcoresrv5.westus2.cloudapp.azure.com/WcfTestService1/ReliableSessionServ" +
                        "ice.svc/NetHttpOrdered_WSReliableMessagingFebruary2005");
            }
            if ((endpointConfiguration == EndpointConfiguration.NetHttpUnordered_WSReliableMessagingFebruary2005_IWcfReliableService))
            {
                return new System.ServiceModel.EndpointAddress("http://wcfcoresrv5.westus2.cloudapp.azure.com/WcfTestService1/ReliableSessionServ" +
                        "ice.svc/NetHttpUnordered_WSReliableMessagingFebruary2005");
            }
            if ((endpointConfiguration == EndpointConfiguration.NetTcpOrdered_WSReliableMessaging11_IWcfReliableService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://wcfcoresrv5/WcfTestService1/ReliableSessionService.svc/NetTcpOrdered_WS" +
                        "ReliableMessaging11");
            }
            if ((endpointConfiguration == EndpointConfiguration.NetTcpUnordered_WSReliableMessaging11_IWcfReliableService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://wcfcoresrv5/WcfTestService1/ReliableSessionService.svc/NetTcpUnordered_" +
                        "WSReliableMessaging11");
            }
            if ((endpointConfiguration == EndpointConfiguration.NetTcpOrdered_WSReliableMessagingFebruary2005_IWcfReliableService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://wcfcoresrv5/WcfTestService1/ReliableSessionService.svc/NetTcpOrdered_WS" +
                        "ReliableMessagingFebruary2005");
            }
            if ((endpointConfiguration == EndpointConfiguration.NetTcpUnordered_WSReliableMessagingFebruary2005_IWcfReliableService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://wcfcoresrv5/WcfTestService1/ReliableSessionService.svc/NetTcpUnordered_" +
                        "WSReliableMessagingFebruary2005");
            }
            if ((endpointConfiguration == EndpointConfiguration.WSHttpOrdered_WSReliableMessaging11_IWcfReliableService))
            {
                return new System.ServiceModel.EndpointAddress("http://wcfcoresrv5.westus2.cloudapp.azure.com/WcfTestService1/ReliableSessionServ" +
                        "ice.svc/WSHttpOrdered_WSReliableMessaging11");
            }
            if ((endpointConfiguration == EndpointConfiguration.WSHttpUnordered_WSReliableMessaging11_IWcfReliableService))
            {
                return new System.ServiceModel.EndpointAddress("http://wcfcoresrv5.westus2.cloudapp.azure.com/WcfTestService1/ReliableSessionServ" +
                        "ice.svc/WSHttpUnordered_WSReliableMessaging11");
            }
            if ((endpointConfiguration == EndpointConfiguration.WSHttpOrdered_WSReliableMessagingFebruary2005_IWcfReliableService))
            {
                return new System.ServiceModel.EndpointAddress("http://wcfcoresrv5.westus2.cloudapp.azure.com/WcfTestService1/ReliableSessionServ" +
                        "ice.svc/WSHttpOrdered_WSReliableMessagingFebruary2005");
            }
            if ((endpointConfiguration == EndpointConfiguration.WSHttpUnordered_WSReliableMessagingFebruary2005_IWcfReliableService))
            {
                return new System.ServiceModel.EndpointAddress("http://wcfcoresrv5.westus2.cloudapp.azure.com/WcfTestService1/ReliableSessionServ" +
                        "ice.svc/WSHttpUnordered_WSReliableMessagingFebruary2005");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            NetHttpOrdered_WSReliableMessaging11_IWcfReliableService,
            
            NetHttpUnordered_WSReliableMessaging11_IWcfReliableService,
            
            NetHttpOrdered_WSReliableMessagingFebruary2005_IWcfReliableService,
            
            NetHttpUnordered_WSReliableMessagingFebruary2005_IWcfReliableService,
            
            NetTcpOrdered_WSReliableMessaging11_IWcfReliableService,
            
            NetTcpUnordered_WSReliableMessaging11_IWcfReliableService,
            
            NetTcpOrdered_WSReliableMessagingFebruary2005_IWcfReliableService,
            
            NetTcpUnordered_WSReliableMessagingFebruary2005_IWcfReliableService,
            
            WSHttpOrdered_WSReliableMessaging11_IWcfReliableService,
            
            WSHttpUnordered_WSReliableMessaging11_IWcfReliableService,
            
            WSHttpOrdered_WSReliableMessagingFebruary2005_IWcfReliableService,
            
            WSHttpUnordered_WSReliableMessagingFebruary2005_IWcfReliableService,
        }
    }
}
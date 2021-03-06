//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     .NET Micro Framework MFSvcUtil.Exe
//     Runtime Version:2.0.00001.0001
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Text;
using System.Xml;
using Dpws.Device;
using Dpws.Device.Services;
using Ws.Services;
using Ws.Services.WsaAddressing;
using Ws.Services.Xml;

namespace localhost.WineMonitorDevice
{
    
    
    public class IWineMonitorRequest : DpwsHostedService
    {
        
        private IIWineMonitorRequest m_service = null;
        
        public IWineMonitorRequest(IIWineMonitorRequest service)
        {
            // Set the service implementation properties
            m_service = service;

            // Set base service properties
            ServiceNamespace = new WsXmlNamespace("iwi", "http://localhost/WineMonitorDevice/");
            ServiceID = "urn:uuid:8f122bc8-58ba-4676-a424-3d501f5bbacd";
            ServiceTypeName = "IWineMonitorRequest";

            // Add service types here
            ServiceOperations.Add(new WsServiceOperation("http://localhost/WineMonitorDevice/IWineMonitorRequest", "GetSensorData"));

            // Add event sources here
        }
        
        public virtual Byte[] GetSensorData(WsWsaHeader header, XmlReader reader)
        {
            // Build request object
            GetSensorDataDataContractSerializer reqDcs;
            reqDcs = new GetSensorDataDataContractSerializer("GetSensorData", "http://localhost/WineMonitorDevice/");
            GetSensorData req;
            req = ((GetSensorData)(reqDcs.ReadObject(reader)));

            // Create response object
            // Call service operation to process request and return response.
            GetSensorDataResponse resp;
            resp = m_service.GetSensorData(req);

            // Create response header
            WsWsaHeader respHeader = new WsWsaHeader("http://localhost/WineMonitorDevice/IWineMonitorRequest/GetSensorDataResponse", header.MessageID, WsWellKnownUri.WsaAnonymousUri, null, null, null);

            // Create response serializer
            GetSensorDataResponseDataContractSerializer respDcs;
            respDcs = new GetSensorDataResponseDataContractSerializer("GetSensorDataResponse", "http://localhost/WineMonitorDevice/");

            // Build response message and return
            return SoapMessageBuilder.BuildSoapMessage(respHeader, respDcs, resp);
        }
    }
}

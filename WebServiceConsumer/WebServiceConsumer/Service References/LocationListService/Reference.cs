﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceConsumer.LocationListService {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ITMD466/")]
    public partial class Exception : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ITMD466/")]
    public partial class location : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string addressStreet1Field;
        
        private string addressStreet2Field;
        
        private string cityField;
        
        private string customerIDField;
        
        private string isAuctionField;
        
        private string locationCodeField;
        
        private string locationContactNameField;
        
        private string locationEmailField;
        
        private string locationFaxNumberField;
        
        private string locationIDField;
        
        private string locationNameField;
        
        private string locationPhoneField;
        
        private string postalcodeField;
        
        private string stateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string addressStreet1 {
            get {
                return this.addressStreet1Field;
            }
            set {
                this.addressStreet1Field = value;
                this.RaisePropertyChanged("addressStreet1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string addressStreet2 {
            get {
                return this.addressStreet2Field;
            }
            set {
                this.addressStreet2Field = value;
                this.RaisePropertyChanged("addressStreet2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
                this.RaisePropertyChanged("city");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string customerID {
            get {
                return this.customerIDField;
            }
            set {
                this.customerIDField = value;
                this.RaisePropertyChanged("customerID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string isAuction {
            get {
                return this.isAuctionField;
            }
            set {
                this.isAuctionField = value;
                this.RaisePropertyChanged("isAuction");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string locationCode {
            get {
                return this.locationCodeField;
            }
            set {
                this.locationCodeField = value;
                this.RaisePropertyChanged("locationCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string locationContactName {
            get {
                return this.locationContactNameField;
            }
            set {
                this.locationContactNameField = value;
                this.RaisePropertyChanged("locationContactName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string locationEmail {
            get {
                return this.locationEmailField;
            }
            set {
                this.locationEmailField = value;
                this.RaisePropertyChanged("locationEmail");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string locationFaxNumber {
            get {
                return this.locationFaxNumberField;
            }
            set {
                this.locationFaxNumberField = value;
                this.RaisePropertyChanged("locationFaxNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string locationID {
            get {
                return this.locationIDField;
            }
            set {
                this.locationIDField = value;
                this.RaisePropertyChanged("locationID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string locationName {
            get {
                return this.locationNameField;
            }
            set {
                this.locationNameField = value;
                this.RaisePropertyChanged("locationName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string locationPhone {
            get {
                return this.locationPhoneField;
            }
            set {
                this.locationPhoneField = value;
                this.RaisePropertyChanged("locationPhone");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string postalcode {
            get {
                return this.postalcodeField;
            }
            set {
                this.postalcodeField = value;
                this.RaisePropertyChanged("postalcode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
                this.RaisePropertyChanged("state");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ITMD466/", ConfigurationName="LocationListService.LocationList")]
    public interface LocationList {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ITMD466/LocationList/listLocationsRequest", ReplyAction="http://ITMD466/LocationList/listLocationsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebServiceConsumer.LocationListService.Exception), Action="http://ITMD466/LocationList/listLocations/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebServiceConsumer.LocationListService.listLocationsResponse listLocations(WebServiceConsumer.LocationListService.listLocationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ITMD466/LocationList/listLocationsRequest", ReplyAction="http://ITMD466/LocationList/listLocationsResponse")]
        System.Threading.Tasks.Task<WebServiceConsumer.LocationListService.listLocationsResponse> listLocationsAsync(WebServiceConsumer.LocationListService.listLocationsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listLocations", WrapperNamespace="http://ITMD466/", IsWrapped=true)]
    public partial class listLocationsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ITMD466/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string locationCode;
        
        public listLocationsRequest() {
        }
        
        public listLocationsRequest(string locationCode) {
            this.locationCode = locationCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listLocationsResponse", WrapperNamespace="http://ITMD466/", IsWrapped=true)]
    public partial class listLocationsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ITMD466/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WebServiceConsumer.LocationListService.location[] @return;
        
        public listLocationsResponse() {
        }
        
        public listLocationsResponse(WebServiceConsumer.LocationListService.location[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LocationListChannel : WebServiceConsumer.LocationListService.LocationList, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LocationListClient : System.ServiceModel.ClientBase<WebServiceConsumer.LocationListService.LocationList>, WebServiceConsumer.LocationListService.LocationList {
        
        public LocationListClient() {
        }
        
        public LocationListClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LocationListClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LocationListClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LocationListClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceConsumer.LocationListService.listLocationsResponse WebServiceConsumer.LocationListService.LocationList.listLocations(WebServiceConsumer.LocationListService.listLocationsRequest request) {
            return base.Channel.listLocations(request);
        }
        
        public WebServiceConsumer.LocationListService.location[] listLocations(string locationCode) {
            WebServiceConsumer.LocationListService.listLocationsRequest inValue = new WebServiceConsumer.LocationListService.listLocationsRequest();
            inValue.locationCode = locationCode;
            WebServiceConsumer.LocationListService.listLocationsResponse retVal = ((WebServiceConsumer.LocationListService.LocationList)(this)).listLocations(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceConsumer.LocationListService.listLocationsResponse> WebServiceConsumer.LocationListService.LocationList.listLocationsAsync(WebServiceConsumer.LocationListService.listLocationsRequest request) {
            return base.Channel.listLocationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceConsumer.LocationListService.listLocationsResponse> listLocationsAsync(string locationCode) {
            WebServiceConsumer.LocationListService.listLocationsRequest inValue = new WebServiceConsumer.LocationListService.listLocationsRequest();
            inValue.locationCode = locationCode;
            return ((WebServiceConsumer.LocationListService.LocationList)(this)).listLocationsAsync(inValue);
        }
    }
}
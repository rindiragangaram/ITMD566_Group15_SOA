﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceConsumer.CommentListService {
    
    
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
    public partial class comment : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string commentDateTimeField;
        
        private string commentIDField;
        
        private string customerIDField;
        
        private string locationIDField;
        
        private string transactionIDField;
        
        private string truckIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string commentDateTime {
            get {
                return this.commentDateTimeField;
            }
            set {
                this.commentDateTimeField = value;
                this.RaisePropertyChanged("commentDateTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string commentID {
            get {
                return this.commentIDField;
            }
            set {
                this.commentIDField = value;
                this.RaisePropertyChanged("commentID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string transactionID {
            get {
                return this.transactionIDField;
            }
            set {
                this.transactionIDField = value;
                this.RaisePropertyChanged("transactionID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string truckID {
            get {
                return this.truckIDField;
            }
            set {
                this.truckIDField = value;
                this.RaisePropertyChanged("truckID");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ITMD466/", ConfigurationName="CommentListService.CommentList")]
    public interface CommentList {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ITMD466/CommentList/TransactionIDRequest", ReplyAction="http://ITMD466/CommentList/TransactionIDResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebServiceConsumer.CommentListService.Exception), Action="http://ITMD466/CommentList/TransactionID/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebServiceConsumer.CommentListService.TransactionIDResponse TransactionID(WebServiceConsumer.CommentListService.TransactionIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ITMD466/CommentList/TransactionIDRequest", ReplyAction="http://ITMD466/CommentList/TransactionIDResponse")]
        System.Threading.Tasks.Task<WebServiceConsumer.CommentListService.TransactionIDResponse> TransactionIDAsync(WebServiceConsumer.CommentListService.TransactionIDRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TransactionID", WrapperNamespace="http://ITMD466/", IsWrapped=true)]
    public partial class TransactionIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ITMD466/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string transactionID;
        
        public TransactionIDRequest() {
        }
        
        public TransactionIDRequest(string transactionID) {
            this.transactionID = transactionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TransactionIDResponse", WrapperNamespace="http://ITMD466/", IsWrapped=true)]
    public partial class TransactionIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ITMD466/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WebServiceConsumer.CommentListService.comment[] @return;
        
        public TransactionIDResponse() {
        }
        
        public TransactionIDResponse(WebServiceConsumer.CommentListService.comment[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CommentListChannel : WebServiceConsumer.CommentListService.CommentList, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CommentListClient : System.ServiceModel.ClientBase<WebServiceConsumer.CommentListService.CommentList>, WebServiceConsumer.CommentListService.CommentList {
        
        public CommentListClient() {
        }
        
        public CommentListClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CommentListClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommentListClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommentListClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceConsumer.CommentListService.TransactionIDResponse WebServiceConsumer.CommentListService.CommentList.TransactionID(WebServiceConsumer.CommentListService.TransactionIDRequest request) {
            return base.Channel.TransactionID(request);
        }
        
        public WebServiceConsumer.CommentListService.comment[] TransactionID(string transactionID1) {
            WebServiceConsumer.CommentListService.TransactionIDRequest inValue = new WebServiceConsumer.CommentListService.TransactionIDRequest();
            inValue.transactionID = transactionID1;
            WebServiceConsumer.CommentListService.TransactionIDResponse retVal = ((WebServiceConsumer.CommentListService.CommentList)(this)).TransactionID(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceConsumer.CommentListService.TransactionIDResponse> WebServiceConsumer.CommentListService.CommentList.TransactionIDAsync(WebServiceConsumer.CommentListService.TransactionIDRequest request) {
            return base.Channel.TransactionIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceConsumer.CommentListService.TransactionIDResponse> TransactionIDAsync(string transactionID) {
            WebServiceConsumer.CommentListService.TransactionIDRequest inValue = new WebServiceConsumer.CommentListService.TransactionIDRequest();
            inValue.transactionID = transactionID;
            return ((WebServiceConsumer.CommentListService.CommentList)(this)).TransactionIDAsync(inValue);
        }
    }
}

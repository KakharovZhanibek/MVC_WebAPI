﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Soap_Client.WS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        private int YearField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WS.WSSoap")]
    public interface WSSoap {
        
        // CODEGEN: Generating message contract since element name FirstResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/First", ReplyAction="*")]
        Soap_Client.WS.FirstResponse First(Soap_Client.WS.FirstRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/First", ReplyAction="*")]
        System.Threading.Tasks.Task<Soap_Client.WS.FirstResponse> FirstAsync(Soap_Client.WS.FirstRequest request);
        
        // CODEGEN: Generating message contract since element name SecondResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Second", ReplyAction="*")]
        Soap_Client.WS.SecondResponse Second(Soap_Client.WS.SecondRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Second", ReplyAction="*")]
        System.Threading.Tasks.Task<Soap_Client.WS.SecondResponse> SecondAsync(Soap_Client.WS.SecondRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        Soap_Client.WS.GetAllResponse GetAll(Soap_Client.WS.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<Soap_Client.WS.GetAllResponse> GetAllAsync(Soap_Client.WS.GetAllRequest request);
        
        // CODEGEN: Generating message contract since element name GetBookByRangeResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBookByRange", ReplyAction="*")]
        Soap_Client.WS.GetBookByRangeResponse GetBookByRange(Soap_Client.WS.GetBookByRangeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBookByRange", ReplyAction="*")]
        System.Threading.Tasks.Task<Soap_Client.WS.GetBookByRangeResponse> GetBookByRangeAsync(Soap_Client.WS.GetBookByRangeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FirstRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="First", Namespace="http://tempuri.org/", Order=0)]
        public Soap_Client.WS.FirstRequestBody Body;
        
        public FirstRequest() {
        }
        
        public FirstRequest(Soap_Client.WS.FirstRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FirstRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public FirstRequestBody() {
        }
        
        public FirstRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FirstResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FirstResponse", Namespace="http://tempuri.org/", Order=0)]
        public Soap_Client.WS.FirstResponseBody Body;
        
        public FirstResponse() {
        }
        
        public FirstResponse(Soap_Client.WS.FirstResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FirstResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Soap_Client.WS.Book FirstResult;
        
        public FirstResponseBody() {
        }
        
        public FirstResponseBody(Soap_Client.WS.Book FirstResult) {
            this.FirstResult = FirstResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SecondRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Second", Namespace="http://tempuri.org/", Order=0)]
        public Soap_Client.WS.SecondRequestBody Body;
        
        public SecondRequest() {
        }
        
        public SecondRequest(Soap_Client.WS.SecondRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SecondRequestBody {
        
        public SecondRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SecondResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SecondResponse", Namespace="http://tempuri.org/", Order=0)]
        public Soap_Client.WS.SecondResponseBody Body;
        
        public SecondResponse() {
        }
        
        public SecondResponse(Soap_Client.WS.SecondResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SecondResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Soap_Client.WS.Book[] SecondResult;
        
        public SecondResponseBody() {
        }
        
        public SecondResponseBody(Soap_Client.WS.Book[] SecondResult) {
            this.SecondResult = SecondResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public Soap_Client.WS.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(Soap_Client.WS.GetAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRequestBody {
        
        public GetAllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public Soap_Client.WS.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(Soap_Client.WS.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Soap_Client.WS.Book[] GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(Soap_Client.WS.Book[] GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBookByRangeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBookByRange", Namespace="http://tempuri.org/", Order=0)]
        public Soap_Client.WS.GetBookByRangeRequestBody Body;
        
        public GetBookByRangeRequest() {
        }
        
        public GetBookByRangeRequest(Soap_Client.WS.GetBookByRangeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetBookByRangeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int startRange;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int endRange;
        
        public GetBookByRangeRequestBody() {
        }
        
        public GetBookByRangeRequestBody(int startRange, int endRange) {
            this.startRange = startRange;
            this.endRange = endRange;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBookByRangeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBookByRangeResponse", Namespace="http://tempuri.org/", Order=0)]
        public Soap_Client.WS.GetBookByRangeResponseBody Body;
        
        public GetBookByRangeResponse() {
        }
        
        public GetBookByRangeResponse(Soap_Client.WS.GetBookByRangeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetBookByRangeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Soap_Client.WS.Book[] GetBookByRangeResult;
        
        public GetBookByRangeResponseBody() {
        }
        
        public GetBookByRangeResponseBody(Soap_Client.WS.Book[] GetBookByRangeResult) {
            this.GetBookByRangeResult = GetBookByRangeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSSoapChannel : Soap_Client.WS.WSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSSoapClient : System.ServiceModel.ClientBase<Soap_Client.WS.WSSoap>, Soap_Client.WS.WSSoap {
        
        public WSSoapClient() {
        }
        
        public WSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Soap_Client.WS.FirstResponse Soap_Client.WS.WSSoap.First(Soap_Client.WS.FirstRequest request) {
            return base.Channel.First(request);
        }
        
        public Soap_Client.WS.Book First(int id) {
            Soap_Client.WS.FirstRequest inValue = new Soap_Client.WS.FirstRequest();
            inValue.Body = new Soap_Client.WS.FirstRequestBody();
            inValue.Body.id = id;
            Soap_Client.WS.FirstResponse retVal = ((Soap_Client.WS.WSSoap)(this)).First(inValue);
            return retVal.Body.FirstResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Soap_Client.WS.FirstResponse> Soap_Client.WS.WSSoap.FirstAsync(Soap_Client.WS.FirstRequest request) {
            return base.Channel.FirstAsync(request);
        }
        
        public System.Threading.Tasks.Task<Soap_Client.WS.FirstResponse> FirstAsync(int id) {
            Soap_Client.WS.FirstRequest inValue = new Soap_Client.WS.FirstRequest();
            inValue.Body = new Soap_Client.WS.FirstRequestBody();
            inValue.Body.id = id;
            return ((Soap_Client.WS.WSSoap)(this)).FirstAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Soap_Client.WS.SecondResponse Soap_Client.WS.WSSoap.Second(Soap_Client.WS.SecondRequest request) {
            return base.Channel.Second(request);
        }
        
        public Soap_Client.WS.Book[] Second() {
            Soap_Client.WS.SecondRequest inValue = new Soap_Client.WS.SecondRequest();
            inValue.Body = new Soap_Client.WS.SecondRequestBody();
            Soap_Client.WS.SecondResponse retVal = ((Soap_Client.WS.WSSoap)(this)).Second(inValue);
            return retVal.Body.SecondResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Soap_Client.WS.SecondResponse> Soap_Client.WS.WSSoap.SecondAsync(Soap_Client.WS.SecondRequest request) {
            return base.Channel.SecondAsync(request);
        }
        
        public System.Threading.Tasks.Task<Soap_Client.WS.SecondResponse> SecondAsync() {
            Soap_Client.WS.SecondRequest inValue = new Soap_Client.WS.SecondRequest();
            inValue.Body = new Soap_Client.WS.SecondRequestBody();
            return ((Soap_Client.WS.WSSoap)(this)).SecondAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Soap_Client.WS.GetAllResponse Soap_Client.WS.WSSoap.GetAll(Soap_Client.WS.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public Soap_Client.WS.Book[] GetAll() {
            Soap_Client.WS.GetAllRequest inValue = new Soap_Client.WS.GetAllRequest();
            inValue.Body = new Soap_Client.WS.GetAllRequestBody();
            Soap_Client.WS.GetAllResponse retVal = ((Soap_Client.WS.WSSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Soap_Client.WS.GetAllResponse> Soap_Client.WS.WSSoap.GetAllAsync(Soap_Client.WS.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<Soap_Client.WS.GetAllResponse> GetAllAsync() {
            Soap_Client.WS.GetAllRequest inValue = new Soap_Client.WS.GetAllRequest();
            inValue.Body = new Soap_Client.WS.GetAllRequestBody();
            return ((Soap_Client.WS.WSSoap)(this)).GetAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Soap_Client.WS.GetBookByRangeResponse Soap_Client.WS.WSSoap.GetBookByRange(Soap_Client.WS.GetBookByRangeRequest request) {
            return base.Channel.GetBookByRange(request);
        }
        
        public Soap_Client.WS.Book[] GetBookByRange(int startRange, int endRange) {
            Soap_Client.WS.GetBookByRangeRequest inValue = new Soap_Client.WS.GetBookByRangeRequest();
            inValue.Body = new Soap_Client.WS.GetBookByRangeRequestBody();
            inValue.Body.startRange = startRange;
            inValue.Body.endRange = endRange;
            Soap_Client.WS.GetBookByRangeResponse retVal = ((Soap_Client.WS.WSSoap)(this)).GetBookByRange(inValue);
            return retVal.Body.GetBookByRangeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Soap_Client.WS.GetBookByRangeResponse> Soap_Client.WS.WSSoap.GetBookByRangeAsync(Soap_Client.WS.GetBookByRangeRequest request) {
            return base.Channel.GetBookByRangeAsync(request);
        }
        
        public System.Threading.Tasks.Task<Soap_Client.WS.GetBookByRangeResponse> GetBookByRangeAsync(int startRange, int endRange) {
            Soap_Client.WS.GetBookByRangeRequest inValue = new Soap_Client.WS.GetBookByRangeRequest();
            inValue.Body = new Soap_Client.WS.GetBookByRangeRequestBody();
            inValue.Body.startRange = startRange;
            inValue.Body.endRange = endRange;
            return ((Soap_Client.WS.WSSoap)(this)).GetBookByRangeAsync(inValue);
        }
    }
}

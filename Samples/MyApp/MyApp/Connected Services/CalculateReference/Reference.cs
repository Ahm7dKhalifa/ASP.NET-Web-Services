﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyApp.CalculateReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculateReference.CalculateSoap")]
    public interface CalculateSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        MyApp.CalculateReference.HelloWorldResponse HelloWorld(MyApp.CalculateReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<MyApp.CalculateReference.HelloWorldResponse> HelloWorldAsync(MyApp.CalculateReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddXML", ReplyAction="*")]
        int AddXML();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddXML", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddXMLAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddXMLWithParameters", ReplyAction="*")]
        int AddXMLWithParameters(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddXMLWithParameters", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddXMLWithParametersAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddXMLWithParameters2", ReplyAction="*")]
        int AddXMLWithParameters2(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddXMLWithParameters2", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddXMLWithParameters2Async(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddWithJSON", ReplyAction="*")]
        int AddWithJSON();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddWithJSON", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddWithJSONAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddWithJSONWithParameters", ReplyAction="*")]
        int AddWithJSONWithParameters(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddWithJSONWithParameters", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddWithJSONWithParametersAsync(int x, int y);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public MyApp.CalculateReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(MyApp.CalculateReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyApp.CalculateReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(MyApp.CalculateReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculateSoapChannel : MyApp.CalculateReference.CalculateSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculateSoapClient : System.ServiceModel.ClientBase<MyApp.CalculateReference.CalculateSoap>, MyApp.CalculateReference.CalculateSoap {
        
        public CalculateSoapClient() {
        }
        
        public CalculateSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculateSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculateSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculateSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyApp.CalculateReference.HelloWorldResponse MyApp.CalculateReference.CalculateSoap.HelloWorld(MyApp.CalculateReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            MyApp.CalculateReference.HelloWorldRequest inValue = new MyApp.CalculateReference.HelloWorldRequest();
            inValue.Body = new MyApp.CalculateReference.HelloWorldRequestBody();
            MyApp.CalculateReference.HelloWorldResponse retVal = ((MyApp.CalculateReference.CalculateSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyApp.CalculateReference.HelloWorldResponse> MyApp.CalculateReference.CalculateSoap.HelloWorldAsync(MyApp.CalculateReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyApp.CalculateReference.HelloWorldResponse> HelloWorldAsync() {
            MyApp.CalculateReference.HelloWorldRequest inValue = new MyApp.CalculateReference.HelloWorldRequest();
            inValue.Body = new MyApp.CalculateReference.HelloWorldRequestBody();
            return ((MyApp.CalculateReference.CalculateSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int Add() {
            return base.Channel.Add();
        }
        
        public System.Threading.Tasks.Task<int> AddAsync() {
            return base.Channel.AddAsync();
        }
        
        public int AddXML() {
            return base.Channel.AddXML();
        }
        
        public System.Threading.Tasks.Task<int> AddXMLAsync() {
            return base.Channel.AddXMLAsync();
        }
        
        public int AddXMLWithParameters(int x, int y) {
            return base.Channel.AddXMLWithParameters(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddXMLWithParametersAsync(int x, int y) {
            return base.Channel.AddXMLWithParametersAsync(x, y);
        }
        
        public int AddXMLWithParameters2(int x, int y) {
            return base.Channel.AddXMLWithParameters2(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddXMLWithParameters2Async(int x, int y) {
            return base.Channel.AddXMLWithParameters2Async(x, y);
        }
        
        public int AddWithJSON() {
            return base.Channel.AddWithJSON();
        }
        
        public System.Threading.Tasks.Task<int> AddWithJSONAsync() {
            return base.Channel.AddWithJSONAsync();
        }
        
        public int AddWithJSONWithParameters(int x, int y) {
            return base.Channel.AddWithJSONWithParameters(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddWithJSONWithParametersAsync(int x, int y) {
            return base.Channel.AddWithJSONWithParametersAsync(x, y);
        }
    }
}

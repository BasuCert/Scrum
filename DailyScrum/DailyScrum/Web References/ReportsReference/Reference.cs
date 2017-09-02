﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace DailyScrum.ReportsReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IReports", Namespace="http://tempuri.org/")]
    public partial class Reports : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetOperationCompleted;
        
        private System.Threading.SendOrPostCallback SubmitOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Reports() {
            this.Url = "http://192.168.42.35/Reports.svc";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetCompletedEventHandler GetCompleted;
        
        /// <remarks/>
        public event SubmitCompletedEventHandler SubmitCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IReports/Get", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/DailyScrumWebService.ModelViews")]
        public ViewReport[] Get([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Username, int count, [System.Xml.Serialization.XmlIgnoreAttribute()] bool countSpecified, int skip, [System.Xml.Serialization.XmlIgnoreAttribute()] bool skipSpecified) {
            object[] results = this.Invoke("Get", new object[] {
                        Username,
                        count,
                        countSpecified,
                        skip,
                        skipSpecified});
            return ((ViewReport[])(results[0]));
        }
        
        /// <remarks/>
        public void GetAsync(string Username, int count, bool countSpecified, int skip, bool skipSpecified) {
            this.GetAsync(Username, count, countSpecified, skip, skipSpecified, null);
        }
        
        /// <remarks/>
        public void GetAsync(string Username, int count, bool countSpecified, int skip, bool skipSpecified, object userState) {
            if ((this.GetOperationCompleted == null)) {
                this.GetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOperationCompleted);
            }
            this.InvokeAsync("Get", new object[] {
                        Username,
                        count,
                        countSpecified,
                        skip,
                        skipSpecified}, this.GetOperationCompleted, userState);
        }
        
        private void OnGetOperationCompleted(object arg) {
            if ((this.GetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCompleted(this, new GetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IReports/Submit", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Submit([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Title, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Description, [System.Xml.Serialization.XmlElementAttribute("Submit")] System.DateTime Submit1, [System.Xml.Serialization.XmlElementAttribute("Submit")] [System.Xml.Serialization.XmlIgnoreAttribute()] bool Submit1Specified, int ProjectId, [System.Xml.Serialization.XmlIgnoreAttribute()] bool ProjectIdSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Username) {
            this.Invoke("Submit", new object[] {
                        Title,
                        Description,
                        Submit1,
                        Submit1Specified,
                        ProjectId,
                        ProjectIdSpecified,
                        Username});
        }
        
        /// <remarks/>
        public void SubmitAsync(string Title, string Description, System.DateTime Submit1, bool Submit1Specified, int ProjectId, bool ProjectIdSpecified, string Username) {
            this.SubmitAsync(Title, Description, Submit1, Submit1Specified, ProjectId, ProjectIdSpecified, Username, null);
        }
        
        /// <remarks/>
        public void SubmitAsync(string Title, string Description, System.DateTime Submit1, bool Submit1Specified, int ProjectId, bool ProjectIdSpecified, string Username, object userState) {
            if ((this.SubmitOperationCompleted == null)) {
                this.SubmitOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitOperationCompleted);
            }
            this.InvokeAsync("Submit", new object[] {
                        Title,
                        Description,
                        Submit1,
                        Submit1Specified,
                        ProjectId,
                        ProjectIdSpecified,
                        Username}, this.SubmitOperationCompleted, userState);
        }
        
        private void OnSubmitOperationCompleted(object arg) {
            if ((this.SubmitCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/DailyScrumWebService.ModelViews")]
    public partial class ViewReport {
        
        private string descriptionField;
        
        private long idField;
        
        private bool idFieldSpecified;
        
        private int projectIdField;
        
        private bool projectIdFieldSpecified;
        
        private System.DateTime submitField;
        
        private bool submitFieldSpecified;
        
        private string titleField;
        
        private string usernameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public long Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int ProjectId {
            get {
                return this.projectIdField;
            }
            set {
                this.projectIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProjectIdSpecified {
            get {
                return this.projectIdFieldSpecified;
            }
            set {
                this.projectIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Submit {
            get {
                return this.submitField;
            }
            set {
                this.submitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubmitSpecified {
            get {
                return this.submitFieldSpecified;
            }
            set {
                this.submitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetCompletedEventHandler(object sender, GetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ViewReport[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ViewReport[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void SubmitCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591
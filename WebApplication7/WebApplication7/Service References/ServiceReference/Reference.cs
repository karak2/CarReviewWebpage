﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication7.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserReview", Namespace="http://schemas.datacontract.org/2004/07/CarsBigDataService")]
    [System.SerializableAttribute()]
    public partial class UserReview : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> AverageConsumptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ComfortField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DrivenKmsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GarageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IpAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KmsWhenBoughtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PerformanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RelyabilityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RunningCostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalImpressionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double VerdictField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> YearOfManufacturingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearOfPurchaseField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> AverageConsumption {
            get {
                return this.AverageConsumptionField;
            }
            set {
                if ((this.AverageConsumptionField.Equals(value) != true)) {
                    this.AverageConsumptionField = value;
                    this.RaisePropertyChanged("AverageConsumption");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Comfort {
            get {
                return this.ComfortField;
            }
            set {
                if ((this.ComfortField.Equals(value) != true)) {
                    this.ComfortField = value;
                    this.RaisePropertyChanged("Comfort");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DrivenKms {
            get {
                return this.DrivenKmsField;
            }
            set {
                if ((this.DrivenKmsField.Equals(value) != true)) {
                    this.DrivenKmsField = value;
                    this.RaisePropertyChanged("DrivenKms");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Garage {
            get {
                return this.GarageField;
            }
            set {
                if ((this.GarageField.Equals(value) != true)) {
                    this.GarageField = value;
                    this.RaisePropertyChanged("Garage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IpAddress {
            get {
                return this.IpAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.IpAddressField, value) != true)) {
                    this.IpAddressField = value;
                    this.RaisePropertyChanged("IpAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int KmsWhenBought {
            get {
                return this.KmsWhenBoughtField;
            }
            set {
                if ((this.KmsWhenBoughtField.Equals(value) != true)) {
                    this.KmsWhenBoughtField = value;
                    this.RaisePropertyChanged("KmsWhenBought");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Performance {
            get {
                return this.PerformanceField;
            }
            set {
                if ((this.PerformanceField.Equals(value) != true)) {
                    this.PerformanceField = value;
                    this.RaisePropertyChanged("Performance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Relyability {
            get {
                return this.RelyabilityField;
            }
            set {
                if ((this.RelyabilityField.Equals(value) != true)) {
                    this.RelyabilityField = value;
                    this.RaisePropertyChanged("Relyability");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RunningCost {
            get {
                return this.RunningCostField;
            }
            set {
                if ((this.RunningCostField.Equals(value) != true)) {
                    this.RunningCostField = value;
                    this.RaisePropertyChanged("RunningCost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalImpression {
            get {
                return this.TotalImpressionField;
            }
            set {
                if ((this.TotalImpressionField.Equals(value) != true)) {
                    this.TotalImpressionField = value;
                    this.RaisePropertyChanged("TotalImpression");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Verdict {
            get {
                return this.VerdictField;
            }
            set {
                if ((this.VerdictField.Equals(value) != true)) {
                    this.VerdictField = value;
                    this.RaisePropertyChanged("Verdict");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> YearOfManufacturing {
            get {
                return this.YearOfManufacturingField;
            }
            set {
                if ((this.YearOfManufacturingField.Equals(value) != true)) {
                    this.YearOfManufacturingField = value;
                    this.RaisePropertyChanged("YearOfManufacturing");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int YearOfPurchase {
            get {
                return this.YearOfPurchaseField;
            }
            set {
                if ((this.YearOfPurchaseField.Equals(value) != true)) {
                    this.YearOfPurchaseField = value;
                    this.RaisePropertyChanged("YearOfPurchase");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserReviewSaveResult", Namespace="http://schemas.datacontract.org/2004/07/CarsBigDataService")]
    [System.SerializableAttribute()]
    public partial class UserReviewSaveResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IUserReviewSaveService")]
    public interface IUserReviewSaveService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserReviewSaveService/SaveReview", ReplyAction="http://tempuri.org/IUserReviewSaveService/SaveReviewResponse")]
        WebApplication7.ServiceReference.UserReviewSaveResult SaveReview(WebApplication7.ServiceReference.UserReview review);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserReviewSaveService/SaveReview", ReplyAction="http://tempuri.org/IUserReviewSaveService/SaveReviewResponse")]
        System.Threading.Tasks.Task<WebApplication7.ServiceReference.UserReviewSaveResult> SaveReviewAsync(WebApplication7.ServiceReference.UserReview review);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserReviewSaveServiceChannel : WebApplication7.ServiceReference.IUserReviewSaveService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserReviewSaveServiceClient : System.ServiceModel.ClientBase<WebApplication7.ServiceReference.IUserReviewSaveService>, WebApplication7.ServiceReference.IUserReviewSaveService {
        
        public UserReviewSaveServiceClient() {
        }
        
        public UserReviewSaveServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserReviewSaveServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserReviewSaveServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserReviewSaveServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplication7.ServiceReference.UserReviewSaveResult SaveReview(WebApplication7.ServiceReference.UserReview review) {
            return base.Channel.SaveReview(review);
        }
        
        public System.Threading.Tasks.Task<WebApplication7.ServiceReference.UserReviewSaveResult> SaveReviewAsync(WebApplication7.ServiceReference.UserReview review) {
            return base.Channel.SaveReviewAsync(review);
        }
    }
}

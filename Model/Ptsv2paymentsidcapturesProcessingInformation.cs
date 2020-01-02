/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Ptsv2paymentsidcapturesProcessingInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidcapturesProcessingInformation :  IEquatable<Ptsv2paymentsidcapturesProcessingInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidcapturesProcessingInformation" /> class.
        /// </summary>
        /// <param name="PaymentSolution">Type of digital payment solution for the transaction. Possible Values:   - &#x60;visacheckout&#x60;: Visa Checkout. This value is required for Visa Checkout transactions. For details, see &#x60;payment_solution&#x60; field description in [Visa Checkout Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/VCO_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  - &#x60;001&#x60;: Apple Pay.  - &#x60;004&#x60;: Cybersource In-App Solution.  - &#x60;005&#x60;: Masterpass. This value is required for Masterpass transactions on OmniPay Direct. For details, see \&quot;Masterpass\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  - &#x60;006&#x60;: Android Pay.  - &#x60;007&#x60;: Chase Pay.  - &#x60;008&#x60;: Samsung Pay.  - &#x60;012&#x60;: Google Pay. .</param>
        /// <param name="ReconciliationId">Please check with Cybersource customer support to see if your merchant account is configured correctly so you can include this field in your request. * For Payouts: max length for FDCCompass is String (22). .</param>
        /// <param name="LinkId">Value that links the current authorization request to the original authorization request. Set this value to the ID that was returned in the reply message from the original authorization request.  This value is used for:  - Partial authorizations - Split shipments  For details, see &#x60;link_to_request&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) .</param>
        /// <param name="ReportGroup">Attribute that lets you define custom grouping for your processor reports. This field is supported only for **Worldpay VAP**.  For details, see &#x60;report_group&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) .</param>
        /// <param name="VisaCheckoutId">Identifier for the **Visa Checkout** order. Visa Checkout provides a unique order ID for every transaction in the Visa Checkout **callID** field.  For details, see the &#x60;vc_order_id&#x60; field description in [Visa Checkout Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/VCO_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) .</param>
        /// <param name="PurchaseLevel">Set this field to 3 to indicate that the request includes Level III data..</param>
        /// <param name="IndustryDataType">Flag that indicates whether the transaction includes airline or restaurant data.  To send the data in a transaction request to the processor, you must set this field to &#x60;airline&#x60; or &#x60;restaurant&#x60;.  **Note** If you do not set this field to one of the possible values, CyberSource does not send any data to the processor.  Possible Values: - &#x60;airline&#x60; - &#x60;restaurant&#x60; .</param>
        /// <param name="Issuer">Issuer.</param>
        /// <param name="AuthorizationOptions">AuthorizationOptions.</param>
        /// <param name="CaptureOptions">CaptureOptions.</param>
        public Ptsv2paymentsidcapturesProcessingInformation(string PaymentSolution = default(string), string ReconciliationId = default(string), string LinkId = default(string), string ReportGroup = default(string), string VisaCheckoutId = default(string), string PurchaseLevel = default(string), string IndustryDataType = default(string), Ptsv2paymentsIssuerInformation Issuer = default(Ptsv2paymentsIssuerInformation), Ptsv2paymentsidcapturesProcessingInformationAuthorizationOptions AuthorizationOptions = default(Ptsv2paymentsidcapturesProcessingInformationAuthorizationOptions), Ptsv2paymentsidcapturesProcessingInformationCaptureOptions CaptureOptions = default(Ptsv2paymentsidcapturesProcessingInformationCaptureOptions))
        {
            this.PaymentSolution = PaymentSolution;
            this.ReconciliationId = ReconciliationId;
            this.LinkId = LinkId;
            this.ReportGroup = ReportGroup;
            this.VisaCheckoutId = VisaCheckoutId;
            this.PurchaseLevel = PurchaseLevel;
            this.IndustryDataType = IndustryDataType;
            this.Issuer = Issuer;
            this.AuthorizationOptions = AuthorizationOptions;
            this.CaptureOptions = CaptureOptions;
        }
        
        /// <summary>
        /// Type of digital payment solution for the transaction. Possible Values:   - &#x60;visacheckout&#x60;: Visa Checkout. This value is required for Visa Checkout transactions. For details, see &#x60;payment_solution&#x60; field description in [Visa Checkout Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/VCO_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  - &#x60;001&#x60;: Apple Pay.  - &#x60;004&#x60;: Cybersource In-App Solution.  - &#x60;005&#x60;: Masterpass. This value is required for Masterpass transactions on OmniPay Direct. For details, see \&quot;Masterpass\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  - &#x60;006&#x60;: Android Pay.  - &#x60;007&#x60;: Chase Pay.  - &#x60;008&#x60;: Samsung Pay.  - &#x60;012&#x60;: Google Pay. 
        /// </summary>
        /// <value>Type of digital payment solution for the transaction. Possible Values:   - &#x60;visacheckout&#x60;: Visa Checkout. This value is required for Visa Checkout transactions. For details, see &#x60;payment_solution&#x60; field description in [Visa Checkout Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/VCO_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  - &#x60;001&#x60;: Apple Pay.  - &#x60;004&#x60;: Cybersource In-App Solution.  - &#x60;005&#x60;: Masterpass. This value is required for Masterpass transactions on OmniPay Direct. For details, see \&quot;Masterpass\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  - &#x60;006&#x60;: Android Pay.  - &#x60;007&#x60;: Chase Pay.  - &#x60;008&#x60;: Samsung Pay.  - &#x60;012&#x60;: Google Pay. </value>
        [DataMember(Name="paymentSolution", EmitDefaultValue=false)]
        public string PaymentSolution { get; set; }

        /// <summary>
        /// Please check with Cybersource customer support to see if your merchant account is configured correctly so you can include this field in your request. * For Payouts: max length for FDCCompass is String (22). 
        /// </summary>
        /// <value>Please check with Cybersource customer support to see if your merchant account is configured correctly so you can include this field in your request. * For Payouts: max length for FDCCompass is String (22). </value>
        [DataMember(Name="reconciliationId", EmitDefaultValue=false)]
        public string ReconciliationId { get; set; }

        /// <summary>
        /// Value that links the current authorization request to the original authorization request. Set this value to the ID that was returned in the reply message from the original authorization request.  This value is used for:  - Partial authorizations - Split shipments  For details, see &#x60;link_to_request&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) 
        /// </summary>
        /// <value>Value that links the current authorization request to the original authorization request. Set this value to the ID that was returned in the reply message from the original authorization request.  This value is used for:  - Partial authorizations - Split shipments  For details, see &#x60;link_to_request&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) </value>
        [DataMember(Name="linkId", EmitDefaultValue=false)]
        public string LinkId { get; set; }

        /// <summary>
        /// Attribute that lets you define custom grouping for your processor reports. This field is supported only for **Worldpay VAP**.  For details, see &#x60;report_group&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) 
        /// </summary>
        /// <value>Attribute that lets you define custom grouping for your processor reports. This field is supported only for **Worldpay VAP**.  For details, see &#x60;report_group&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) </value>
        [DataMember(Name="reportGroup", EmitDefaultValue=false)]
        public string ReportGroup { get; set; }

        /// <summary>
        /// Identifier for the **Visa Checkout** order. Visa Checkout provides a unique order ID for every transaction in the Visa Checkout **callID** field.  For details, see the &#x60;vc_order_id&#x60; field description in [Visa Checkout Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/VCO_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) 
        /// </summary>
        /// <value>Identifier for the **Visa Checkout** order. Visa Checkout provides a unique order ID for every transaction in the Visa Checkout **callID** field.  For details, see the &#x60;vc_order_id&#x60; field description in [Visa Checkout Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/VCO_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) </value>
        [DataMember(Name="visaCheckoutId", EmitDefaultValue=false)]
        public string VisaCheckoutId { get; set; }

        /// <summary>
        /// Set this field to 3 to indicate that the request includes Level III data.
        /// </summary>
        /// <value>Set this field to 3 to indicate that the request includes Level III data.</value>
        [DataMember(Name="purchaseLevel", EmitDefaultValue=false)]
        public string PurchaseLevel { get; set; }

        /// <summary>
        /// Flag that indicates whether the transaction includes airline or restaurant data.  To send the data in a transaction request to the processor, you must set this field to &#x60;airline&#x60; or &#x60;restaurant&#x60;.  **Note** If you do not set this field to one of the possible values, CyberSource does not send any data to the processor.  Possible Values: - &#x60;airline&#x60; - &#x60;restaurant&#x60; 
        /// </summary>
        /// <value>Flag that indicates whether the transaction includes airline or restaurant data.  To send the data in a transaction request to the processor, you must set this field to &#x60;airline&#x60; or &#x60;restaurant&#x60;.  **Note** If you do not set this field to one of the possible values, CyberSource does not send any data to the processor.  Possible Values: - &#x60;airline&#x60; - &#x60;restaurant&#x60; </value>
        [DataMember(Name="industryDataType", EmitDefaultValue=false)]
        public string IndustryDataType { get; set; }

        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [DataMember(Name="issuer", EmitDefaultValue=false)]
        public Ptsv2paymentsIssuerInformation Issuer { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizationOptions
        /// </summary>
        [DataMember(Name="authorizationOptions", EmitDefaultValue=false)]
        public Ptsv2paymentsidcapturesProcessingInformationAuthorizationOptions AuthorizationOptions { get; set; }

        /// <summary>
        /// Gets or Sets CaptureOptions
        /// </summary>
        [DataMember(Name="captureOptions", EmitDefaultValue=false)]
        public Ptsv2paymentsidcapturesProcessingInformationCaptureOptions CaptureOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidcapturesProcessingInformation {\n");
            sb.Append("  PaymentSolution: ").Append(PaymentSolution).Append("\n");
            sb.Append("  ReconciliationId: ").Append(ReconciliationId).Append("\n");
            sb.Append("  LinkId: ").Append(LinkId).Append("\n");
            sb.Append("  ReportGroup: ").Append(ReportGroup).Append("\n");
            sb.Append("  VisaCheckoutId: ").Append(VisaCheckoutId).Append("\n");
            sb.Append("  PurchaseLevel: ").Append(PurchaseLevel).Append("\n");
            sb.Append("  IndustryDataType: ").Append(IndustryDataType).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  AuthorizationOptions: ").Append(AuthorizationOptions).Append("\n");
            sb.Append("  CaptureOptions: ").Append(CaptureOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Ptsv2paymentsidcapturesProcessingInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidcapturesProcessingInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidcapturesProcessingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidcapturesProcessingInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PaymentSolution == other.PaymentSolution ||
                    this.PaymentSolution != null &&
                    this.PaymentSolution.Equals(other.PaymentSolution)
                ) && 
                (
                    this.ReconciliationId == other.ReconciliationId ||
                    this.ReconciliationId != null &&
                    this.ReconciliationId.Equals(other.ReconciliationId)
                ) && 
                (
                    this.LinkId == other.LinkId ||
                    this.LinkId != null &&
                    this.LinkId.Equals(other.LinkId)
                ) && 
                (
                    this.ReportGroup == other.ReportGroup ||
                    this.ReportGroup != null &&
                    this.ReportGroup.Equals(other.ReportGroup)
                ) && 
                (
                    this.VisaCheckoutId == other.VisaCheckoutId ||
                    this.VisaCheckoutId != null &&
                    this.VisaCheckoutId.Equals(other.VisaCheckoutId)
                ) && 
                (
                    this.PurchaseLevel == other.PurchaseLevel ||
                    this.PurchaseLevel != null &&
                    this.PurchaseLevel.Equals(other.PurchaseLevel)
                ) && 
                (
                    this.IndustryDataType == other.IndustryDataType ||
                    this.IndustryDataType != null &&
                    this.IndustryDataType.Equals(other.IndustryDataType)
                ) && 
                (
                    this.Issuer == other.Issuer ||
                    this.Issuer != null &&
                    this.Issuer.Equals(other.Issuer)
                ) && 
                (
                    this.AuthorizationOptions == other.AuthorizationOptions ||
                    this.AuthorizationOptions != null &&
                    this.AuthorizationOptions.Equals(other.AuthorizationOptions)
                ) && 
                (
                    this.CaptureOptions == other.CaptureOptions ||
                    this.CaptureOptions != null &&
                    this.CaptureOptions.Equals(other.CaptureOptions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.PaymentSolution != null)
                    hash = hash * 59 + this.PaymentSolution.GetHashCode();
                if (this.ReconciliationId != null)
                    hash = hash * 59 + this.ReconciliationId.GetHashCode();
                if (this.LinkId != null)
                    hash = hash * 59 + this.LinkId.GetHashCode();
                if (this.ReportGroup != null)
                    hash = hash * 59 + this.ReportGroup.GetHashCode();
                if (this.VisaCheckoutId != null)
                    hash = hash * 59 + this.VisaCheckoutId.GetHashCode();
                if (this.PurchaseLevel != null)
                    hash = hash * 59 + this.PurchaseLevel.GetHashCode();
                if (this.IndustryDataType != null)
                    hash = hash * 59 + this.IndustryDataType.GetHashCode();
                if (this.Issuer != null)
                    hash = hash * 59 + this.Issuer.GetHashCode();
                if (this.AuthorizationOptions != null)
                    hash = hash * 59 + this.AuthorizationOptions.GetHashCode();
                if (this.CaptureOptions != null)
                    hash = hash * 59 + this.CaptureOptions.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PaymentSolution (string) maxLength
            if(this.PaymentSolution != null && this.PaymentSolution.Length >= 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentSolution, length must be less than or equal to 12.", new [] { "PaymentSolution" });
            }

            // ReconciliationId (string) maxLength
            if(this.ReconciliationId != null && this.ReconciliationId.Length >= 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReconciliationId, length must be less than or equal to 60.", new [] { "ReconciliationId" });
            }

            // LinkId (string) maxLength
            if(this.LinkId != null && this.LinkId.Length >= 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LinkId, length must be less than or equal to 26.", new [] { "LinkId" });
            }

            // ReportGroup (string) maxLength
            if(this.ReportGroup != null && this.ReportGroup.Length >= 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportGroup, length must be less than or equal to 25.", new [] { "ReportGroup" });
            }

            // VisaCheckoutId (string) maxLength
            if(this.VisaCheckoutId != null && this.VisaCheckoutId.Length >= 48)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisaCheckoutId, length must be less than or equal to 48.", new [] { "VisaCheckoutId" });
            }

            // PurchaseLevel (string) maxLength
            if(this.PurchaseLevel != null && this.PurchaseLevel.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PurchaseLevel, length must be less than or equal to 1.", new [] { "PurchaseLevel" });
            }

            // IndustryDataType (string) maxLength
            if(this.IndustryDataType != null && this.IndustryDataType.Length >= 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IndustryDataType, length must be less than or equal to 10.", new [] { "IndustryDataType" });
            }

            yield break;
        }
    }

}

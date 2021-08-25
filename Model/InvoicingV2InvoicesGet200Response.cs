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
    /// InvoicingV2InvoicesGet200Response
    /// </summary>
    [DataContract]
    public partial class InvoicingV2InvoicesGet200Response :  IEquatable<InvoicingV2InvoicesGet200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicingV2InvoicesGet200Response" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="Id">An unique identification number generated by Cybersource to identify the submitted request. Returned by all services. It is also appended to the endpoint of the resource. On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. .</param>
        /// <param name="SubmitTimeUtc">Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services. .</param>
        /// <param name="Status">The status of the invoice.  Possible values: - DRAFT - CREATED - SENT - PARTIAL - PAID - CANCELED .</param>
        /// <param name="CustomerInformation">CustomerInformation.</param>
        /// <param name="InvoiceInformation">InvoiceInformation.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        /// <param name="InvoiceHistory">InvoiceHistory.</param>
        public InvoicingV2InvoicesGet200Response(InvoicingV2InvoicesAllGet200ResponseLinks1 Links = default(InvoicingV2InvoicesAllGet200ResponseLinks1), string Id = default(string), string SubmitTimeUtc = default(string), string Status = default(string), Invoicingv2invoicesCustomerInformation CustomerInformation = default(Invoicingv2invoicesCustomerInformation), InvoicingV2InvoicesPost201ResponseInvoiceInformation InvoiceInformation = default(InvoicingV2InvoicesPost201ResponseInvoiceInformation), InvoicingV2InvoicesPost201ResponseOrderInformation OrderInformation = default(InvoicingV2InvoicesPost201ResponseOrderInformation), List<InvoicingV2InvoicesGet200ResponseInvoiceHistory> InvoiceHistory = default(List<InvoicingV2InvoicesGet200ResponseInvoiceHistory>))
        {
            this.Links = Links;
            this.Id = Id;
            this.SubmitTimeUtc = SubmitTimeUtc;
            this.Status = Status;
            this.CustomerInformation = CustomerInformation;
            this.InvoiceInformation = InvoiceInformation;
            this.OrderInformation = OrderInformation;
            this.InvoiceHistory = InvoiceHistory;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public InvoicingV2InvoicesAllGet200ResponseLinks1 Links { get; set; }

        /// <summary>
        /// An unique identification number generated by Cybersource to identify the submitted request. Returned by all services. It is also appended to the endpoint of the resource. On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. 
        /// </summary>
        /// <value>An unique identification number generated by Cybersource to identify the submitted request. Returned by all services. It is also appended to the endpoint of the resource. On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services. 
        /// </summary>
        /// <value>Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services. </value>
        [DataMember(Name="submitTimeUtc", EmitDefaultValue=false)]
        public string SubmitTimeUtc { get; set; }

        /// <summary>
        /// The status of the invoice.  Possible values: - DRAFT - CREATED - SENT - PARTIAL - PAID - CANCELED 
        /// </summary>
        /// <value>The status of the invoice.  Possible values: - DRAFT - CREATED - SENT - PARTIAL - PAID - CANCELED </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets CustomerInformation
        /// </summary>
        [DataMember(Name="customerInformation", EmitDefaultValue=false)]
        public Invoicingv2invoicesCustomerInformation CustomerInformation { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceInformation
        /// </summary>
        [DataMember(Name="invoiceInformation", EmitDefaultValue=false)]
        public InvoicingV2InvoicesPost201ResponseInvoiceInformation InvoiceInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public InvoicingV2InvoicesPost201ResponseOrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceHistory
        /// </summary>
        [DataMember(Name="invoiceHistory", EmitDefaultValue=false)]
        public List<InvoicingV2InvoicesGet200ResponseInvoiceHistory> InvoiceHistory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoicingV2InvoicesGet200Response {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SubmitTimeUtc: ").Append(SubmitTimeUtc).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CustomerInformation: ").Append(CustomerInformation).Append("\n");
            sb.Append("  InvoiceInformation: ").Append(InvoiceInformation).Append("\n");
            sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
            sb.Append("  InvoiceHistory: ").Append(InvoiceHistory).Append("\n");
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
            return this.Equals(obj as InvoicingV2InvoicesGet200Response);
        }

        /// <summary>
        /// Returns true if InvoicingV2InvoicesGet200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of InvoicingV2InvoicesGet200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoicingV2InvoicesGet200Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.SubmitTimeUtc == other.SubmitTimeUtc ||
                    this.SubmitTimeUtc != null &&
                    this.SubmitTimeUtc.Equals(other.SubmitTimeUtc)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CustomerInformation == other.CustomerInformation ||
                    this.CustomerInformation != null &&
                    this.CustomerInformation.Equals(other.CustomerInformation)
                ) && 
                (
                    this.InvoiceInformation == other.InvoiceInformation ||
                    this.InvoiceInformation != null &&
                    this.InvoiceInformation.Equals(other.InvoiceInformation)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
                ) && 
                (
                    this.InvoiceHistory == other.InvoiceHistory ||
                    this.InvoiceHistory != null &&
                    this.InvoiceHistory.SequenceEqual(other.InvoiceHistory)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.SubmitTimeUtc != null)
                    hash = hash * 59 + this.SubmitTimeUtc.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.CustomerInformation != null)
                    hash = hash * 59 + this.CustomerInformation.GetHashCode();
                if (this.InvoiceInformation != null)
                    hash = hash * 59 + this.InvoiceInformation.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
                if (this.InvoiceHistory != null)
                    hash = hash * 59 + this.InvoiceHistory.GetHashCode();
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
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length >= 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than or equal to 26.", new [] { "Id" });
            }

            yield break;
        }
    }

}

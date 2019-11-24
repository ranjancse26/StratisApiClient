/* 
 * Stratis Node API
 *
 * Access to the Stratis Node's core features.
 *
 * OpenAPI spec version: 1
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// OutpointRequest
    /// </summary>
    [DataContract]
    public partial class OutpointRequest :  IEquatable<OutpointRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutpointRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutpointRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutpointRequest" /> class.
        /// </summary>
        /// <param name="transactionId">transactionId (required).</param>
        /// <param name="index">index (required).</param>
        public OutpointRequest(string transactionId = default(string), int? index = default(int?))
        {
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new InvalidDataException("transactionId is a required property for OutpointRequest and cannot be null");
            }
            else
            {
                this.TransactionId = transactionId;
            }
            // to ensure "index" is required (not null)
            if (index == null)
            {
                throw new InvalidDataException("index is a required property for OutpointRequest and cannot be null");
            }
            else
            {
                this.Index = index;
            }
        }
        
        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutpointRequest {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutpointRequest);
        }

        /// <summary>
        /// Returns true if OutpointRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OutpointRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutpointRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

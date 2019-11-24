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
    /// LogRuleRequest
    /// </summary>
    [DataContract]
    public partial class LogRuleRequest :  IEquatable<LogRuleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogRuleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LogRuleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogRuleRequest" /> class.
        /// </summary>
        /// <param name="ruleName">ruleName (required).</param>
        /// <param name="logLevel">logLevel (required).</param>
        public LogRuleRequest(string ruleName = default(string), string logLevel = default(string))
        {
            // to ensure "ruleName" is required (not null)
            if (ruleName == null)
            {
                throw new InvalidDataException("ruleName is a required property for LogRuleRequest and cannot be null");
            }
            else
            {
                this.RuleName = ruleName;
            }
            // to ensure "logLevel" is required (not null)
            if (logLevel == null)
            {
                throw new InvalidDataException("logLevel is a required property for LogRuleRequest and cannot be null");
            }
            else
            {
                this.LogLevel = logLevel;
            }
        }
        
        /// <summary>
        /// Gets or Sets RuleName
        /// </summary>
        [DataMember(Name="ruleName", EmitDefaultValue=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// Gets or Sets LogLevel
        /// </summary>
        [DataMember(Name="logLevel", EmitDefaultValue=false)]
        public string LogLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogRuleRequest {\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  LogLevel: ").Append(LogLevel).Append("\n");
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
            return this.Equals(input as LogRuleRequest);
        }

        /// <summary>
        /// Returns true if LogRuleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LogRuleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogRuleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RuleName == input.RuleName ||
                    (this.RuleName != null &&
                    this.RuleName.Equals(input.RuleName))
                ) && 
                (
                    this.LogLevel == input.LogLevel ||
                    (this.LogLevel != null &&
                    this.LogLevel.Equals(input.LogLevel))
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
                if (this.RuleName != null)
                    hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.LogLevel != null)
                    hashCode = hashCode * 59 + this.LogLevel.GetHashCode();
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

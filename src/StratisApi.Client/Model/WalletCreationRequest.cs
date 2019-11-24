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
    /// WalletCreationRequest
    /// </summary>
    [DataContract]
    public partial class WalletCreationRequest :  IEquatable<WalletCreationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletCreationRequest" /> class.
        /// </summary>
        /// <param name="mnemonic">mnemonic.</param>
        /// <param name="password">password (required).</param>
        /// <param name="passphrase">passphrase (required).</param>
        /// <param name="name">name (required).</param>
        public WalletCreationRequest(string mnemonic = default(string), string password = default(string), string passphrase = default(string), string name = default(string))
        {
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for WalletCreationRequest and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            // to ensure "passphrase" is required (not null)
            if (passphrase == null)
            {
                throw new InvalidDataException("passphrase is a required property for WalletCreationRequest and cannot be null");
            }
            else
            {
                this.Passphrase = passphrase;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for WalletCreationRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Mnemonic = mnemonic;
        }
        
        /// <summary>
        /// Gets or Sets Mnemonic
        /// </summary>
        [DataMember(Name="mnemonic", EmitDefaultValue=false)]
        public string Mnemonic { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Passphrase
        /// </summary>
        [DataMember(Name="passphrase", EmitDefaultValue=false)]
        public string Passphrase { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WalletCreationRequest {\n");
            sb.Append("  Mnemonic: ").Append(Mnemonic).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Passphrase: ").Append(Passphrase).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as WalletCreationRequest);
        }

        /// <summary>
        /// Returns true if WalletCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletCreationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mnemonic == input.Mnemonic ||
                    (this.Mnemonic != null &&
                    this.Mnemonic.Equals(input.Mnemonic))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Passphrase == input.Passphrase ||
                    (this.Passphrase != null &&
                    this.Passphrase.Equals(input.Passphrase))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Mnemonic != null)
                    hashCode = hashCode * 59 + this.Mnemonic.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Passphrase != null)
                    hashCode = hashCode * 59 + this.Passphrase.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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

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
    /// BuildCreateContractTransactionRequest
    /// </summary>
    [DataContract]
    public partial class BuildCreateContractTransactionRequest :  IEquatable<BuildCreateContractTransactionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildCreateContractTransactionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuildCreateContractTransactionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildCreateContractTransactionRequest" /> class.
        /// </summary>
        /// <param name="walletName">walletName (required).</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="outpoints">outpoints.</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="feeAmount">feeAmount.</param>
        /// <param name="password">password (required).</param>
        /// <param name="contractCode">contractCode (required).</param>
        /// <param name="gasPrice">gasPrice.</param>
        /// <param name="gasLimit">gasLimit.</param>
        /// <param name="sender">sender (required).</param>
        /// <param name="parameters">parameters.</param>
        public BuildCreateContractTransactionRequest(string walletName = default(string), string accountName = default(string), List<OutpointRequest> outpoints = default(List<OutpointRequest>), string amount = default(string), string feeAmount = default(string), string password = default(string), string contractCode = default(string), long? gasPrice = default(long?), long? gasLimit = default(long?), string sender = default(string), List<string> parameters = default(List<string>))
        {
            // to ensure "walletName" is required (not null)
            if (walletName == null)
            {
                throw new InvalidDataException("walletName is a required property for BuildCreateContractTransactionRequest and cannot be null");
            }
            else
            {
                this.WalletName = walletName;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for BuildCreateContractTransactionRequest and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for BuildCreateContractTransactionRequest and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            // to ensure "contractCode" is required (not null)
            if (contractCode == null)
            {
                throw new InvalidDataException("contractCode is a required property for BuildCreateContractTransactionRequest and cannot be null");
            }
            else
            {
                this.ContractCode = contractCode;
            }
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new InvalidDataException("sender is a required property for BuildCreateContractTransactionRequest and cannot be null");
            }
            else
            {
                this.Sender = sender;
            }
            this.AccountName = accountName;
            this.Outpoints = outpoints;
            this.FeeAmount = feeAmount;
            this.GasPrice = gasPrice;
            this.GasLimit = gasLimit;
            this.Parameters = parameters;
        }
        
        /// <summary>
        /// Gets or Sets WalletName
        /// </summary>
        [DataMember(Name="walletName", EmitDefaultValue=false)]
        public string WalletName { get; set; }

        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets Outpoints
        /// </summary>
        [DataMember(Name="outpoints", EmitDefaultValue=false)]
        public List<OutpointRequest> Outpoints { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets FeeAmount
        /// </summary>
        [DataMember(Name="feeAmount", EmitDefaultValue=false)]
        public string FeeAmount { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets ContractCode
        /// </summary>
        [DataMember(Name="contractCode", EmitDefaultValue=false)]
        public string ContractCode { get; set; }

        /// <summary>
        /// Gets or Sets GasPrice
        /// </summary>
        [DataMember(Name="gasPrice", EmitDefaultValue=false)]
        public long? GasPrice { get; set; }

        /// <summary>
        /// Gets or Sets GasLimit
        /// </summary>
        [DataMember(Name="gasLimit", EmitDefaultValue=false)]
        public long? GasLimit { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<string> Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildCreateContractTransactionRequest {\n");
            sb.Append("  WalletName: ").Append(WalletName).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Outpoints: ").Append(Outpoints).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  FeeAmount: ").Append(FeeAmount).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ContractCode: ").Append(ContractCode).Append("\n");
            sb.Append("  GasPrice: ").Append(GasPrice).Append("\n");
            sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(input as BuildCreateContractTransactionRequest);
        }

        /// <summary>
        /// Returns true if BuildCreateContractTransactionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildCreateContractTransactionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildCreateContractTransactionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WalletName == input.WalletName ||
                    (this.WalletName != null &&
                    this.WalletName.Equals(input.WalletName))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.Outpoints == input.Outpoints ||
                    this.Outpoints != null &&
                    this.Outpoints.SequenceEqual(input.Outpoints)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.FeeAmount == input.FeeAmount ||
                    (this.FeeAmount != null &&
                    this.FeeAmount.Equals(input.FeeAmount))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ContractCode == input.ContractCode ||
                    (this.ContractCode != null &&
                    this.ContractCode.Equals(input.ContractCode))
                ) && 
                (
                    this.GasPrice == input.GasPrice ||
                    (this.GasPrice != null &&
                    this.GasPrice.Equals(input.GasPrice))
                ) && 
                (
                    this.GasLimit == input.GasLimit ||
                    (this.GasLimit != null &&
                    this.GasLimit.Equals(input.GasLimit))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
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
                if (this.WalletName != null)
                    hashCode = hashCode * 59 + this.WalletName.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.Outpoints != null)
                    hashCode = hashCode * 59 + this.Outpoints.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.FeeAmount != null)
                    hashCode = hashCode * 59 + this.FeeAmount.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ContractCode != null)
                    hashCode = hashCode * 59 + this.ContractCode.GetHashCode();
                if (this.GasPrice != null)
                    hashCode = hashCode * 59 + this.GasPrice.GetHashCode();
                if (this.GasLimit != null)
                    hashCode = hashCode * 59 + this.GasLimit.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
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
            // GasPrice (long?) maximum
            if(this.GasPrice > (long?)10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GasPrice, must be a value less than or equal to 10000.", new [] { "GasPrice" });
            }

            // GasPrice (long?) minimum
            if(this.GasPrice < (long?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GasPrice, must be a value greater than or equal to 100.", new [] { "GasPrice" });
            }

            // GasLimit (long?) maximum
            if(this.GasLimit > (long?)100000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GasLimit, must be a value less than or equal to 100000.", new [] { "GasLimit" });
            }

            // GasLimit (long?) minimum
            if(this.GasLimit < (long?)12000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GasLimit, must be a value greater than or equal to 12000.", new [] { "GasLimit" });
            }

            yield break;
        }
    }

}
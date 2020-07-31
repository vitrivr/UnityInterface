/* 
 * Cineast RESTful API
 *
 * Cineast is vitrivr's content-based multimedia retrieval engine. This is it's RESTful API.
 *
 * The version of the OpenAPI document: v1
 * Contact: contact@vitrivr.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.Vitrivr.CineastApi.Client.OpenAPIDateConverter;

namespace Org.Vitrivr.CineastApi.Model
{
    /// <summary>
    /// AbstractMetadataFilterDescriptor
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(MetadataKeyFilter), "MetadataKeyFilter")]
    [JsonSubtypes.KnownSubType(typeof(MetadataDomainFilter), "MetadataDomainFilter")]
    public partial class AbstractMetadataFilterDescriptor :  IEquatable<AbstractMetadataFilterDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractMetadataFilterDescriptor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AbstractMetadataFilterDescriptor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractMetadataFilterDescriptor" /> class.
        /// </summary>
        /// <param name="keywords">keywords.</param>
        /// <param name="type">type (required).</param>
        public AbstractMetadataFilterDescriptor(List<string> keywords = default(List<string>), string type = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for AbstractMetadataFilterDescriptor and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            this.Keywords = keywords;
        }
        
        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractMetadataFilterDescriptor {\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AbstractMetadataFilterDescriptor);
        }

        /// <summary>
        /// Returns true if AbstractMetadataFilterDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractMetadataFilterDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractMetadataFilterDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
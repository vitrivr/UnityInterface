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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.Vitrivr.CineastApi.Client.OpenAPIDateConverter;

namespace Org.Vitrivr.CineastApi.Model
{
    /// <summary>
    /// MediaSegmentDescriptor
    /// </summary>
    [DataContract]
    public partial class MediaSegmentDescriptor :  IEquatable<MediaSegmentDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSegmentDescriptor" /> class.
        /// </summary>
        /// <param name="segmentId">segmentId.</param>
        /// <param name="objectId">objectId.</param>
        /// <param name="start">start.</param>
        /// <param name="end">end.</param>
        /// <param name="startabs">startabs.</param>
        /// <param name="endabs">endabs.</param>
        /// <param name="count">count.</param>
        /// <param name="sequenceNumber">sequenceNumber.</param>
        public MediaSegmentDescriptor(string segmentId = default(string), string objectId = default(string), int start = default(int), int end = default(int), float startabs = default(float), float endabs = default(float), int count = default(int), int sequenceNumber = default(int))
        {
            this.SegmentId = segmentId;
            this.ObjectId = objectId;
            this.Start = start;
            this.End = end;
            this.Startabs = startabs;
            this.Endabs = endabs;
            this.Count = count;
            this.SequenceNumber = sequenceNumber;
        }
        
        /// <summary>
        /// Gets or Sets SegmentId
        /// </summary>
        [DataMember(Name="segmentId", EmitDefaultValue=false)]
        public string SegmentId { get; set; }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public int Start { get; set; }

        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public int End { get; set; }

        /// <summary>
        /// Gets or Sets Startabs
        /// </summary>
        [DataMember(Name="startabs", EmitDefaultValue=false)]
        public float Startabs { get; set; }

        /// <summary>
        /// Gets or Sets Endabs
        /// </summary>
        [DataMember(Name="endabs", EmitDefaultValue=false)]
        public float Endabs { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets SequenceNumber
        /// </summary>
        [DataMember(Name="sequenceNumber", EmitDefaultValue=false)]
        public int SequenceNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaSegmentDescriptor {\n");
            sb.Append("  SegmentId: ").Append(SegmentId).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Startabs: ").Append(Startabs).Append("\n");
            sb.Append("  Endabs: ").Append(Endabs).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
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
            return this.Equals(input as MediaSegmentDescriptor);
        }

        /// <summary>
        /// Returns true if MediaSegmentDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaSegmentDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaSegmentDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SegmentId == input.SegmentId ||
                    (this.SegmentId != null &&
                    this.SegmentId.Equals(input.SegmentId))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.Startabs == input.Startabs ||
                    (this.Startabs != null &&
                    this.Startabs.Equals(input.Startabs))
                ) && 
                (
                    this.Endabs == input.Endabs ||
                    (this.Endabs != null &&
                    this.Endabs.Equals(input.Endabs))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.SequenceNumber == input.SequenceNumber ||
                    (this.SequenceNumber != null &&
                    this.SequenceNumber.Equals(input.SequenceNumber))
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
                if (this.SegmentId != null)
                    hashCode = hashCode * 59 + this.SegmentId.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.Startabs != null)
                    hashCode = hashCode * 59 + this.Startabs.GetHashCode();
                if (this.Endabs != null)
                    hashCode = hashCode * 59 + this.Endabs.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.SequenceNumber != null)
                    hashCode = hashCode * 59 + this.SequenceNumber.GetHashCode();
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


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
using SwaggerDateConverter = Intrinio.Client.SwaggerDateConverter;

namespace Intrinio.Model
{
    /// <summary>
    /// Metadata for the note retrieved including the Intrinio ID, tag and summary of the filing to which it belongs
    /// </summary>
    [DataContract]
    public partial class FilingNoteSummary :  IEquatable<FilingNoteSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilingNoteSummary" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID of the note.</param>
        /// <param name="XbrlTag">The XBRL tag used for the note by the filing entity.</param>
        /// <param name="Filing">Filing.</param>
        public FilingNoteSummary(string Id = default(string), string XbrlTag = default(string), FilingNoteFiling Filing = default(FilingNoteFiling))
        {
            this.Id = Id;
            this.XbrlTag = XbrlTag;
            this.Filing = Filing;
        }
        
        /// <summary>
        /// The Intrinio ID of the note
        /// </summary>
        /// <value>The Intrinio ID of the note</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The XBRL tag used for the note by the filing entity
        /// </summary>
        /// <value>The XBRL tag used for the note by the filing entity</value>
        [DataMember(Name="xbrl_tag", EmitDefaultValue=false)]
        public string XbrlTag { get; set; }

        /// <summary>
        /// Gets or Sets Filing
        /// </summary>
        [DataMember(Name="filing", EmitDefaultValue=false)]
        public FilingNoteFiling Filing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilingNoteSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  XbrlTag: ").Append(XbrlTag).Append("\n");
            sb.Append("  Filing: ").Append(Filing).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FilingNoteSummary);
        }

        /// <summary>
        /// Returns true if FilingNoteSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of FilingNoteSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilingNoteSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.XbrlTag == input.XbrlTag ||
                    (this.XbrlTag != null &&
                    this.XbrlTag.Equals(input.XbrlTag))
                ) && 
                (
                    this.Filing == input.Filing ||
                    (this.Filing != null &&
                    this.Filing.Equals(input.Filing))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.XbrlTag != null)
                    hashCode = hashCode * 59 + this.XbrlTag.GetHashCode();
                if (this.Filing != null)
                    hashCode = hashCode * 59 + this.Filing.GetHashCode();
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

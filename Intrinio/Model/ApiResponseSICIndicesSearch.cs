

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
    /// ApiResponseSICIndicesSearch
    /// </summary>
    [DataContract]
    public partial class ApiResponseSICIndicesSearch :  IEquatable<ApiResponseSICIndicesSearch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSICIndicesSearch" /> class.
        /// </summary>
        /// <param name="Indices">Indices.</param>
        public ApiResponseSICIndicesSearch(List<SICIndex> Indices = default(List<SICIndex>))
        {
            this.Indices = Indices;
        }
        
        /// <summary>
        /// Gets or Sets Indices
        /// </summary>
        [DataMember(Name="indices", EmitDefaultValue=false)]
        public List<SICIndex> Indices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseSICIndicesSearch {\n");
            sb.Append("  Indices: ").Append(Indices).Append("\n");
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
            return this.Equals(input as ApiResponseSICIndicesSearch);
        }

        /// <summary>
        /// Returns true if ApiResponseSICIndicesSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSICIndicesSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSICIndicesSearch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Indices == input.Indices ||
                    this.Indices != null &&
                    this.Indices.SequenceEqual(input.Indices)
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
                if (this.Indices != null)
                    hashCode = hashCode * 59 + this.Indices.GetHashCode();
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

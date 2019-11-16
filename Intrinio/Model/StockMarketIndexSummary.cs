

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
    /// StockMarketIndexSummary
    /// </summary>
    [DataContract]
    public partial class StockMarketIndexSummary :  IEquatable<StockMarketIndexSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockMarketIndexSummary" /> class.
        /// </summary>
        /// <param name="Id">Intrinio ID for the Index.</param>
        /// <param name="Symbol">The symbol used to identify the Index.</param>
        /// <param name="Name">The name of the Index.</param>
        /// <param name="Continent">The continent of the country of focus for the Index.</param>
        /// <param name="Country">The country of focus for the Index.</param>
        /// <param name="UpdateFrequency">How often the Index is updated.</param>
        /// <param name="LastUpdated">When the Index was updated last.</param>
        /// <param name="ObservationStart">The earliest date for which data is available.</param>
        /// <param name="ObservationEnd">The latest date for which data is available.</param>
        public StockMarketIndexSummary(string Id = default(string), string Symbol = default(string), string Name = default(string), string Continent = default(string), string Country = default(string), string UpdateFrequency = default(string), DateTime? LastUpdated = default(DateTime?), DateTime? ObservationStart = default(DateTime?), DateTime? ObservationEnd = default(DateTime?))
        {
            this.Id = Id;
            this.Symbol = Symbol;
            this.Name = Name;
            this.Continent = Continent;
            this.Country = Country;
            this.UpdateFrequency = UpdateFrequency;
            this.LastUpdated = LastUpdated;
            this.ObservationStart = ObservationStart;
            this.ObservationEnd = ObservationEnd;
        }
        
        /// <summary>
        /// Intrinio ID for the Index
        /// </summary>
        /// <value>Intrinio ID for the Index</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The symbol used to identify the Index
        /// </summary>
        /// <value>The symbol used to identify the Index</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// The name of the Index
        /// </summary>
        /// <value>The name of the Index</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The continent of the country of focus for the Index
        /// </summary>
        /// <value>The continent of the country of focus for the Index</value>
        [DataMember(Name="continent", EmitDefaultValue=false)]
        public string Continent { get; set; }

        /// <summary>
        /// The country of focus for the Index
        /// </summary>
        /// <value>The country of focus for the Index</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// How often the Index is updated
        /// </summary>
        /// <value>How often the Index is updated</value>
        [DataMember(Name="update_frequency", EmitDefaultValue=false)]
        public string UpdateFrequency { get; set; }

        /// <summary>
        /// When the Index was updated last
        /// </summary>
        /// <value>When the Index was updated last</value>
        [DataMember(Name="last_updated", EmitDefaultValue=false)]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// The earliest date for which data is available
        /// </summary>
        /// <value>The earliest date for which data is available</value>
        [DataMember(Name="observation_start", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ObservationStart { get; set; }

        /// <summary>
        /// The latest date for which data is available
        /// </summary>
        /// <value>The latest date for which data is available</value>
        [DataMember(Name="observation_end", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ObservationEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StockMarketIndexSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Continent: ").Append(Continent).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  UpdateFrequency: ").Append(UpdateFrequency).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  ObservationStart: ").Append(ObservationStart).Append("\n");
            sb.Append("  ObservationEnd: ").Append(ObservationEnd).Append("\n");
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
            return this.Equals(input as StockMarketIndexSummary);
        }

        /// <summary>
        /// Returns true if StockMarketIndexSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of StockMarketIndexSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockMarketIndexSummary input)
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
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Continent == input.Continent ||
                    (this.Continent != null &&
                    this.Continent.Equals(input.Continent))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.UpdateFrequency == input.UpdateFrequency ||
                    (this.UpdateFrequency != null &&
                    this.UpdateFrequency.Equals(input.UpdateFrequency))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.ObservationStart == input.ObservationStart ||
                    (this.ObservationStart != null &&
                    this.ObservationStart.Equals(input.ObservationStart))
                ) && 
                (
                    this.ObservationEnd == input.ObservationEnd ||
                    (this.ObservationEnd != null &&
                    this.ObservationEnd.Equals(input.ObservationEnd))
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
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Continent != null)
                    hashCode = hashCode * 59 + this.Continent.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.UpdateFrequency != null)
                    hashCode = hashCode * 59 + this.UpdateFrequency.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.ObservationStart != null)
                    hashCode = hashCode * 59 + this.ObservationStart.GetHashCode();
                if (this.ObservationEnd != null)
                    hashCode = hashCode * 59 + this.ObservationEnd.GetHashCode();
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

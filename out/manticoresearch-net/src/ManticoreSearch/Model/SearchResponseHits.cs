/*
 * Manticore Search Client
 *
 * Low-level client for Manticore Search. 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@manticoresearch.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = ManticoreSearch.Client.FileParameter;
using OpenAPIDateConverter = ManticoreSearch.Client.OpenAPIDateConverter;

namespace ManticoreSearch.Model
{
    /// <summary>
    /// SearchResponseHits
    /// </summary>
    [DataContract(Name = "searchResponse_hits")]
    public partial class SearchResponseHits : IEquatable<SearchResponseHits>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseHits" /> class.
        /// </summary>
        /// <param name="maxScore">maxScore.</param>
        /// <param name="total">total.</param>
        /// <param name="hits">hits.</param>
        public SearchResponseHits(int maxScore = default(int), int total = default(int), List<Object> hits = default(List<Object>))
        {
            this.MaxScore = maxScore;
            this.Total = total;
            this.Hits = hits;
        }

        /// <summary>
        /// Gets or Sets MaxScore
        /// </summary>
        [DataMember(Name = "max_score", EmitDefaultValue = false)]
        public int MaxScore { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Gets or Sets Hits
        /// </summary>
        [DataMember(Name = "hits", EmitDefaultValue = false)]
        public List<Object> Hits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchResponseHits {\n");
            sb.Append("  MaxScore: ").Append(MaxScore).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchResponseHits);
        }

        /// <summary>
        /// Returns true if SearchResponseHits instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResponseHits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResponseHits input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxScore == input.MaxScore ||
                    this.MaxScore.Equals(input.MaxScore)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Hits == input.Hits ||
                    this.Hits != null &&
                    input.Hits != null &&
                    this.Hits.SequenceEqual(input.Hits)
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
                hashCode = (hashCode * 59) + this.MaxScore.GetHashCode();
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Hits != null)
                {
                    hashCode = (hashCode * 59) + this.Hits.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
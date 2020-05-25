/* 
 * Manticore Search API
 *
 * This is the API for Manticore Search HTTP protocol 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@manticoresearch.com
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Payload for search operation
    /// </summary>
    [DataContract]
    public partial class SearchRequest :  IEquatable<SearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="index">index (required).</param>
        /// <param name="query">query (required).</param>
        /// <param name="limit">limit.</param>
        /// <param name="offset">offset.</param>
        /// <param name="maxMatches">maxMatches.</param>
        /// <param name="sort">sort.</param>
        /// <param name="scriptFields">scriptFields.</param>
        /// <param name="highlight">highlight.</param>
        /// <param name="source">source.</param>
        /// <param name="profile">profile.</param>
        public SearchRequest(string index = default(string), Dictionary<string, Object> query = default(Dictionary<string, Object>), int limit = default(int), int offset = default(int), int maxMatches = default(int), List<Object> sort = default(List<Object>), Object scriptFields = default(Object), Object highlight = default(Object), List<string> source = default(List<string>), bool profile = default(bool))
        {
            // to ensure "index" is required (not null)
            if (index == null)
            {
                throw new InvalidDataException("index is a required property for SearchRequest and cannot be null");
            }
            else
            {
                this.Index = index;
            }
            
            // to ensure "query" is required (not null)
            if (query == null)
            {
                throw new InvalidDataException("query is a required property for SearchRequest and cannot be null");
            }
            else
            {
                this.Query = query;
            }
            
            this.Limit = limit;
            this.Offset = offset;
            this.MaxMatches = maxMatches;
            this.Sort = sort;
            this.ScriptFields = scriptFields;
            this.Highlight = highlight;
            this.Source = source;
            this.Profile = profile;
        }
        
        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="index", EmitDefaultValue=true)]
        public string Index { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=true)]
        public Dictionary<string, Object> Query { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int Offset { get; set; }

        /// <summary>
        /// Gets or Sets MaxMatches
        /// </summary>
        [DataMember(Name="max_matches", EmitDefaultValue=false)]
        public int MaxMatches { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<Object> Sort { get; set; }

        /// <summary>
        /// Gets or Sets ScriptFields
        /// </summary>
        [DataMember(Name="script_fields", EmitDefaultValue=false)]
        public Object ScriptFields { get; set; }

        /// <summary>
        /// Gets or Sets Highlight
        /// </summary>
        [DataMember(Name="highlight", EmitDefaultValue=false)]
        public Object Highlight { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="_source", EmitDefaultValue=false)]
        public List<string> Source { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public bool Profile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchRequest {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  MaxMatches: ").Append(MaxMatches).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  ScriptFields: ").Append(ScriptFields).Append("\n");
            sb.Append("  Highlight: ").Append(Highlight).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
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
            return this.Equals(input as SearchRequest);
        }

        /// <summary>
        /// Returns true if SearchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Query == input.Query ||
                    this.Query != null &&
                    input.Query != null &&
                    this.Query.SequenceEqual(input.Query)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.MaxMatches == input.MaxMatches ||
                    (this.MaxMatches != null &&
                    this.MaxMatches.Equals(input.MaxMatches))
                ) && 
                (
                    this.Sort == input.Sort ||
                    this.Sort != null &&
                    input.Sort != null &&
                    this.Sort.SequenceEqual(input.Sort)
                ) && 
                (
                    this.ScriptFields == input.ScriptFields ||
                    (this.ScriptFields != null &&
                    this.ScriptFields.Equals(input.ScriptFields))
                ) && 
                (
                    this.Highlight == input.Highlight ||
                    (this.Highlight != null &&
                    this.Highlight.Equals(input.Highlight))
                ) && 
                (
                    this.Source == input.Source ||
                    this.Source != null &&
                    input.Source != null &&
                    this.Source.SequenceEqual(input.Source)
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
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
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.MaxMatches != null)
                    hashCode = hashCode * 59 + this.MaxMatches.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.ScriptFields != null)
                    hashCode = hashCode * 59 + this.ScriptFields.GetHashCode();
                if (this.Highlight != null)
                    hashCode = hashCode * 59 + this.Highlight.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
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

            
            // Limit (int) minimum
            if(this.Limit < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value greater than or equal to 0.", new [] { "Limit" });
            }


            
            // Offset (int) minimum
            if(this.Offset < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Offset, must be a value greater than or equal to 0.", new [] { "Offset" });
            }


            
            // MaxMatches (int) minimum
            if(this.MaxMatches < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxMatches, must be a value greater than or equal to 0.", new [] { "MaxMatches" });
            }

            yield break;
        }
    }

}

/*
 * People Management API - BRA
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.2.1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Iatec.Adems.PeopleManagement.Client.Model
{
    /// <summary>
    /// NaturalPersonRelationshipLiteModel
    /// </summary>
    [DataContract]
    public partial class NaturalPersonRelationshipLiteModel : IEquatable<NaturalPersonRelationshipLiteModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NaturalPersonRelationshipLiteModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NaturalPersonRelationshipLiteModel() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="NaturalPersonRelationshipLiteModel" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="LivesWith">LivesWith (required).</param>
        /// <param name="NaturalPersonId">NaturalPersonId.</param>
        /// <param name="NaturalPersonName">NaturalPersonName.</param>
        /// <param name="RelatedId">RelatedId.</param>
        /// <param name="Relationship">Relationship.</param>
        public NaturalPersonRelationshipLiteModel(Guid Id = default(Guid), bool LivesWith = default(bool), Guid NaturalPersonId = default(Guid), string NaturalPersonName = default(string), Guid RelatedId = default(Guid), RelationshipModel Relationship = default(RelationshipModel))
        {
            this.LivesWith = LivesWith;
            this.Id = Id;
            this.NaturalPersonId = NaturalPersonId;
            this.NaturalPersonName = NaturalPersonName;
            this.RelatedId = RelatedId;
            this.Relationship = Relationship;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets LivesWith
        /// </summary>
        [DataMember(Name = "livesWith", EmitDefaultValue = false)]
        public bool LivesWith { get; set; }

        /// <summary>
        /// Gets or Sets NaturalPersonId
        /// </summary>
        [DataMember(Name = "naturalPersonId", EmitDefaultValue = false)]
        public Guid NaturalPersonId { get; set; }

        /// <summary>
        /// Gets or Sets NaturalPersonName
        /// </summary>
        [DataMember(Name = "naturalPersonName", EmitDefaultValue = false)]
        public string NaturalPersonName { get; set; }

        /// <summary>
        /// Gets or Sets RelatedId
        /// </summary>
        [DataMember(Name = "relatedId", EmitDefaultValue = false)]
        public Guid RelatedId { get; set; }

        /// <summary>
        /// Gets or Sets Relationship
        /// </summary>
        [DataMember(Name = "relationship", EmitDefaultValue = false)]
        public RelationshipModel Relationship { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NaturalPersonRelationshipLiteModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LivesWith: ").Append(LivesWith).Append("\n");
            sb.Append("  NaturalPersonId: ").Append(NaturalPersonId).Append("\n");
            sb.Append("  NaturalPersonName: ").Append(NaturalPersonName).Append("\n");
            sb.Append("  RelatedId: ").Append(RelatedId).Append("\n");
            sb.Append("  Relationship: ").Append(Relationship).Append("\n");
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
            return this.Equals(input as NaturalPersonRelationshipLiteModel);
        }

        /// <summary>
        /// Returns true if NaturalPersonRelationshipLiteModel instances are equal
        /// </summary>
        /// <param name="input">Instance of NaturalPersonRelationshipLiteModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NaturalPersonRelationshipLiteModel input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Id == input.Id ||
                    (this.Id != default(Guid) &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.LivesWith == input.LivesWith ||
                    (                    this.LivesWith.Equals(input.LivesWith))
                ) &&
                (
                    this.NaturalPersonId == input.NaturalPersonId ||
                    (this.NaturalPersonId != default(Guid) &&
                    this.NaturalPersonId.Equals(input.NaturalPersonId))
                ) &&
                (
                    this.NaturalPersonName == input.NaturalPersonName ||
                    (this.NaturalPersonName != null &&
                    this.NaturalPersonName.Equals(input.NaturalPersonName))
                ) &&
                (
                    this.RelatedId == input.RelatedId ||
                    (this.RelatedId != default(Guid) &&
                    this.RelatedId.Equals(input.RelatedId))
                ) &&
                (
                    this.Relationship == input.Relationship ||
                    (this.Relationship != null &&
                    this.Relationship.Equals(input.Relationship))
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
                if (this.Id != default(Guid))
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                    hashCode = hashCode * 59 + this.LivesWith.GetHashCode();
                if (this.NaturalPersonId != default(Guid))
                    hashCode = hashCode * 59 + this.NaturalPersonId.GetHashCode();
                if (this.NaturalPersonName != null)
                    hashCode = hashCode * 59 + this.NaturalPersonName.GetHashCode();
                if (this.RelatedId != default(Guid))
                    hashCode = hashCode * 59 + this.RelatedId.GetHashCode();
                if (this.Relationship != null)
                    hashCode = hashCode * 59 + this.Relationship.GetHashCode();
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
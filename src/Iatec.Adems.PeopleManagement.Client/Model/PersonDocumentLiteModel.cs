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
using System.Runtime.Serialization;
using System.Text;

namespace Iatec.Adems.PeopleManagement.Client.Model
{
    /// <summary>
    /// PersonDocumentLiteModel
    /// </summary>
    [DataContract]
    public partial class PersonDocumentLiteModel : IEquatable<PersonDocumentLiteModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonDocumentLiteModel" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Comments">Comments.</param>
        /// <param name="DocNumber">DocNumber.</param>
        /// <param name="DocumentType">DocumentType.</param>
        /// <param name="ExpirationDate">ExpirationDate.</param>
        /// <param name="IssueBy">IssueBy.</param>
        /// <param name="IssueDate">IssueDate.</param>
        /// <param name="LastUpdate">LastUpdate.</param>
        /// <param name="PersonId">PersonId.</param>
        public PersonDocumentLiteModel(Guid Id = default(Guid), string Comments = default(string), string DocNumber = default(string), 
            DocumentTypeModel DocumentType = default(DocumentTypeModel), DateTime? ExpirationDate = default(DateTime?), string IssueBy = default(string),
            DateTime? IssueDate = default(DateTime?), DateTime LastUpdate = default(DateTime), Guid PersonId = default(Guid))
        {
            this.Id = Id;
            this.Comments = Comments;
            this.DocNumber = DocNumber;
            this.DocumentType = DocumentType;
            this.ExpirationDate = ExpirationDate;
            this.IssueBy = IssueBy;
            this.IssueDate = IssueDate;
            this.LastUpdate = LastUpdate;
            this.PersonId = PersonId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name = "comments", EmitDefaultValue = false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets DocNumber
        /// </summary>
        [DataMember(Name = "docNumber", EmitDefaultValue = false)]
        public string DocNumber { get; set; }

        /// <summary>
        /// Gets or Sets DocumentType
        /// </summary>
        [DataMember(Name = "documentType", EmitDefaultValue = false)]
        public DocumentTypeModel DocumentType { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets IssueBy
        /// </summary>
        [DataMember(Name = "issueBy", EmitDefaultValue = false)]
        public string IssueBy { get; set; }

        /// <summary>
        /// Gets or Sets IssueDate
        /// </summary>
        [DataMember(Name = "issueDate", EmitDefaultValue = false)]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Gets or Sets PersonId
        /// </summary>
        [DataMember(Name = "personId", EmitDefaultValue = false)]
        public Guid PersonId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonDocumentLiteModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  IssueBy: ").Append(IssueBy).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  PersonId: ").Append(PersonId).Append("\n");
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
            return this.Equals(input as PersonDocumentLiteModel);
        }

        /// <summary>
        /// Returns true if PersonDocumentLiteModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PersonDocumentLiteModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonDocumentLiteModel input)
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
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) &&
                (
                    this.DocNumber == input.DocNumber ||
                    (this.DocNumber != null &&
                    this.DocNumber.Equals(input.DocNumber))
                ) &&
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) &&
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) &&
                (
                    this.IssueBy == input.IssueBy ||
                    (this.IssueBy != null &&
                    this.IssueBy.Equals(input.IssueBy))
                ) &&
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) &&
                (
                    this.LastUpdate == input.LastUpdate ||
                    (this.LastUpdate != null &&
                    this.LastUpdate.Equals(input.LastUpdate))
                ) &&
                (
                    this.PersonId == input.PersonId ||
                    (this.PersonId != default(Guid) &&
                    this.PersonId.Equals(input.PersonId))
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
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.DocNumber != null)
                    hashCode = hashCode * 59 + this.DocNumber.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.IssueBy != null)
                    hashCode = hashCode * 59 + this.IssueBy.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.LastUpdate != null)
                    hashCode = hashCode * 59 + this.LastUpdate.GetHashCode();
                if (this.PersonId != default(Guid))
                    hashCode = hashCode * 59 + this.PersonId.GetHashCode();
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
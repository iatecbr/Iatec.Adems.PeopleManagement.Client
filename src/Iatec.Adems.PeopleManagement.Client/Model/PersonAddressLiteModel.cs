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
    /// PersonAddressLiteModel
    /// </summary>
    [DataContract]
    public partial class PersonAddressLiteModel : IEquatable<PersonAddressLiteModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonAddressLiteModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PersonAddressLiteModel() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonAddressLiteModel" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="AddressLine01">AddressLine01.</param>
        /// <param name="AddressLine02">AddressLine02.</param>
        /// <param name="AddressLine03">AddressLine03.</param>
        /// <param name="OtherLocality">OtherLocality.</param>
        /// <param name="IsMailingAddress">IsMailingAddress (required).</param>
        /// <param name="LastUpdate">LastUpdate.</param>
        /// <param name="PersonId">PersonId.</param>
        /// <param name="ZipPostalCode">ZipPostalCode.</param>
        /// <param name="AddressType">AddressType.</param>
        /// <param name="Country">Country.</param>
        /// <param name="Locality">Locality.</param>
        /// <param name="StateProvince">StateProvince.</param>
        /// <param name="AddressNumber">AddressNumber.</param>
        public PersonAddressLiteModel(Guid Id = default(Guid), string AddressLine01 = default(string), string AddressLine02 = default(string), string AddressLine03 = default(string), 
            string OtherLocality = default(string), bool IsMailingAddress = default(bool), DateTime LastUpdate = default(DateTime), Guid PersonId = default(Guid),
            string ZipPostalCode = default(string), AddressTypeModel AddressType = default(AddressTypeModel),  CountryLiteSearchModel Country = default(CountryLiteSearchModel),
            LocalityLiteSearchModel Locality = default(LocalityLiteSearchModel), LocalityLiteSearchModel StateProvince = default(LocalityLiteSearchModel), string AddressNumber = default(string))
        {            
            this.Id = Id;
            this.AddressLine01 = AddressLine01;
            this.AddressLine02 = AddressLine02;
            this.AddressLine03 = AddressLine03;
            this.OtherLocality = OtherLocality;
            this.LastUpdate = LastUpdate;
            this.PersonId = PersonId;
            this.ZipPostalCode = ZipPostalCode;
            this.AddressType = AddressType;
            this.Country = Country;
            this.Locality = Locality;
            this.IsMailingAddress = IsMailingAddress;
            this.StateProvince = StateProvince;
            this.AddressNumber = AddressNumber;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine01
        /// </summary>
        [DataMember(Name = "addressLine01", EmitDefaultValue = false)]
        public string AddressLine01 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine02
        /// </summary>
        [DataMember(Name = "addressLine02", EmitDefaultValue = false)]
        public string AddressLine02 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine03
        /// </summary>
        [DataMember(Name = "addressLine03", EmitDefaultValue = false)]
        public string AddressLine03 { get; set; }

        /// <summary>
        /// Gets or Sets OtherLocality
        /// </summary>
        [DataMember(Name = "otherLocality", EmitDefaultValue = false)]
        public string OtherLocality { get; set; }

        /// <summary>
        /// Gets or Sets IsMailingAddress
        /// </summary>
        [DataMember(Name = "isMailingAddress", EmitDefaultValue = false)]
        public bool IsMailingAddress { get; set; }

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
        /// Gets or Sets ZipPostalCode
        /// </summary>
        [DataMember(Name = "zipPostalCode", EmitDefaultValue = false)]
        public string ZipPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets AddressType
        /// </summary>
        [DataMember(Name = "addressType", EmitDefaultValue = false)]
        public AddressTypeModel AddressType { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public CountryLiteSearchModel Country { get; set; }

        /// <summary>
        /// Gets or Sets Locality
        /// </summary>
        [DataMember(Name = "locality", EmitDefaultValue = false)]
        public LocalityLiteSearchModel Locality { get; set; }

        /// <summary>
        /// Gets or Sets StateProvince
        /// </summary>
        [DataMember(Name = "stateProvince", EmitDefaultValue = false)]
        public LocalityLiteSearchModel StateProvince { get; set; }

        /// <summary>
        /// Gets or Sets AddressNumber
        /// </summary>
        [DataMember(Name = "addressNumber", EmitDefaultValue = false)]
        public string AddressNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonAddressLiteModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AddressLine01: ").Append(AddressLine01).Append("\n");
            sb.Append("  AddressLine02: ").Append(AddressLine02).Append("\n");
            sb.Append("  AddressLine03: ").Append(AddressLine03).Append("\n");
            sb.Append("  OtherLocality: ").Append(OtherLocality).Append("\n");
            sb.Append("  IsMailingAddress: ").Append(IsMailingAddress).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  PersonId: ").Append(PersonId).Append("\n");
            sb.Append("  ZipPostalCode: ").Append(ZipPostalCode).Append("\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  AddressNumber: ").Append(AddressNumber).Append("\n");
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
            return this.Equals(input as PersonAddressLiteModel);
        }

        /// <summary>
        /// Returns true if PersonAddressLiteModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PersonAddressLiteModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonAddressLiteModel input)
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
                    this.AddressLine01 == input.AddressLine01 ||
                    (this.AddressLine01 != null &&
                    this.AddressLine01.Equals(input.AddressLine01))
                ) &&
                (
                    this.AddressLine02 == input.AddressLine02 ||
                    (this.AddressLine02 != null &&
                    this.AddressLine02.Equals(input.AddressLine02))
                ) &&
                (
                    this.AddressLine03 == input.AddressLine03 ||
                    (this.AddressLine03 != null &&
                    this.AddressLine03.Equals(input.AddressLine03))
                ) &&
                (
                    this.OtherLocality == input.OtherLocality ||
                    (this.OtherLocality != null &&
                    this.OtherLocality.Equals(input.OtherLocality))
                ) &&
                (
                    this.IsMailingAddress == input.IsMailingAddress ||
                    (                    this.IsMailingAddress.Equals(input.IsMailingAddress))
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
                ) &&
                (
                    this.ZipPostalCode == input.ZipPostalCode ||
                    (this.ZipPostalCode != null &&
                    this.ZipPostalCode.Equals(input.ZipPostalCode))
                ) &&
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
                ) &&
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) &&
                (
                    this.Locality == input.Locality ||
                    (this.Locality != null &&
                    this.Locality.Equals(input.Locality))
                ) &&
                (
                    this.StateProvince == input.StateProvince ||
                    (this.StateProvince != null &&
                    this.StateProvince.Equals(input.StateProvince))
                ) &&
                (
                    this.AddressNumber == input.AddressNumber ||
                    (this.AddressNumber != null &&
                    this.AddressNumber.Equals(input.AddressNumber))
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
                if (this.AddressLine01 != null)
                    hashCode = hashCode * 59 + this.AddressLine01.GetHashCode();
                if (this.AddressLine02 != null)
                    hashCode = hashCode * 59 + this.AddressLine02.GetHashCode();
                if (this.AddressLine03 != null)
                    hashCode = hashCode * 59 + this.AddressLine03.GetHashCode();
                if (this.OtherLocality != null)
                    hashCode = hashCode * 59 + this.OtherLocality.GetHashCode();
                    hashCode = hashCode * 59 + this.IsMailingAddress.GetHashCode();
                if (this.LastUpdate != null)
                    hashCode = hashCode * 59 + this.LastUpdate.GetHashCode();
                if (this.PersonId != default(Guid))
                    hashCode = hashCode * 59 + this.PersonId.GetHashCode();
                if (this.ZipPostalCode != null)
                    hashCode = hashCode * 59 + this.ZipPostalCode.GetHashCode();
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Locality != null)
                    hashCode = hashCode * 59 + this.Locality.GetHashCode();
                if (this.StateProvince != null)
                    hashCode = hashCode * 59 + this.StateProvince.GetHashCode();
                if (this.AddressNumber != null)
                    hashCode = hashCode * 59 + this.AddressNumber.GetHashCode();
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
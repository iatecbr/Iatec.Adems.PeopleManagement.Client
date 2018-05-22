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
using System.Globalization;
using System.Linq;

namespace Iatec.Adems.PeopleManagement.Client.Model
{
    /// <summary>
    /// Defines NaturalPersonEntityType
    /// </summary>

    [JsonConverter(typeof(EnumClassConverter))]
    public class NaturalPersonEntityTypeModel : IEquatable<NaturalPersonEntityTypeModel>, IConvertible
    {
        public NaturalPersonEntityTypeModel()
        {
        }

        private NaturalPersonEntityTypeModel(string name, int value_plus1)
        {
            this.Name = name;
            this.valuePlus1 = value_plus1;
        }

        public string Name { get; }
        private int valuePlus1;
        public int Value => valuePlus1 - 1;

        /// <summary>
        /// Enum NaturalPerson for value: NaturalPerson
        /// </summary>
        public static NaturalPersonEntityTypeModel NaturalPerson = new NaturalPersonEntityTypeModel("NaturalPerson", 1);

        /// <summary>
        /// Enum PersonAddress for value: PersonAddress
        /// </summary>
        public static NaturalPersonEntityTypeModel PersonAddress = new NaturalPersonEntityTypeModel("PersonAddress", 2);

        /// <summary>
        /// Enum PersonDocument for value: PersonDocument
        /// </summary>
        public static NaturalPersonEntityTypeModel PersonDocument = new NaturalPersonEntityTypeModel("PersonDocument", 3);

        /// <summary>
        /// Enum PersonEContact for value: PersonEContact
        /// </summary>
        public static NaturalPersonEntityTypeModel PersonEContact = new NaturalPersonEntityTypeModel("PersonEContact", 4);

        /// <summary>
        /// Enum PersonPhone for value: PersonPhone
        /// </summary>
        public static NaturalPersonEntityTypeModel PersonPhone = new NaturalPersonEntityTypeModel("PersonPhone", 5);

        /// <summary>
        /// Enum NaturalPersonAllergy for value: NaturalPersonAllergy
        /// </summary>
        public static NaturalPersonEntityTypeModel NaturalPersonAllergy = new NaturalPersonEntityTypeModel("NaturalPersonAllergy", 6);

        /// <summary>
        /// Enum NaturalPersonDisability for value: NaturalPersonDisability
        /// </summary>
        public static NaturalPersonEntityTypeModel NaturalPersonDisability = new NaturalPersonEntityTypeModel("NaturalPersonDisability", 7);

        /// <summary>
        /// Enum NaturalPersonDisease for value: NaturalPersonDisease
        /// </summary>
        public static NaturalPersonEntityTypeModel NaturalPersonDisease = new NaturalPersonEntityTypeModel("NaturalPersonDisease", 8);

        /// <summary>
        /// Enum NaturalPersonHealth for value: NaturalPersonHealth
        /// </summary>
        public static NaturalPersonEntityTypeModel NaturalPersonHealth = new NaturalPersonEntityTypeModel("NaturalPersonHealth", 9);

        /// <summary>
        /// Enum NaturalPersonMedicine for value: NaturalPersonMedicine
        /// </summary>
        public static NaturalPersonEntityTypeModel NaturalPersonMedicine = new NaturalPersonEntityTypeModel("NaturalPersonMedicine", 10);

        /// <summary>
        /// Enum NaturalPersonRelationship for value: NaturalPersonRelationship
        /// </summary>
        public static NaturalPersonEntityTypeModel NaturalPersonRelationship = new NaturalPersonEntityTypeModel("NaturalPersonRelationship", 11);

        /// <summary>
        /// Enum EmergencyContact for value: EmergencyContact
        /// </summary>
        public static NaturalPersonEntityTypeModel EmergencyContact = new NaturalPersonEntityTypeModel("EmergencyContact", 12);

        private static IEnumerable<NaturalPersonEntityTypeModel> fields = new[] {
            NaturalPerson,
            PersonAddress,
            PersonDocument,
            PersonEContact,
            PersonPhone,
            NaturalPersonAllergy,
            NaturalPersonDisability,
            NaturalPersonDisease,
            NaturalPersonHealth,
            NaturalPersonMedicine,
            NaturalPersonRelationship,
            EmergencyContact,
        };

        public override string ToString()
        {
            return this.Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is NaturalPersonEntityTypeModel e)
            {
                return Equals(e);
            }
            else return false;
        }

        public bool Equals(NaturalPersonEntityTypeModel other)
        {
            if (other == null)
                return this.Name == null;
            return this.Value == other.Value;
        }

        public override int GetHashCode()
        {
            var hashCode = -244751520;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Value.GetHashCode();
            return hashCode;
        }

        public TypeCode GetTypeCode() => TypeCode.Int32;

        public bool ToBoolean(IFormatProvider provider) => true;

        public char ToChar(IFormatProvider provider) => (char)ToInt32(provider);

        public sbyte ToSByte(IFormatProvider provider) => (sbyte)ToInt32(provider);

        public byte ToByte(IFormatProvider provider) => (byte)ToInt32(provider);

        public short ToInt16(IFormatProvider provider) => (short)ToInt32(provider);

        public ushort ToUInt16(IFormatProvider provider) => (ushort)ToInt32(provider);

        public int ToInt32(IFormatProvider provider) => Value;

        public uint ToUInt32(IFormatProvider provider) => (uint)ToInt32(provider);

        public long ToInt64(IFormatProvider provider) => ToInt32(provider);

        public ulong ToUInt64(IFormatProvider provider) => (ulong)ToInt32(provider);

        public float ToSingle(IFormatProvider provider) => ToInt32(provider);

        public double ToDouble(IFormatProvider provider) => ToInt32(provider);

        public decimal ToDecimal(IFormatProvider provider) => ToInt32(provider);

        public DateTime ToDateTime(IFormatProvider provider) => throw new InvalidCastException();

        public string ToString(IFormatProvider provider) => Name;

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            if (conversionType == typeof(NaturalPersonEntityTypeModel))
                return this;

            if (conversionType == typeof(bool)) return ToBoolean(provider);
            if (conversionType == typeof(char)) return ToChar(provider);
            if (conversionType == typeof(sbyte)) return ToSByte(provider);
            if (conversionType == typeof(byte)) return ToByte(provider);
            if (conversionType == typeof(short)) return ToInt16(provider);
            if (conversionType == typeof(ushort)) return ToUInt16(provider);
            if (conversionType == typeof(int)) return ToInt32(provider);
            if (conversionType == typeof(uint)) return ToUInt32(provider);
            if (conversionType == typeof(long)) return ToInt64(provider);
            if (conversionType == typeof(ulong)) return ToUInt64(provider);
            if (conversionType == typeof(float)) return ToSingle(provider);
            if (conversionType == typeof(double)) return ToDouble(provider);
            if (conversionType == typeof(decimal)) return ToDecimal(provider);
            if (conversionType == typeof(DateTime)) return ToDateTime(provider);
            if (conversionType == typeof(string)) return ToString(provider);

            throw new InvalidCastException();
        }

        public static bool operator ==(NaturalPersonEntityTypeModel a, NaturalPersonEntityTypeModel b)
        {
            if (object.ReferenceEquals(a, b))
                return true;
            return object.ReferenceEquals(b, null)
                ? a.Equals(b)
                : b.Equals(a);
        }

        public static bool operator !=(NaturalPersonEntityTypeModel a, NaturalPersonEntityTypeModel b)
        {
            return !(a == b);
        }

        public static explicit operator char(NaturalPersonEntityTypeModel value) => value.ToChar(CultureInfo.InvariantCulture);

        public static explicit operator sbyte(NaturalPersonEntityTypeModel value) => value.ToSByte(CultureInfo.InvariantCulture);

        public static explicit operator byte(NaturalPersonEntityTypeModel value) => value.ToByte(CultureInfo.InvariantCulture);

        public static explicit operator short(NaturalPersonEntityTypeModel value) => value.ToInt16(CultureInfo.InvariantCulture);

        public static explicit operator ushort(NaturalPersonEntityTypeModel value) => value.ToUInt16(CultureInfo.InvariantCulture);

        public static explicit operator int(NaturalPersonEntityTypeModel value) => value.ToInt32(CultureInfo.InvariantCulture);

        public static explicit operator uint(NaturalPersonEntityTypeModel value) => value.ToUInt32(CultureInfo.InvariantCulture);

        public static explicit operator long(NaturalPersonEntityTypeModel value) => value.ToInt64(CultureInfo.InvariantCulture);

        public static explicit operator ulong(NaturalPersonEntityTypeModel value) => value.ToUInt64(CultureInfo.InvariantCulture);

        public static explicit operator float(NaturalPersonEntityTypeModel value) => value.ToSingle(CultureInfo.InvariantCulture);

        public static explicit operator double(NaturalPersonEntityTypeModel value) => value.ToDouble(CultureInfo.InvariantCulture);

        public static explicit operator decimal(NaturalPersonEntityTypeModel value) => value.ToDecimal(CultureInfo.InvariantCulture);

        public static explicit operator string(NaturalPersonEntityTypeModel value) => value.ToString(CultureInfo.InvariantCulture);

        public static bool TryParse(string name, out NaturalPersonEntityTypeModel parsed)
        {
            parsed = fields.FirstOrDefault(x => x.Name == name);
            return parsed != null;
        }

        public static bool TryParse(int value, out NaturalPersonEntityTypeModel parsed)
        {
            parsed = fields.FirstOrDefault(x => x.Value == value);
            return parsed != null;
        }

        public static NaturalPersonEntityTypeModel Parse(string name)
        {
            if (!TryParse(name, out NaturalPersonEntityTypeModel parsed))
                throw new InvalidCastException();
            return parsed;
        }

        public static NaturalPersonEntityTypeModel Parse(int value)
        {
            if (!TryParse(value, out NaturalPersonEntityTypeModel parsed))
                throw new InvalidCastException();
            return parsed;
        }

        public static explicit operator NaturalPersonEntityTypeModel(int value) => Parse(value);

        public static explicit operator NaturalPersonEntityTypeModel(string name) => Parse(name);
    }
}
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
    /// Defines Gender
    /// </summary>

    [JsonConverter(typeof(EnumClassConverter))]
    public class GenderModel : IEquatable<GenderModel>, IConvertible
    {
        public GenderModel()
        {
        }

        private GenderModel(string name, int value)
        {
            this.Name = name;
            this.value = value;
        }

        public string Name { get; }
        private int value;
        public int Value => value;

        /// <summary>
        /// Enum Male for value: Male
        /// </summary>
        public static GenderModel Male = new GenderModel("Male", 0);

        /// <summary>
        /// Enum Female for value: Female
        /// </summary>
        public static GenderModel Female = new GenderModel("Female", 1);

        private static IEnumerable<GenderModel> fields = new[] {
            Male,
            Female,
        };

        public override string ToString()
        {
            return this.Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is GenderModel e)
            {
                return Equals(e);
            }
            else return false;
        }

        public bool Equals(GenderModel other)
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
            if (conversionType == typeof(GenderModel))
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

        public static bool operator ==(GenderModel a, GenderModel b)
        {
            if (object.ReferenceEquals(a, b))
                return true;
            return object.ReferenceEquals(b, null)
                ? a.Equals(b)
                : b.Equals(a);
        }

        public static bool operator !=(GenderModel a, GenderModel b)
        {
            return !(a == b);
        }

        public static explicit operator char(GenderModel value) => value.ToChar(CultureInfo.InvariantCulture);

        public static explicit operator sbyte(GenderModel value) => value.ToSByte(CultureInfo.InvariantCulture);

        public static explicit operator byte(GenderModel value) => value.ToByte(CultureInfo.InvariantCulture);

        public static explicit operator short(GenderModel value) => value.ToInt16(CultureInfo.InvariantCulture);

        public static explicit operator ushort(GenderModel value) => value.ToUInt16(CultureInfo.InvariantCulture);

        public static explicit operator int(GenderModel value) => value.ToInt32(CultureInfo.InvariantCulture);

        public static explicit operator uint(GenderModel value) => value.ToUInt32(CultureInfo.InvariantCulture);

        public static explicit operator long(GenderModel value) => value.ToInt64(CultureInfo.InvariantCulture);

        public static explicit operator ulong(GenderModel value) => value.ToUInt64(CultureInfo.InvariantCulture);

        public static explicit operator float(GenderModel value) => value.ToSingle(CultureInfo.InvariantCulture);

        public static explicit operator double(GenderModel value) => value.ToDouble(CultureInfo.InvariantCulture);

        public static explicit operator decimal(GenderModel value) => value.ToDecimal(CultureInfo.InvariantCulture);

        public static explicit operator string(GenderModel value) => value.ToString(CultureInfo.InvariantCulture);

        public static bool TryParse(string name, out GenderModel parsed)
        {
            parsed = fields.FirstOrDefault(x => x.Name == name);
            return parsed != null;
        }

        public static bool TryParse(int value, out GenderModel parsed)
        {
            parsed = fields.FirstOrDefault(x => x.Value == value);
            return parsed != null;
        }

        public static GenderModel Parse(string name)
        {
            if (!TryParse(name, out GenderModel parsed))
                throw new InvalidCastException();
            return parsed;
        }

        public static GenderModel Parse(int value)
        {
            if (!TryParse(value, out GenderModel parsed))
                throw new InvalidCastException();
            return parsed;
        }

        public static explicit operator GenderModel(int value) => Parse(value);

        public static explicit operator GenderModel(string name) => Parse(name);
    }
}
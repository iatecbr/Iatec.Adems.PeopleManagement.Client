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
    /// Defines MessageType
    /// </summary>

    [JsonConverter(typeof(EnumClassConverter))]
    public class MessageTypeModel : IEquatable<MessageTypeModel>, IConvertible
    {
        public MessageTypeModel()
        {
        }

        private MessageTypeModel(string name, int value_plus1)
        {
            this.Name = name;
            this.valuePlus1 = value_plus1;
        }

        public string Name { get; }
        private int valuePlus1;
        public int Value => valuePlus1 - 1;

        /// <summary>
        /// Enum Successfully for value: Successfully
        /// </summary>
        public static MessageTypeModel Successfully = new MessageTypeModel("Successfully", 1);

        /// <summary>
        /// Enum Error for value: Error
        /// </summary>
        public static MessageTypeModel Error = new MessageTypeModel("Error", 2);

        /// <summary>
        /// Enum Attention for value: Attention
        /// </summary>
        public static MessageTypeModel Attention = new MessageTypeModel("Attention", 3);

        private static IEnumerable<MessageTypeModel> fields = new[] {
            Successfully,
            Error,
            Attention,
        };

        public override string ToString()
        {
            return this.Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is MessageTypeModel e)
            {
                return Equals(e);
            }
            else return false;
        }

        public bool Equals(MessageTypeModel other)
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
            if (conversionType == typeof(MessageTypeModel))
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

        public static bool operator ==(MessageTypeModel a, MessageTypeModel b)
        {
            if (object.ReferenceEquals(a, b))
                return true;
            return object.ReferenceEquals(b, null)
                ? a.Equals(b)
                : b.Equals(a);
        }

        public static bool operator !=(MessageTypeModel a, MessageTypeModel b)
        {
            return !(a == b);
        }

        public static explicit operator char(MessageTypeModel value) => value.ToChar(CultureInfo.InvariantCulture);

        public static explicit operator sbyte(MessageTypeModel value) => value.ToSByte(CultureInfo.InvariantCulture);

        public static explicit operator byte(MessageTypeModel value) => value.ToByte(CultureInfo.InvariantCulture);

        public static explicit operator short(MessageTypeModel value) => value.ToInt16(CultureInfo.InvariantCulture);

        public static explicit operator ushort(MessageTypeModel value) => value.ToUInt16(CultureInfo.InvariantCulture);

        public static explicit operator int(MessageTypeModel value) => value.ToInt32(CultureInfo.InvariantCulture);

        public static explicit operator uint(MessageTypeModel value) => value.ToUInt32(CultureInfo.InvariantCulture);

        public static explicit operator long(MessageTypeModel value) => value.ToInt64(CultureInfo.InvariantCulture);

        public static explicit operator ulong(MessageTypeModel value) => value.ToUInt64(CultureInfo.InvariantCulture);

        public static explicit operator float(MessageTypeModel value) => value.ToSingle(CultureInfo.InvariantCulture);

        public static explicit operator double(MessageTypeModel value) => value.ToDouble(CultureInfo.InvariantCulture);

        public static explicit operator decimal(MessageTypeModel value) => value.ToDecimal(CultureInfo.InvariantCulture);

        public static explicit operator string(MessageTypeModel value) => value.ToString(CultureInfo.InvariantCulture);

        public static bool TryParse(string name, out MessageTypeModel parsed)
        {
            parsed = fields.FirstOrDefault(x => x.Name == name);
            return parsed != null;
        }

        public static bool TryParse(int value, out MessageTypeModel parsed)
        {
            parsed = fields.FirstOrDefault(x => x.Value == value);
            return parsed != null;
        }

        public static MessageTypeModel Parse(string name)
        {
            if (!TryParse(name, out MessageTypeModel parsed))
                throw new InvalidCastException();
            return parsed;
        }

        public static MessageTypeModel Parse(int value)
        {
            if (!TryParse(value, out MessageTypeModel parsed))
                throw new InvalidCastException();
            return parsed;
        }

        public static explicit operator MessageTypeModel(int value) => Parse(value);

        public static explicit operator MessageTypeModel(string name) => Parse(name);
    }
}
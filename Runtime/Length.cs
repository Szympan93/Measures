using System;
using System.Runtime.CompilerServices;

namespace FunFact.Measures
{
    public readonly struct Length : IComparable, IComparable<Length>, IEquatable<Length>, IFormattable
    {
        private const float SCALE_METER = 1f;
        private const float SCALE_FEET = 1f/0.3048f;
        private const float SCALE_INCHES = 39.37008f;
        private const float SCALE_MILES = 0.00062f;
        private readonly float _raw;
        
        public float Meters
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _raw * SCALE_METER;
        }
        
        public float Feet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _raw * SCALE_FEET;
        }
        
        public float Inches
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _raw * SCALE_INCHES;
        }
        
        public float Miles
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _raw * SCALE_MILES;
        }
        
        private Length(float raw) => _raw = raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length FromMeters(float value) => new(value / SCALE_METER);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length FromFeet(float value) => new(value / SCALE_FEET);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length FromInches(float value) => new(value / SCALE_INCHES);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length FromMiles(float value) => new(value / SCALE_MILES);
        public override int GetHashCode() => _raw.GetHashCode();
        public int CompareTo(object obj) => obj is Length other ? CompareTo(other) : 0;
        public int CompareTo(Length other) => _raw.CompareTo(other._raw);
        public bool Equals(Length other) => _raw.Equals(other._raw);
        public override bool Equals(object obj) => obj is Length other && Equals(other);
        public string ToString(string format, IFormatProvider formatProvider) => $"{_raw.ToString(format, formatProvider)}m";
                
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length operator+(Length a, Length b) => new(a._raw + b._raw);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length operator-(Length a, Length b) => new(a._raw - b._raw);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length operator*(Length a, float b) => new(a._raw - b);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length operator/(Length a, float b) => new(a._raw - b);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length operator-(Length a) => new(-a._raw);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Length a, Length b) => a._raw == b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Length a, Length b) => a._raw != b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(Length a, Length b) => a._raw > b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(Length a, Length b) => a._raw < b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(Length a, Length b) => a._raw >= b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(Length a, Length b) => a._raw <= b._raw;
    }
}

using System;
using System.Runtime.CompilerServices;

namespace FunFact.Measures
{
    public readonly struct Mass : IComparable, IComparable<Mass>, IEquatable<Mass>, IFormattable
    {
        private readonly float _raw;
        
        public float Grams
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _raw;
        }

        private Mass(float raw) => _raw = raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass FromGrams(float grams) => new(grams);

        public override int GetHashCode() => _raw.GetHashCode();
        public int CompareTo(object obj) => obj is Mass other ? CompareTo(other) : 0;
        public int CompareTo(Mass other) => _raw.CompareTo(other._raw);
        public bool Equals(Mass other) => _raw.Equals(other._raw);
        public override bool Equals(object obj) => obj is Mass other && Equals(other);
        public string ToString(string format, IFormatProvider formatProvider) => $"{_raw.ToString(format, formatProvider)}g";
                
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass operator+(Mass a, Mass b) => new(a._raw + b._raw);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass operator-(Mass a, Mass b) => new(a._raw - b._raw);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass operator*(Mass a, float b) => new(a._raw - b);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass operator/(Mass a, float b) => new(a._raw - b);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass operator-(Mass a) => new(-a._raw);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Mass a, Mass b) => a._raw == b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Mass a, Mass b) => a._raw != b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(Mass a, Mass b) => a._raw > b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(Mass a, Mass b) => a._raw < b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(Mass a, Mass b) => a._raw >= b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(Mass a, Mass b) => a._raw <= b._raw;
    }
}

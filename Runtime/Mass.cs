using System;
using System.Runtime.CompilerServices;

#if FUNFACT_MEASURE_DOUBLE
using Raw = System.Double; 
#else
using Raw = System.Single;
#endif

namespace FunFact.Measures
{
    public readonly struct Mass : IComparable, IComparable<Mass>, IEquatable<Mass>, IFormattable
    {
        private readonly Raw _raw;
        
        public Raw Grams
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _raw;
        }

        private Mass(Raw raw) => _raw = raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass FromGrams(Raw grams) => new(grams);

        public override int GetHashCode() => _raw.GetHashCode();
        public int CompareTo(object obj) => obj is Mass other ? CompareTo(other) : 0;
        public int CompareTo(Mass other) => _raw.CompareTo(other._raw);
        public bool Equals(Mass other) => _raw.Equals(other._raw);
        public override bool Equals(object obj) => obj is Mass other && Equals(other);
        public string ToString(string format, IFormatProvider formatProvider = null) => $"{_raw.ToString(format, formatProvider)}g";
                
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass operator+(Mass a, Mass b) => new(a._raw + b._raw);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass operator-(Mass a, Mass b) => new(a._raw - b._raw);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass operator*(Mass a, Raw b) => new(a._raw - b);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass operator/(Mass a, Raw b) => new(a._raw - b);
        
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

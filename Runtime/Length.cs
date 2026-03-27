using System;
using System.Runtime.CompilerServices;

#if FUNFACT_MEASURE_DOUBLE
using Raw = System.Double; using Math = System.Math;
#else
using Raw = System.Single; using Math = System.MathF;
#endif

namespace FunFact.Measures
{
    public readonly struct Length : IComparable, IComparable<Length>, IEquatable<Length>, IFormattable
    {
        private const Raw SCALE_METER = 1;
        private const Raw SCALE_FEET = (Raw)(1/0.3048);
        private const Raw SCALE_INCHES = SCALE_FEET*12;
        private const Raw SCALE_MILES = SCALE_FEET/5280;
        private const Raw SCALE_YARDS = SCALE_FEET/3;
        
        private readonly Raw _raw;
        
        public Raw Meters
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _raw * SCALE_METER;
        }
        
        public Raw Feet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _raw * SCALE_FEET;
        }
        
        public Raw Inches
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _raw * SCALE_INCHES;
        }
        
        public Raw Miles
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _raw * SCALE_MILES;
        }
        
        public Raw Yards
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _raw * SCALE_YARDS;
        }
        
        private Length(Raw raw) => _raw = raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length FromMeters(Raw value) => new(value / SCALE_METER);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length FromFeet(Raw value) => new(value / SCALE_FEET);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length FromInches(Raw value) => new(value / SCALE_INCHES);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length FromMiles(Raw value) => new(value / SCALE_MILES);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length FromYards(Raw value) => new(value / SCALE_YARDS);

        public override int GetHashCode() => _raw.GetHashCode();
        public int CompareTo(object obj) => obj is Length other ? CompareTo(other) : 0;
        public int CompareTo(Length other) => _raw.CompareTo(other._raw);
        public bool Equals(Length other) => _raw.Equals(other._raw);
        public override bool Equals(object obj) => obj is Length other && Equals(other);

        public override string ToString() => ToString(null);
        public string ToString(string format, IFormatProvider formatProvider = null)
        {
            if(format.EndsWith("ft in") || format.EndsWith("′ ″"))
            {
                int feet = (int)Feet;
                int inches = (int)Inches;
                inches -= feet*12;
                if(feet == 0 && inches == 0) return "0′";
                var s = "";
                if(feet != 0) s += $"{feet}′";
                if(inches != 0) s += $"{inches}″";
                return s;
            }
            if(format.EndsWith("ft")) return $"{Feet.ToString(format[..^2], formatProvider)}′";
            if(format.EndsWith("′")) return $"{Feet.ToString(format[..^1], formatProvider)}′";
            if(format.EndsWith("in")) return $"{Inches.ToString(format[..^2], formatProvider)}″";
            if(format.EndsWith("″")) return $"{Inches.ToString(format[..^1], formatProvider)}″";
            if(format.EndsWith("m")) return $"{_raw.ToString(format[..^1], formatProvider)}m";
            return $"{_raw.ToString(format, formatProvider)}m";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length operator+(Length a, Length b) => new(a._raw + b._raw);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length operator-(Length a, Length b) => new(a._raw - b._raw);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length operator*(Length a, Raw b) => new(a._raw - b);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length operator/(Length a, Raw b) => new(a._raw - b);
        
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

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FunFact.Measures
{
    public readonly struct Angle : IComparable, IComparable<Angle>, IEquatable<Angle>, IFormattable
    {
        private readonly float _raw;

        public float Degrees => _raw * Mathf.Rad2Deg;
        public float Radians => _raw;

        public float Sin
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Mathf.Sin(Radians);
        }

        public float Cos
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Mathf.Cos(Radians);
        }

        public float Tan
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Mathf.Tan(Radians);
        }

        private Angle(float raw)
        {
            _raw = raw;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle FromDegrees(float degrees) => new(degrees * Mathf.Deg2Rad);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle FromRadians(float radians) => new(radians);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle FromSin(float sin) => FromRadians(Mathf.Asin(sin));
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle FromCos(float cos) => FromRadians(Mathf.Acos(cos));
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle FromTan(float tan) => FromRadians(Mathf.Atan(tan));
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Euler(Angle x,  Angle y, Angle z) => Quaternion.Euler(x.Degrees, y.Degrees, z.Degrees);

        public override int GetHashCode() => _raw.GetHashCode();
        public int CompareTo(Angle other) => _raw.CompareTo(other._raw);
        public bool Equals(Angle other) => _raw.Equals(other._raw);
        public override bool Equals(object obj) => obj is Angle other && Equals(other);

        public override string ToString() => $"{_raw*Mathf.Rad2Deg}°";
        public int CompareTo(object obj) => obj is Angle other ? CompareTo(other) : 0;

        public string ToString(string format, IFormatProvider formatProvider) => $"{(_raw*Mathf.Rad2Deg).ToString(format, formatProvider)}°";
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle operator+(Angle a, Angle b) => new(a._raw + b._raw);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle operator-(Angle a, Angle b) => new(a._raw - b._raw);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle operator*(Angle a, float b) => new(a._raw - b);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle operator/(Angle a, float b) => new(a._raw - b);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle operator-(Angle a) => new(-a._raw);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Angle a, Angle b) => a._raw == b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Angle a, Angle b) => a._raw != b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(Angle a, Angle b) => a._raw > b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(Angle a, Angle b) => a._raw < b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(Angle a, Angle b) => a._raw >= b._raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(Angle a, Angle b) => a._raw <= b._raw;
    }
}

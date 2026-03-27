using System;
using System.Runtime.CompilerServices;
using UnityEngine;

#if USE_MATHEMATICS
using Unity.Mathematics;
#endif

#if FUNFACT_MEASURE_DOUBLE
using Raw = System.Double; 
using Math = System.Math;
#else
using Raw = System.Single;
using Math = UnityEngine.Mathf;
#endif

namespace FunFact.Measures
{
    public readonly struct Angle : IComparable, IComparable<Angle>, IEquatable<Angle>, IFormattable
    {
        private readonly Raw _raw;
        
#if USE_MATHEMATICS
        private const Raw SCALE_DEGREES = (Raw)(180/math.PI_DBL);
#else
        private const Raw SCALE_DEGREES = 180/Math.PI;
#endif

        public Raw Degrees
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _raw * SCALE_DEGREES;
        }

        public Raw Radians
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _raw;
        }

        public Raw Sin
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_MATHEMATICS
            get => math.sin(Radians);
#else
            get => Math.Sin(Radians);
#endif
        }

        public Raw Cos
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_MATHEMATICS
            get => math.cos(Radians);
#else
            get => Math.Cos(Radians);
#endif
        }

        public Raw Tan
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_MATHEMATICS
            get => math.tan(Radians);
#else
            get => Math.Tan(Radians);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private Angle(Raw raw) => _raw = raw;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle FromDegrees(Raw degrees) => new(degrees / SCALE_DEGREES);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle FromRadians(Raw radians) => new(radians);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_MATHEMATICS
        public static Angle FromSin(Raw sin) => FromRadians(math.asin(sin));
#else
        public static Angle FromSin(Raw sin) => FromRadians(Math.Asin(sin));
#endif
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_MATHEMATICS
        public static Angle FromCos(Raw cos) => FromRadians(math.acos(cos));
#else
        public static Angle FromCos(Raw cos) => FromRadians(Math.Acos(cos));
#endif
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_MATHEMATICS
        public static Angle FromTan(Raw tan) => FromRadians(math.atan(tan));
#else
        public static Angle FromTan(Raw tan) => FromRadians(Math.Atan(tan));
#endif
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Euler(Angle x,  Angle y, Angle z) => Quaternion.Euler((float)x.Degrees, (float)y.Degrees, (float)z.Degrees);

        public override int GetHashCode() => _raw.GetHashCode();
        public int CompareTo(Angle other) => _raw.CompareTo(other._raw);
        public bool Equals(Angle other) => _raw.Equals(other._raw);
        public override bool Equals(object obj) => obj is Angle other && Equals(other);

        public int CompareTo(object obj) => obj is Angle other ? CompareTo(other) : 0;

        public override string ToString() => ToString(null);
        public string ToString(string format, IFormatProvider formatProvider = null) => $"{(_raw*SCALE_DEGREES).ToString(format, formatProvider)}°";
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle operator+(Angle a, Angle b) => new(a._raw + b._raw);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle operator-(Angle a, Angle b) => new(a._raw - b._raw);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle operator*(Angle a, Raw b) => new(a._raw - b);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle operator/(Angle a, Raw b) => new(a._raw - b);
        
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

using System.Runtime.CompilerServices;

#if FUNFACT_MEASURE_DOUBLE
using Raw = System.Double; 
#else
using Raw = System.Single;
#endif

namespace FunFact.Measures
{
    public static class AngleExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Degrees(this double value) => Angle.FromDegrees((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Degrees(this float value) => Angle.FromDegrees((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Degrees(this long value) => Angle.FromDegrees((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Degrees(this int value) => Angle.FromDegrees((Raw)value);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Radians(this double value) => Angle.FromRadians((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Radians(this float value) => Angle.FromRadians((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Radians(this long value) => Angle.FromRadians((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Radians(this int value) => Angle.FromRadians((Raw)value);
    }
}
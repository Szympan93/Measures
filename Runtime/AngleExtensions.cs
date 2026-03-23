using System.Runtime.CompilerServices;

namespace FunFact.Measures
{
    public static class AngleExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Degrees(this double value) => Angle.FromDegrees((float)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Degrees(this float value) => Angle.FromDegrees(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Degrees(this long value) => Angle.FromDegrees(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Degrees(this int value) => Angle.FromDegrees(value);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Radians(this double value) => Angle.FromRadians((float)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Radians(this float value) => Angle.FromRadians(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Radians(this long value) => Angle.FromRadians(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Angle Radians(this int value) => Angle.FromRadians(value);
    }
}
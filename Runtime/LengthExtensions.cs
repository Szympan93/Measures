using System.Runtime.CompilerServices;

#if FUNFACT_MEASURE_DOUBLE
using Raw = System.Double; 
#else
using Raw = System.Single;
#endif

namespace FunFact.Measures
{
    public static class LengthExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Meters(this double value) => Length.FromMeters((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Meters(this float value) => Length.FromMeters((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Meters(this long value) => Length.FromMeters((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Meters(this int value) => Length.FromMeters((Raw)value);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Feet(this double value) => Length.FromFeet((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Feet(this float value) => Length.FromFeet((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Feet(this long value) => Length.FromFeet((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Feet(this int value) => Length.FromFeet((Raw)value);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Inches(this double value) => Length.FromInches((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Inches(this float value) => Length.FromInches((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Inches(this long value) => Length.FromInches((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Inches(this int value) => Length.FromInches((Raw)value);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Miles(this double value) => Length.FromMiles((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Miles(this float value) => Length.FromMiles((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Miles(this long value) => Length.FromMiles((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Miles(this int value) => Length.FromMiles((Raw)value);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Yards(this double value) => Length.FromYards((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Yards(this float value) => Length.FromYards((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Yards(this long value) => Length.FromYards((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Yards(this int value) => Length.FromYards((Raw)value);
    }
}
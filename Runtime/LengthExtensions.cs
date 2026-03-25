using System.Runtime.CompilerServices;

namespace FunFact.Measures
{
    public static class LengthExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Meters(this double value) => Length.FromMeters((float)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Meters(this float value) => Length.FromMeters(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Meters(this long value) => Length.FromMeters(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Meters(this int value) => Length.FromMeters(value);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Feet(this double value) => Length.FromFeet((float)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Feet(this float value) => Length.FromFeet(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Feet(this long value) => Length.FromFeet(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Feet(this int value) => Length.FromFeet(value);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Inches(this double value) => Length.FromInches((float)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Inches(this float value) => Length.FromInches(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Inches(this long value) => Length.FromInches(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Inches(this int value) => Length.FromInches(value);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Miles(this double value) => Length.FromMiles((float)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Miles(this float value) => Length.FromMiles(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Miles(this long value) => Length.FromMiles(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Miles(this int value) => Length.FromMiles(value);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Yards(this double value) => Length.FromYards((float)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Yards(this float value) => Length.FromYards(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Yards(this long value) => Length.FromYards(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Length Yards(this int value) => Length.FromYards(value);
    }
}
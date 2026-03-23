using System.Runtime.CompilerServices;

namespace FunFact.Measures
{
    public static class MassExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass Grams(this double value) => Mass.FromGrams((float)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass Grams(this float value) => Mass.FromGrams(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass Grams(this long value) => Mass.FromGrams(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass Grams(this int value) => Mass.FromGrams(value);
    }
    
    public static class UnitExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Kilo(this double value) => value * 1_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Kilo(this float value) => value * 1_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Kilo(this long value) => value * 1_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Kilo(this int value) => value * 1_000;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Mega(this double value) => value * 1_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Mega(this float value) => value * 1_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Mega(this long value) => value * 1_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Mega(this int value) => value * 1_000_000;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Giga(this double value) => value * 1_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Giga(this float value) => value * 1_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Giga(this long value) => value * 1_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Giga(this int value) => value * 1_000_000_000;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Tera(this double value) => value * 1_000_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Tera(this float value) => value * 1_000_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Tera(this long value) => value * 1_000_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Tera(this int value) => value * 1_000_000_000_000;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Peta(this double value) => value * 1_000_000_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Peta(this float value) => value * 1_000_000_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Peta(this long value) => value * 1_000_000_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Peta(this int value) => value * 1_000_000_000_000_000;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Deci(this double value) => value / 10;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Deci(this float value) => value / 10;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Deci(this long value) => value / 10;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Deci(this int value) => value / 10;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Centi(this double value) => value / 100;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Centi(this float value) => value / 100;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Centi(this long value) => value / 100;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Centi(this int value) => value / 100;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Milli(this double value) => value / 1_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Milli(this float value) => value / 1_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Milli(this long value) => value / 1_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Milli(this int value) => value / 1_000;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Micro(this double value) => value / 1_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Micro(this float value) => value / 1_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Micro(this long value) => value / 1_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Micro(this int value) => value / 1_000_000;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Nano(this double value) => value / 1_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Nano(this float value) => value / 1_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Nano(this long value) => value / 1_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Nano(this int value) => value / 1_000_000_000;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Pico(this double value) => value / 1_000_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Pico(this float value) => value / 1_000_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Pico(this long value) => value / 1_000_000_000_000;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Femto(this double value) => value / 1_000_000_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Femto(this float value) => value / 1_000_000_000_000_000;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Femto(this long value) => value / 1_000_000_000_000_000;
    }
}
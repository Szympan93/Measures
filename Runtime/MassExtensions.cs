using System.Runtime.CompilerServices;

#if FUNFACT_MEASURE_DOUBLE
using Raw = System.Double; 
#else
using Raw = System.Single;
#endif

namespace FunFact.Measures
{
    public static class MassExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass Grams(this double value) => Mass.FromGrams((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass Grams(this float value) => Mass.FromGrams((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass Grams(this long value) => Mass.FromGrams((Raw)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Mass Grams(this int value) => Mass.FromGrams((Raw)value);
    }
}
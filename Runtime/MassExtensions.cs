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
}
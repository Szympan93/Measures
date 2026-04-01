using System.Runtime.CompilerServices;

#if FUNFACT_MEASURE_DOUBLE
using Raw = System.Double; 
#else
using Raw = System.Single;
#endif

namespace FunFact.Measures
{
    public static class UnitExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Raw As(this double value, SiPrefix prefix) => (Raw)value * prefix.GetData().Scale;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Raw As(this float value, SiPrefix prefix) => (Raw)value * prefix.GetData().Scale;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Raw As(this long value, SiPrefix prefix) => (Raw)value * prefix.GetData().Scale;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Raw As(this int value, SiPrefix prefix) => (Raw)value * prefix.GetData().Scale;
    }
}
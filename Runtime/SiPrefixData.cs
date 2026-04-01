
using System.Collections.Generic;
#if FUNFACT_MEASURE_DOUBLE
using Raw = System.Double; 
#else
using Raw = System.Single;
#endif

namespace FunFact.Measures
{
    public readonly struct SiPrefixData
    {
        public readonly SiPrefix Prefix;
        public readonly Raw Scale;
        public readonly string Symbol;

        private SiPrefixData(SiPrefix prefix, Raw scale, string symbol)
        {
            Prefix = prefix;
            Scale = scale;
            Symbol = symbol;
        }

        public static readonly SiPrefixData Quecto = new(SiPrefix.Quecto, (Raw)1e-30, "q");
        public static readonly SiPrefixData Ronto = new(SiPrefix.Ronto, (Raw)1e-27, "r");
        public static readonly SiPrefixData Yocto = new(SiPrefix.Yocto, (Raw)1e-24, "y");
        public static readonly SiPrefixData Zepto = new(SiPrefix.Zepto, (Raw)1e-21, "z");
        public static readonly SiPrefixData Atto = new(SiPrefix.Atto, (Raw)1e-18, "a");
        public static readonly SiPrefixData Femto = new(SiPrefix.Femto, (Raw)1e-15, "f");
        public static readonly SiPrefixData Pico = new(SiPrefix.Pico, (Raw)1e-12, "p");
        public static readonly SiPrefixData Nano = new(SiPrefix.Nano, (Raw)1e-9, "n");
        public static readonly SiPrefixData Micro = new(SiPrefix.Micro, (Raw)1e-6, "μ");
        public static readonly SiPrefixData Milli = new(SiPrefix.Milli, (Raw)1e-3, "m");
        public static readonly SiPrefixData Centi = new(SiPrefix.Centi, (Raw)1e-2, "c");
        public static readonly SiPrefixData Deci = new(SiPrefix.Deci, (Raw)1e-1, "d");
        public static readonly SiPrefixData None = new(SiPrefix.None, (Raw)1e0, "");
        public static readonly SiPrefixData Deca = new(SiPrefix.Deca, (Raw)1e1, "da");
        public static readonly SiPrefixData Hekto = new(SiPrefix.Hekto, (Raw)1e2, "h");
        public static readonly SiPrefixData Kilo = new(SiPrefix.Kilo, (Raw)1e3, "k");
        public static readonly SiPrefixData Mega = new(SiPrefix.Mega, (Raw)1e6, "M");
        public static readonly SiPrefixData Giga = new(SiPrefix.Giga, (Raw)1e9, "G");
        public static readonly SiPrefixData Tera = new(SiPrefix.Tera, (Raw)1e12, "T");
        public static readonly SiPrefixData Peta = new(SiPrefix.Peta, (Raw)1e15, "P");
        public static readonly SiPrefixData Exa = new(SiPrefix.Exa, (Raw)1e18, "E");
        public static readonly SiPrefixData Zetta = new(SiPrefix.Zetta, (Raw)1e21, "Z");
        public static readonly SiPrefixData Yotta = new(SiPrefix.Yotta, (Raw)1e24, "Y");
        public static readonly SiPrefixData Ronna = new(SiPrefix.Ronna, (Raw)1e27, "R");
        public static readonly SiPrefixData Quetta = new(SiPrefix.Quetta, (Raw)1e30, "Q");

        public static IEnumerable<SiPrefixData> All
        {
            get
            {
                yield return Quecto;
                yield return Ronto;
                yield return Yocto;
                yield return Zepto;
                yield return Atto;
                yield return Femto;
                yield return Pico;
                yield return Nano;
                yield return Micro;
                yield return Milli;
                yield return Centi;
                yield return Deci;
                yield return Deca;
                yield return Hekto;
                yield return Kilo;
                yield return Mega;
                yield return Giga;
                yield return Tera;
                yield return Peta;
                yield return Exa;
                yield return Zetta;
                yield return Yotta;
                yield return Ronna;
                yield return Quetta;
            }
        }
    }
}
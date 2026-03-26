namespace FunFact.Measures
{
    public readonly struct SiPrefixData
    {
        public readonly SiPrefix Prefix;
        public readonly float Scale;
        public readonly string Symbol;

        private SiPrefixData(SiPrefix prefix, float scale, string symbol)
        {
            Prefix = prefix;
            Scale = scale;
            Symbol = symbol;
        }

        public static readonly SiPrefixData Femto = new(SiPrefix.Femto, 1e-15f, "f");
        public static readonly SiPrefixData Pico = new(SiPrefix.Pico, 1e-12f, "p");
        public static readonly SiPrefixData Nano = new(SiPrefix.Nano, 1e-9f, "n");
        public static readonly SiPrefixData Micro = new(SiPrefix.Micro, 1e-6f, "μ");
        public static readonly SiPrefixData Milli = new(SiPrefix.Milli, 1e-3f, "m");
        public static readonly SiPrefixData Centi = new(SiPrefix.Centi, 1e-2f, "c");
        public static readonly SiPrefixData Deci = new(SiPrefix.Deci, 1e-1f, "d");
        public static readonly SiPrefixData None = new(SiPrefix.None, 1e0f, "");
        public static readonly SiPrefixData Deca = new(SiPrefix.Deca, 1e1f, "da");
        public static readonly SiPrefixData Hekto = new(SiPrefix.Hekto, 1e2f, "h");
        public static readonly SiPrefixData Kilo = new(SiPrefix.Kilo, 1e3f, "k");
        public static readonly SiPrefixData Mega = new(SiPrefix.Mega, 1e6f, "M");
        public static readonly SiPrefixData Giga = new(SiPrefix.Giga, 1e9f, "G");
        public static readonly SiPrefixData Tera = new(SiPrefix.Tera, 1e12f, "T");
        public static readonly SiPrefixData Peta = new(SiPrefix.Peta, 1e15f, "P");
    }
}
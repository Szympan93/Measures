namespace FunFact.Measures
{
    public static class SiPrefixExtensions
    {
        public static SiPrefixData GetData(this SiPrefix prefix) => prefix switch
        {
            SiPrefix.Quecto => SiPrefixData.Quecto,
            SiPrefix.Ronto => SiPrefixData.Ronto,
            SiPrefix.Yocto => SiPrefixData.Yocto,
            SiPrefix.Zepto => SiPrefixData.Zepto,
            SiPrefix.Atto => SiPrefixData.Atto,
            SiPrefix.Femto => SiPrefixData.Femto,
            SiPrefix.Pico => SiPrefixData.Pico,
            SiPrefix.Nano => SiPrefixData.Nano,
            SiPrefix.Micro => SiPrefixData.Micro,
            SiPrefix.Milli => SiPrefixData.Milli,
            SiPrefix.Centi => SiPrefixData.Centi,
            SiPrefix.Deci => SiPrefixData.Deci,
            SiPrefix.None => SiPrefixData.None,
            SiPrefix.Deca => SiPrefixData.Deca,
            SiPrefix.Hekto => SiPrefixData.Hekto,
            SiPrefix.Kilo => SiPrefixData.Kilo,
            SiPrefix.Mega => SiPrefixData.Mega,
            SiPrefix.Giga => SiPrefixData.Giga,
            SiPrefix.Tera => SiPrefixData.Tera,
            SiPrefix.Peta => SiPrefixData.Peta,
            SiPrefix.Exa => SiPrefixData.Exa,
            SiPrefix.Zetta => SiPrefixData.Zetta,
            SiPrefix.Yotta => SiPrefixData.Yotta,
            SiPrefix.Ronna => SiPrefixData.Ronna,
            SiPrefix.Quetta => SiPrefixData.Quetta,
            _ => SiPrefixData.None,
        };
    }
}
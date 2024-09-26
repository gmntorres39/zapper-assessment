using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapper
{
    public class UserSettings
    {
        public static bool IsFeatureEnabled(string settings, int setting)
        {
            // Validate input
            if (settings.Length != 8 || !IsBinaryString(settings))
            {
                throw new ArgumentException("Settings must be an 8-character binary string.");
            }

            if (setting < 0 || setting >= 8)
            {
                throw new ArgumentOutOfRangeException("Setting must be between 0 and 7.");
            }

            // Check if the feature is enabled (1) or disabled (0)
            return settings[setting] == '1';
        }

        private static bool IsBinaryString(string str)
        {
            foreach (char c in str)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
    }
}

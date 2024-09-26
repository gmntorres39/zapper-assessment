using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapper
{
    public class UserSettingsFile
    {
        public static void WriteSettingsToFile(string filename, string settings)
        {
            // Ensure settings are valid
            if (settings.Length != 8 || !IsBinaryString(settings))
            {
                throw new ArgumentException("Settings must be an 8-character binary string.");
            }

            File.WriteAllText(filename, settings);
        }

        public static string ReadSettingsFromFile(string filename)
        {
            string settings = File.ReadAllText(filename).Trim();
            if (settings.Length != 8 || !IsBinaryString(settings))
            {
                throw new ArgumentException("Invalid settings format in file.");
            }
            return settings;
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

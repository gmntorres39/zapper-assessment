using Zapper;

public class Program
{
    public static void Main()
    {
        string settings = "00000010";

        // Check if a feature is enabled
        Console.WriteLine(UserSettings.IsFeatureEnabled(settings, 7)); // Output: True
        Console.WriteLine(UserSettings.IsFeatureEnabled(settings, 3)); // Output: False

        // Write settings to a file
        UserSettingsFile.WriteSettingsToFile("user_settings.txt", settings);

        // Read settings from the file
        string readSettings = UserSettingsFile.ReadSettingsFromFile("user_settings.txt");
        Console.WriteLine(readSettings); // Output: 00000010

        // Check if a feature is enabled after reading
        Console.WriteLine(UserSettings.IsFeatureEnabled(readSettings, 7)); // Output: True
    }
}
using Operose.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Operose
{
    internal static class SettingManager
    {
        private const string ApplicationConfigFilename = "ApplicationConfig.json";

        private static string ApplicationConfigFilePath
        {
            get
            {
                return Path.Combine(Program.PersonalFolder, ApplicationConfigFilename);
            }
        }


        private static ApplicationConfig Settings { get => Program.Settings; set => Program.Settings = value; }
        private const int SettingsSaveFailWarningLimit = 3;
        private static int settingsSaveFailWarningCount;

        public static string BackupFolder => Path.Combine(Program.PersonalFolder, "Backup");

        public static void LoadInitialSettings()
        {
            LoadApplicationConfig();
        }

        private static void CreateApplicationConfig()
        {
            try
            {
                if (!File.Exists(ApplicationConfigFilePath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(ApplicationConfigFilePath));
                    File.Create(ApplicationConfigFilePath).Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new FileNotFoundException($"The provided {nameof(ApplicationConfigFilePath)} was invalid.", ex);
            }
        }

        public static void SaveAllSettings()
        {
            if (Settings != null) Settings.Save(ApplicationConfigFilePath);

        }

        public static void SaveApplicationConfigAsync()
        {
            if (Settings != null) Settings.SaveAsync(ApplicationConfigFilePath);
        }

        public static void SaveAllSettingsAsync()
        {
            SaveApplicationConfigAsync();
        }

        private static void LoadApplicationConfig()
        {
            Settings = ApplicationConfig.Load(ApplicationConfigFilePath, BackupFolder);
            Settings.CreateBackup = true;
            Settings.SettingsSaveFailed += Settings_SettingsSaveFailed;
        }

        private static void Settings_SettingsSaveFailed(Exception e)
        {
            if (settingsSaveFailWarningCount == SettingsSaveFailWarningLimit) return;

            string message;

            if (e is UnauthorizedAccessException || e is FileNotFoundException)
            {
                message = Resources.YourAntiVirusSoftwareOrTheControlledFolderAccessFeatureInWindows10CouldBeBlockingOperose;
            }
            else
            {
                message = e.Message;
            }

            MessageBox.Show(message, "Operose - " + Resources.FailedToSaveSettings);

            settingsSaveFailWarningCount++;
        }

    }
}

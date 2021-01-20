using Operose.HelpersLib;

namespace Operose
{
    internal static class EnvironmentManager
    {
        public static DatabaseEnv CurrentEnvironment { get; set; }
        public static string CurrentEnvironmentString { get; set; }
        public static string CurrentConnectionString { get; set; }

        public static DatabaseEnv GetEnv()
        {
            return GetEnvFromString(CurrentEnvironmentString);
        }

        public static DatabaseEnv GetEnvFromString(string currentEnvironmentString)
        {
            switch (currentEnvironmentString)
            {
                case "Production":
                    return DatabaseEnv.Production;

                case "Development":
                    return DatabaseEnv.Development;

                case "Test":
                    return DatabaseEnv.Test;
            }
            return DatabaseEnv.Production;
        }

        public static string GetConnection(DatabaseEnv env)
        {
            switch (env)
            {
                case DatabaseEnv.Production:
                    return Properties.Settings.Default.ProdCon;

                case DatabaseEnv.Development:
                    return Properties.Settings.Default.DevCon;

                case DatabaseEnv.Test:
                    return Properties.Settings.Default.TestCon;
            }
            return null;
        }
    }
}
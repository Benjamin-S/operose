using Operose.HelpersLib;
using Operose.ServicesLib;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Operose
{
    internal static class Program
    {
        public const string Name = "Operose";

        public static string VersionText
        {
            get
            {
                StringBuilder sbVersionText = new StringBuilder();
                Version version = Version.Parse(Application.ProductVersion);
                sbVersionText.Append(version.Major + "." + version.Minor);
                if (version.Build > 0) sbVersionText.Append("." + version.Build);
                if (version.Revision > 0) sbVersionText.Append("." + version.Revision);
                return sbVersionText.ToString();
            }
        }

        public static string Title => $"{Name} {VersionText}";

        public static string ConnectionString;
        public static DatabaseEnv currentEnvironment;

        internal static MainForm MainForm { get; private set; }
        internal static StuckBatchesForm StuckBatchesForm { get; set; }

        internal static Stopwatch StartTimer { get; private set; }

        internal static DatabaseService databaseService = new DatabaseService();

        internal static ApplicationConfig Settings { get; set; }

        #region Paths
        private static readonly string DefaultPersonalFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Name);
        #endregion

        [STAThread]
        static void Main(string[] args)
        {
            // Allow Visual Studio to break on exceptions in Debug builds
#if !DEBUG
            // Add the event handler for handling UI thread exceptions to the event
            Application.ThreadException += Application_ThreadException;

            // Set the unhandled exception mode to force all Windows Forms errors to go through our handler
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
#endif

            StartTimer = Stopwatch.StartNew();

            InitialiseDefaults();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DebugHelper.WriteLine("Operose starting.");
            DebugHelper.WriteLine("Version: " + VersionText);
            //DebugHelper.WriteLine("Build: " + Build);
            DebugHelper.WriteLine("Command line: " + Environment.CommandLine);


            SettingManager.LoadInitialSettings();


            DebugHelper.WriteLine("MainForm init started.");
            MainForm = new MainForm();
            DebugHelper.WriteLine("Mainform init finished.");

            Application.Run(MainForm);

            CloseSequence();
        }

        static void InitialiseDefaults()
        {
            currentEnvironment = DatabaseEnv.Production;
            ConnectionString = Properties.Settings.Default.ProdCon;
        }

        public static void CloseSequence()
        {
            DebugHelper.WriteLine("Operose closing.");
            SettingManager.SaveAllSettings();
        }

        public static string PersonalFolder
        {
            get
            {
                return DefaultPersonalFolder;
            }
        }
    }
}

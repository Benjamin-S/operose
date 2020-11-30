using Operose.HelpersLib;
using Operose.ServicesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Operose
{
    internal static class Program
    {
        public const string Name = "Operose";
        public static string ConnectionString;
        

        internal enum Environment
        {
            PRODUCTION,
            DEVELOPMENT,
            TEST
        }

        public static Environment currentEnvironment;

        internal static MainForm MainForm { get; private set; }

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DebugHelper.WriteLine("MainForm init started.");
            MainForm = new MainForm();
            DebugHelper.WriteLine("Mainform init finished.");

            Application.Run(MainForm);
        }

        static void InitialiseDefaults()
        {
            currentEnvironment = Environment.PRODUCTION;
            ConnectionString = Properties.Settings.Default.ProdCon;
        }
    }
}

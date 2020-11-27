using Operose.HelpersLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operose
{
    internal static class Program
    {
        public const string Name = "Operose";

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
    }
}

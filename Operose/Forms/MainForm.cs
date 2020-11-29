using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Operose
{
    public partial class MainForm : Form
    {
        // Constants because resource files aren't necessary (we aren't translating this program).
        public const string ACTION_HOME = "Home";
        public const string ACTION_BLOCK = "Blocking Sessions";
        public const string ACTION_BATCHES = "Stuck Batches";
        readonly List<string> functions = new List<string>()
        {
            ACTION_HOME,
            ACTION_BLOCK,
            ACTION_BATCHES
        };

        // Controls that will be used throughout
        BaseControl mainControl = new MainControl(ACTION_HOME);
        BlockingSessionsControl blockingSessionsControl = new BlockingSessionsControl(ACTION_BLOCK);
        BaseControl stuckBatchesControl = new BaseControl(ACTION_BATCHES);

        public Control CurrentControl { get; set; }

        public MainForm()
        {
            InitializeControls();
        }

        private void InitializeControls()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            // Components need to be loaded before any changes can be done via code.
            InitializeComponent();
            foreach (var function in functions)
            {
                var objName = "tsb" + function.Replace(" ", "");
                tsMain.Items.Add(new ToolStripButton()
                {
                    Image = ((System.Drawing.Image)(resources.GetObject("tsbHome.Image"))),
                    ImageAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    ImageTransparentColor = System.Drawing.Color.Magenta,
                    Name = objName,
                    Size = new System.Drawing.Size(163, 20),
                    Text = function
                });
            }
            AddControlToForm(pMain, mainControl);
            UpdateEnvironmentLabel(Program.currentEnvironment);
        }

        private void HandleEnvironmentChange(object sender, EventArgs e)
        {
            switch (sender.ToString())
            {
                case "Production":
                    Program.currentEnvironment = Program.Environment.PRODUCTION;
                    break;
                case "Development":
                    Program.currentEnvironment = Program.Environment.DEVELOPMENT;
                    break;
                case "Test":
                    Program.currentEnvironment = Program.Environment.TEST;
                    break;

            }
            UpdateEnvironmentLabel(Program.currentEnvironment);
        }

        private void UpdateEnvironmentLabel(Program.Environment env)
        {
            string envString = env.ToString();
            envString = envString[0] + envString.Substring(1).ToLower();
            tslbEnvironment.Text = envString;
        }

        private void AddControlToForm(Control parent, Control child)
        {
            parent.Controls.Remove(CurrentControl);
            parent.Controls.Add(child);
            CurrentControl = child;
        }

        private void HandleToolStripItemChange(object sender, ToolStripItemClickedEventArgs e)
        {
            //DebugHelper.WriteLine(e.ClickedItem.Text);
            //pMain.Controls.Remove(CurrentControl);
            //DebugHelper.WriteLine(CurrentControl.Text);
            switch (e.ClickedItem.Text)
            {
                case ACTION_BLOCK:
                    AddControlToForm(pMain, blockingSessionsControl);
                    break;
                case ACTION_BATCHES:
                    AddControlToForm(pMain, stuckBatchesControl);
                    break;
                default:
                    AddControlToForm(pMain, mainControl);
                    break;
            }
        }
    }
}

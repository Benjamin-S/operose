using Operose.HelpersLib;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operose
{
    public partial class MainForm : Form
    {
        public bool IsReady { get; private set; }

        public MainForm()
        {
            InitializeControls();
        }

        private void MainForm_HandleCreated(object sender, EventArgs e)
        {
            NativeMethods.UseImmersiveDarkMode(Handle, OperoseResources.IsDarkTheme);
            DebugHelper.WriteLine("Startup time: {0} ms", Program.StartTimer.ElapsedMilliseconds);
            DebugHelper.WriteLine("Is Handle bool = {0}", IsHandleCreated);
        }

        // Constants because resource files aren't necessary (we aren't translating this program).
        public const string ACTION_HOME = "Home";

        public const string ACTION_BLOCK = "Blocking Sessions";
        public const string ACTION_CLEAR_INACTIVE = "Clear Inactive Users";
        public const string ACTION_STUCK_BATCHES = "Stuck Batches";
        public const string ACTION_BATCHES = "Reset Batches";
        public const string ACTION_ECOMMX_FIX = "Fix eCommX Batch";
        public const string ACTION_PULSE_COPY_ACCESS = "Copy Pulse User Access";

        public const string ACTION_ABOUT = "About...";

        public const string HORIZONTAL_RULE = "";

        private readonly List<string> functions = new List<string>()
        {
            ACTION_HOME,
            ACTION_BLOCK,
            ACTION_CLEAR_INACTIVE,
            ACTION_STUCK_BATCHES,
            ACTION_BATCHES,
            ACTION_ECOMMX_FIX,
            HORIZONTAL_RULE,
            ACTION_PULSE_COPY_ACCESS,
            HORIZONTAL_RULE,
            ACTION_ABOUT
        };

        // Controls that will be used throughout

        private BlockingSessionsForm blockingSessionsControl = new BlockingSessionsForm();
        private StuckBatchesForm stuckBatchesControl = new StuckBatchesForm();
        private ResetBatchesForm resetBatchesForm = new ResetBatchesForm();

        private HomeForm HomeControl = new HomeForm();

        public Control CurrentControl { get; set; }
        public string CurrentControlString;

        private void InitializeControls()
        {
            // Components need to be loaded before any changes can be done via code.
            InitializeComponent();

            UpdateTheme();
            OperoseResources.ApplyTheme(this);

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            // Sets the window name
            Text = Program.Title;

            foreach (var function in functions)
            {
                if (function == HORIZONTAL_RULE)
                {
                    tsMain.Items.Add(new ToolStripSeparator());
                }
                else
                {
                    var objName = "tsb" + function.Replace(" ", "");
                    tsMain.Items.Add(new ToolStripButton()
                    {
                        Image = Properties.Resources.BSImage,
                        ImageAlign = System.Drawing.ContentAlignment.MiddleLeft,
                        ImageTransparentColor = System.Drawing.Color.Magenta,
                        Name = objName,
                        Size = new System.Drawing.Size(163, 20),
                        Text = function
                    });
                }
            }

            AddControlToForm(pMain, HomeControl, ACTION_HOME);
            UpdateEnvironmentLabel(EnvironmentManager.CurrentEnvironment);

            HandleCreated += MainForm_HandleCreated;
        }

        private void HandleEnvironmentChange(object sender, EventArgs e)
        {
            string selectedEnvironment = sender.ToString();

            EnvironmentManager.CurrentEnvironment = EnvironmentManager.GetEnvFromString(selectedEnvironment);

            #region Debugging Logs

            DebugHelper.WriteLine($"Selected Environment: {selectedEnvironment}");
            DebugHelper.WriteLine($"Environment Enum: {EnvironmentManager.GetEnvFromString(selectedEnvironment).ToString()}");
            DebugHelper.WriteLine($"Connection String: { EnvironmentManager.GetConnection(EnvironmentManager.CurrentEnvironment)}");

            #endregion Debugging Logs

            EnvironmentManager.CurrentConnectionString = EnvironmentManager.GetConnection(EnvironmentManager.CurrentEnvironment);

            UpdateEnvironmentLabel(EnvironmentManager.CurrentEnvironment);
            Program.Settings.LastEnvironment = EnvironmentManager.CurrentEnvironment;
        }

        private void UpdateEnvironmentLabel(DatabaseEnv env)
        {
            // TODO: Remove Capitalisation Code. Not needed now enum is lowercase
            string envString = env.ToString();
            envString = envString[0] + envString.Substring(1).ToLower();
            tslbEnvironment.Text = envString;
        }

        private void AddControlToForm(Control parent, Control child, string controlString)
        {
            SuspendLayout();
            parent.Controls.Remove(CurrentControl);
            parent.Controls.Add(child);
            CurrentControl = child;
            CurrentControlString = controlString;
            ResumeLayout();
        }

        private async Task Action_ClearInactiveUsers()
        {
            bool didSucceed = false;

            await Task.Run(() =>
            {
                didSucceed = Program.databaseService.ClearInactiveUsers(EnvironmentManager.CurrentConnectionString);
            });
            var message = didSucceed ? "was successful" : "was a failure";
            MessageBox.Show("Clear inactive users " + message);
        }

        private async void HandleToolStripItemChange(object sender, ToolStripItemClickedEventArgs e)
        {
            // Hacky way to prevent the same toolbar button triggering to add and remove the control
            if (e.ClickedItem.Text == CurrentControlString)
            {
                return;
            }
            switch (e.ClickedItem.Text)
            {
                case ACTION_BLOCK:
                    AddControlToForm(pMain, blockingSessionsControl, ACTION_BLOCK);
                    break;

                case ACTION_CLEAR_INACTIVE:
                    await Action_ClearInactiveUsers();
                    break;

                case ACTION_STUCK_BATCHES:
                    AddControlToForm(pMain, stuckBatchesControl, ACTION_STUCK_BATCHES);
                    break;

                case ACTION_BATCHES:
                    AddControlToForm(pMain, resetBatchesForm, ACTION_BATCHES);
                    break;

                case ACTION_ABOUT:
                    using (AboutForm about = new AboutForm())
                    {
                        about.ShowDialog(this);
                    }
                    break;

                default:
                    AddControlToForm(pMain, HomeControl, ACTION_HOME);
                    break;
            }
        }

        public void UpdateTheme()
        {
            if (Program.Settings.Themes == null || Program.Settings.Themes.Count == 0)
            {
                Program.Settings.Themes = OperoseTheme.GetDefaultThemes();
                Program.Settings.SelectedTheme = 0;
            }

            if (!Program.Settings.Themes.IsValidIndex(Program.Settings.SelectedTheme))
            {
                Program.Settings.SelectedTheme = 0;
            }

            OperoseResources.Theme = Program.Settings.Themes[Program.Settings.SelectedTheme];
            OperoseResources.UseCustomTheme = Program.Settings.UseCustomTheme;

            if (IsHandleCreated)
            {
                NativeMethods.UseImmersiveDarkMode(Handle, OperoseResources.IsDarkTheme);
            }

            if (OperoseResources.UseCustomTheme)
            {
                tsMain.Renderer = new ToolStripDarkRenderer();
                tsMain.DrawCustomBorder = false;
                pToolbars.BackColor = OperoseResources.Theme.BackgroundColor;
                tsEnvironment.Renderer = new ToolStripDarkRenderer();
                tsEnvironment.DrawCustomBorder = false;
                pMain.BackColor = OperoseResources.Theme.BackgroundColor;
                pMain.ForeColor = OperoseResources.Theme.TextColor;
            }
        }
    }
}
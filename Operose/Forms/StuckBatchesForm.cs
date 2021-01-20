using Operose.HelpersLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Operose
{
    public partial class StuckBatchesForm : UserControl
    {
        public StuckBatchesForm()
        {
            InitializeComponent();
            OperoseResources.ApplyCustomThemeToControl(this);
            Dock = DockStyle.Fill;
            base.DoubleBuffered = true;
            gbActivity.Paint += PaintGroupBox;
            gbDEX_SESSION.Paint += PaintGroupBox;
            gbDEX_LOCK.Paint += PaintGroupBox;
            gbSY00800.Paint += PaintGroupBox;
            gbSY00801.Paint += PaintGroupBox;
        }

        private void PaintGroupBox(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            e.Graphics.Clear(OperoseResources.Theme.BackgroundColor);
            e.Graphics.DrawString(box.Text, box.Font, new SolidBrush(OperoseResources.Theme.TextColor), 0, 0);
        }

        private void RunQueries()
        {
            SuspendLayout();
            GetActivity();
            GetSY00800();
            GetSY00801();
            GetDexLock();
            GetDexSession();
            ResumeLayout();
        }

        private void GetActivity()
        {
            dgvActivity.DataSource = Program.databaseService.ActivityQuery(EnvironmentManager.CurrentConnectionString);
        }

        private void GetSY00800()
        {
            dgvSY00800.DataSource = Program.databaseService.Sy00800Query(EnvironmentManager.CurrentConnectionString);
        }

        private void GetSY00801()
        {
            dgvSY00801.DataSource = Program.databaseService.Sy00801Query(EnvironmentManager.CurrentConnectionString);
        }

        private void GetDexLock()
        {
            dgvDEX_LOCK.DataSource = Program.databaseService.DexLockQuery(EnvironmentManager.CurrentConnectionString);
        }

        private void GetDexSession()
        {
            dgvDEX_SESSION.DataSource = Program.databaseService.DexSessionQuery(EnvironmentManager.CurrentConnectionString);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RunQueries();
        }
    }
}
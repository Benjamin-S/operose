using System;
using System.Windows.Forms;

namespace Operose
{
    public partial class StuckBatchesForm : UserControl
    {
        public StuckBatchesForm()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            base.DoubleBuffered = true;
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
            dgvActivity.DataSource = Program.databaseService.ActivityQuery(Program.ConnectionString);
        }

        private void GetSY00800()
        {
            dgvSY00800.DataSource = Program.databaseService.Sy00800Query(Program.ConnectionString);
        }

        private void GetSY00801()
        {
            dgvSY00801.DataSource = Program.databaseService.Sy00801Query(Program.ConnectionString);
        }

        private void GetDexLock()
        {
            dgvDEX_LOCK.DataSource = Program.databaseService.DexLockQuery(Program.ConnectionString);
        }

        private void GetDexSession()
        {
            dgvDEX_SESSION.DataSource = Program.databaseService.DexSessionQuery(Program.ConnectionString);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RunQueries();
        }
    }
}

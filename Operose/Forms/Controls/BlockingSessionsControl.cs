using Operose.HelpersLib;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operose
{
    public partial class BlockingSessionsControl : UserControl
    {
        public event EventHandler BlocksLoaded;
        private int _showOwnPID = 0;
        private int _summaryMode = 0;

        public BlockingSessionsControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            base.DoubleBuffered = true;
            dgvBlockingList.AllowUserToResizeColumns = true;
            dgvBlockingList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        public void Start()
        {
            Task.Run(() =>
            {

            }).ContinueInCurrentContext(() =>
            {
                OnBlocksLoaded();
            }
            );
        }

        protected void OnBlocksLoaded()
        {
            BlocksLoaded?.Invoke(this, EventArgs.Empty);
        }

        private void GetBlockingSessions()
        {
            string summaryColumns = "[dd%][session_id][login_name][block%][reads%][writes%][context%][physical%][query_plan][locks]";

            if (_summaryMode == 1)
            {
                DebugHelper.WriteLine("Summary Mode is on");
                SuspendLayout();
                dgvBlockingList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvBlockingList.AllowUserToResizeColumns = true;
                dgvBlockingList.DataSource = Program.databaseService.GetBlockingSessions(Program.ConnectionString, Show_own_spid: _showOwnPID, Output_column_list: summaryColumns);
                ResumeLayout();
            }
            else
            {
                SuspendLayout();
                dgvBlockingList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                dgvBlockingList.AllowUserToResizeColumns = false;
                dgvBlockingList.DataSource = Program.databaseService.GetBlockingSessions(Program.ConnectionString, Show_own_spid: _showOwnPID);
                ResumeLayout();
            }
        }

        private void BlockingSessionsControl_ParentChanged(object sender, System.EventArgs e)
        {
            if (Parent != null)
            {
                DebugHelper.WriteLine("Parent Added");
                DebugHelper.WriteLine(this.Parent.Name);
                DebugHelper.WriteLine(sender.ToString());
                GetBlockingSessions();
            }
            else
            {
                DebugHelper.WriteLine("Parent Removed");

            }
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            GetBlockingSessions();
        }

        private void SpCheckbox_HandleChanged(object sender, System.EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            _showOwnPID = checkBox.Checked ? 1 : 0;
        }

        private void SummaryCheckbox_HandleChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            _summaryMode = checkBox.Checked ? 1 : 0;
        }
    }
}

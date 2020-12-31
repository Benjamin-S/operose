using Operose.HelpersLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Operose
{
    public partial class ResetBatchesForm : UserControl
    {
        private List<BatchModel> batches = new List<BatchModel>();
        private List<BatchModel> selectedBatches = new List<BatchModel>();

        public ResetBatchesForm()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            DoubleBuffered = true;
            ChangeColors();
            tlpConfirmBatches.Visible = false;
            btnResetBatches.Enabled = false;
        }

        public void ChangeColors()
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchString = tbSearch.Text.Length > 0 ? tbSearch.Text + "%" : null;
            try
            {
                DataTable dataTable = Program.databaseService.GetBatches(Program.ConnectionString, searchString);
                batches = (from DataRow row in dataTable.AsEnumerable()
                           select new BatchModel
                           {
                               BatchSource = row["Batch Source"].ToString(),
                               BatchNumber = row["Batch Number"].ToString(),
                               MarkedToPost = int.Parse(row["Marked to Post"].ToString(), System.Globalization.NumberStyles.Integer),
                               BatchStatus = int.Parse(row["Batch Status"].ToString())
                           }).ToList();
                dgvBatches.DataSource = batches;
            }
            catch (Exception err)
            {
                DebugHelper.WriteException(err.ToString());
            }
        }

        private void btnResetBatches_Click(object sender, EventArgs e)
        {
            foreach (BatchModel batch in batches)
            {
                if (batch.Selected == true)
                {
                    selectedBatches.Add(batch);
                }
            }

            ConfirmBatches(selectedBatches);
        }

        private void ConfirmBatches(List<BatchModel> selectedBatches)
        {
            lvConfirmBatches.Columns.Add("Batch Number", 200);
            lvConfirmBatches.Columns.Add("Marked to Post", 200);
            lvConfirmBatches.Columns.Add("Batch Status", 200);
            lvConfirmBatches.Columns.Add("Reset Successful", 200);
            List<ListViewItem> lvItems = new List<ListViewItem>();
            foreach (BatchModel row in selectedBatches)
            {
                ListViewItem lvi = new ListViewItem(row.BatchNumber);
                lvi.SubItems.Add(row.MarkedToPost.ToString());
                lvi.SubItems.Add(row.BatchStatus.ToString());
                lvItems.Add(lvi);
            }

            lvConfirmBatches.Items.AddRange(lvItems.ToArray());

            tlpBatches.Visible = false;
            tlpConfirmBatches.Visible = true;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            lvConfirmBatches.Items.Clear();
            lvConfirmBatches.Clear();
            tlpBatches.Visible = true;
            tlpConfirmBatches.Visible = false;
        }

        private void btnConfirmReset_Click(object sender, EventArgs e)
        {
            IDictionary<string, bool> batchSuccess = new Dictionary<string, bool>();
            foreach (ListViewItem item in lvConfirmBatches.Items)
            {
                DebugHelper.WriteLine(item.Text);
            }

            DebugHelper.WriteLine($"Resetting {selectedBatches.Count} batches");
            Program.databaseService.ResetBatchStatus(Program.ConnectionString, selectedBatches.Select(x => x.BatchNumber).ToArray(), ref batchSuccess);

            foreach (ListViewItem item in lvConfirmBatches.Items)
            {
                if (batchSuccess.ContainsKey(item.Text))
                {
                    item.SubItems.Add(batchSuccess[item.Text].ToString());
                }
            }

        }

        // If a checkbox is clicked, this event handler will enabled or disable the reset
        // batches button.
        private void dgvBatches_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBatches.Columns[e.ColumnIndex].Name == "Selected")
            {
                if (batches.Count(x => x.Selected == true) > 0)
                {
                    btnResetBatches.Enabled = true;
                }
                else
                {
                    btnResetBatches.Enabled = false;
                }
            }

            dgvBatches.Invalidate();
        }

        // This event handler manually raises the CellValueChanged event by calling the 
        // CommitEdit method.
        private void dgvBatches_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvBatches.IsCurrentCellDirty)
            {
                dgvBatches.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}

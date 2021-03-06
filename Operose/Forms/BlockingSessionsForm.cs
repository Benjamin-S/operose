﻿using Operose.HelpersLib;
using System;
using System.Windows.Forms;

namespace Operose
{
    public partial class BlockingSessionsForm : UserControl
    {
        private int _showOwnPID = 0;
        private int _summaryMode = 0;

        public BlockingSessionsForm()
        {
            InitializeComponent();
            OperoseResources.ApplyCustomThemeToControl(this);
            Dock = DockStyle.Fill;
            base.DoubleBuffered = true;
            dgvBlockingList.AllowUserToResizeColumns = true;
            dgvBlockingList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        #region Background worker example

        // Add this to the constructor:
        //m_oWorker = new BackgroundWorker();
        //m_oWorker.DoWork += new DoWorkEventHandler(m_oWorker_DoWork);
        //m_oWorker.ProgressChanged += new ProgressChangedEventHandler(m_oWorker_ProgressChanged);
        //m_oWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_oWorker_RunWorkerCompleted);
        //m_oWorker.WorkerReportsProgress = true;
        //m_oWorker.WorkerSupportsCancellation = true;

        /// <summary>
        /// On completed do the appropriate task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //void m_oWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    // The background process is complete. We need to inspect
        //    // our response to see if an error occurred, a cancel was
        //    // requested or if we completed successfully.
        //    if (e.Cancelled)
        //    {
        //        lblStatus.Text = "Task Cancelled.";
        //    }

        //    // Check to see if an error occurred in the background process.

        //    else if (e.Error != null)
        //    {
        //        lblStatus.Text = "Error while performing background operation.";
        //    }
        //    else
        //    {
        //        // Everything completed normally.
        //        lblStatus.Text = "Task Completed...";
        //    }

        //    //Change the status of the buttons on the UI accordingly
        //    btnStartAsyncOperation.Enabled = true;
        //    btnCancel.Enabled = false;
        //}

        ///// <summary>
        ///// Notification is performed here to the progress bar
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //void m_oWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    // This function fires on the UI thread so it's safe to edit

        //    // the UI control directly, no funny business with Control.Invoke :)

        //    // Update the progressBar with the integer supplied to us from the

        //    // ReportProgress() function.

        //    progressBar1.Value = e.ProgressPercentage;
        //    lblStatus.Text = "Processing......" + progressBar1.Value.ToString() + "%";
        //}

        ///// <summary>
        ///// Time consuming operations go here </br>
        ///// i.e. Database operations,Reporting
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //void m_oWorker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    // The sender is the BackgroundWorker object we need it to
        //    // report progress and check for cancellation.
        //    //NOTE : Never play with the UI thread here...
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Thread.Sleep(100);

        //        // Periodically report progress to the main thread so that it can
        //        // update the UI.  In most cases you'll just need to send an
        //        // integer that will update a ProgressBar
        //        m_oWorker.ReportProgress(i);
        //        // Periodically check if a cancellation request is pending.
        //        // If the user clicks cancel the line
        //        // m_AsyncWorker.CancelAsync(); if ran above.  This
        //        // sets the CancellationPending to true.
        //        // You must check this flag in here and react to it.
        //        // We react to it by setting e.Cancel to true and leaving
        //        if (m_oWorker.CancellationPending)
        //        {
        //            // Set the e.Cancel flag so that the WorkerCompleted event
        //            // knows that the process was cancelled.
        //            e.Cancel = true;
        //            m_oWorker.ReportProgress(0);
        //            return;
        //        }
        //    }

        //    //Report 100% completion on operation completed
        //    m_oWorker.ReportProgress(100);
        //}

        //private void btnStartAsyncOperation_Click(object sender, EventArgs e)
        //{
        //    //Change the status of the buttons on the UI accordingly
        //    //The start button is disabled as soon as the background operation is started
        //    //The Cancel button is enabled so that the user can stop the operation
        //    //at any point of time during the execution
        //    btnStartAsyncOperation.Enabled = false;
        //    btnCancel.Enabled = true;

        //    // Kickoff the worker thread to begin it's DoWork function.
        //    m_oWorker.RunWorkerAsync();
        //}

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    if (m_oWorker.IsBusy)
        //    {
        //        // Notify the worker thread that a cancel has been requested.

        //        // The cancel will not actually happen until the thread in the

        //        // DoWork checks the m_oWorker.CancellationPending flag.

        //        m_oWorker.CancelAsync();
        //    }
        //}

        #endregion Background worker example

        private void GetBlockingSessions()
        {
            string summaryColumns = "[dd%][session_id][login_name][block%][reads%][writes%][context%][physical%][query_plan][locks]";

            if (_summaryMode == 1)
            {
                DebugHelper.WriteLine("Summary Mode is on");
                SuspendLayout();
                dgvBlockingList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvBlockingList.AllowUserToResizeColumns = true;
                dgvBlockingList.DataSource = Program.databaseService.GetBlockingSessions(EnvironmentManager.CurrentConnectionString, Show_own_spid: _showOwnPID, Output_column_list: summaryColumns);
                ResumeLayout();
            }
            else
            {
                SuspendLayout();
                dgvBlockingList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                dgvBlockingList.AllowUserToResizeColumns = false;
                dgvBlockingList.DataSource = Program.databaseService.GetBlockingSessions(EnvironmentManager.CurrentConnectionString, Show_own_spid: _showOwnPID);
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
                //GetBlockingSessions();
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
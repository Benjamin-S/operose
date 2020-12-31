namespace Operose
{
    partial class BlockingSessionsForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.cbSummary = new System.Windows.Forms.CheckBox();
            this.cbOwnSpid = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvBlockingList = new System.Windows.Forms.DataGridView();
            this.pnlBlockingList = new System.Windows.Forms.Panel();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockingList)).BeginInit();
            this.pnlBlockingList.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.cbSummary);
            this.pnlContainer.Controls.Add(this.cbOwnSpid);
            this.pnlContainer.Controls.Add(this.btnRefresh);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(516, 76);
            this.pnlContainer.TabIndex = 0;
            // 
            // cbSummary
            // 
            this.cbSummary.AutoSize = true;
            this.cbSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSummary.Location = new System.Drawing.Point(3, 32);
            this.cbSummary.Name = "cbSummary";
            this.cbSummary.Size = new System.Drawing.Size(85, 19);
            this.cbSummary.TabIndex = 2;
            this.cbSummary.Text = "Summarise";
            this.cbSummary.UseVisualStyleBackColor = true;
            this.cbSummary.CheckedChanged += new System.EventHandler(this.SummaryCheckbox_HandleChanged);
            // 
            // cbOwnSpid
            // 
            this.cbOwnSpid.AutoSize = true;
            this.cbOwnSpid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOwnSpid.Location = new System.Drawing.Point(3, 7);
            this.cbOwnSpid.Name = "cbOwnSpid";
            this.cbOwnSpid.Size = new System.Drawing.Size(112, 19);
            this.cbOwnSpid.TabIndex = 1;
            this.cbOwnSpid.Text = "Include Operose";
            this.cbOwnSpid.UseVisualStyleBackColor = true;
            this.cbOwnSpid.CheckedChanged += new System.EventHandler(this.SpCheckbox_HandleChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(438, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvBlockingList
            // 
            this.dgvBlockingList.AllowUserToAddRows = false;
            this.dgvBlockingList.AllowUserToDeleteRows = false;
            this.dgvBlockingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBlockingList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBlockingList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBlockingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBlockingList.Location = new System.Drawing.Point(0, 0);
            this.dgvBlockingList.Name = "dgvBlockingList";
            this.dgvBlockingList.ReadOnly = true;
            this.dgvBlockingList.Size = new System.Drawing.Size(516, 362);
            this.dgvBlockingList.TabIndex = 0;
            // 
            // pnlBlockingList
            // 
            this.pnlBlockingList.Controls.Add(this.dgvBlockingList);
            this.pnlBlockingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBlockingList.Location = new System.Drawing.Point(0, 76);
            this.pnlBlockingList.Name = "pnlBlockingList";
            this.pnlBlockingList.Size = new System.Drawing.Size(516, 362);
            this.pnlBlockingList.TabIndex = 1;
            // 
            // BlockingSessionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBlockingList);
            this.Controls.Add(this.pnlContainer);
            this.Name = "BlockingSessionsControl";
            this.Size = new System.Drawing.Size(516, 438);
            this.ParentChanged += new System.EventHandler(this.BlockingSessionsControl_ParentChanged);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockingList)).EndInit();
            this.pnlBlockingList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.DataGridView dgvBlockingList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlBlockingList;
        private System.Windows.Forms.CheckBox cbOwnSpid;
        private System.Windows.Forms.CheckBox cbSummary;
    }
}

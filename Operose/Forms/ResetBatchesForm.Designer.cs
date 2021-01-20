namespace Operose
{
    partial class ResetBatchesForm
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
            this.tlpBatches = new System.Windows.Forms.TableLayoutPanel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblBatchSearch = new System.Windows.Forms.Label();
            this.pnlBatches = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnResetBatches = new System.Windows.Forms.Button();
            this.tlpConfirmBatches = new System.Windows.Forms.TableLayoutPanel();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblConfirmHelp = new System.Windows.Forms.Label();
            this.lvConfirmBatches = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBatches = new Operose.ResetBatchDGV();
            this.tlpBatches.SuspendLayout();
            this.pnlBatches.SuspendLayout();
            this.tlpConfirmBatches.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBatches
            // 
            this.tlpBatches.ColumnCount = 5;
            this.tlpBatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBatches.Controls.Add(this.tbSearch, 1, 0);
            this.tlpBatches.Controls.Add(this.lblBatchSearch, 0, 0);
            this.tlpBatches.Controls.Add(this.pnlBatches, 0, 1);
            this.tlpBatches.Controls.Add(this.btnSearch, 2, 0);
            this.tlpBatches.Controls.Add(this.btnResetBatches, 3, 0);
            this.tlpBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBatches.Location = new System.Drawing.Point(0, 0);
            this.tlpBatches.Name = "tlpBatches";
            this.tlpBatches.RowCount = 2;
            this.tlpBatches.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBatches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBatches.Size = new System.Drawing.Size(584, 510);
            this.tlpBatches.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbSearch.Font = global::Operose.Properties.Settings.Default.DefaultFont;
            this.tbSearch.Location = new System.Drawing.Point(46, 6);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(181, 23);
            this.tbSearch.TabIndex = 0;
            // 
            // lblBatchSearch
            // 
            this.lblBatchSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBatchSearch.AutoSize = true;
            this.lblBatchSearch.Font = global::Operose.Properties.Settings.Default.DefaultFont;
            this.lblBatchSearch.Location = new System.Drawing.Point(3, 10);
            this.lblBatchSearch.Name = "lblBatchSearch";
            this.lblBatchSearch.Size = new System.Drawing.Size(37, 15);
            this.lblBatchSearch.TabIndex = 2;
            this.lblBatchSearch.Text = "Batch";
            // 
            // pnlBatches
            // 
            this.tlpBatches.SetColumnSpan(this.pnlBatches, 5);
            this.pnlBatches.Controls.Add(this.dgvBatches);
            this.pnlBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBatches.Location = new System.Drawing.Point(3, 38);
            this.pnlBatches.Name = "pnlBatches";
            this.pnlBatches.Size = new System.Drawing.Size(578, 469);
            this.pnlBatches.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.Font = global::Operose.Properties.Settings.Default.DefaultFont;
            this.btnSearch.Location = new System.Drawing.Point(233, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnResetBatches
            // 
            this.btnResetBatches.AutoSize = true;
            this.btnResetBatches.Font = global::Operose.Properties.Settings.Default.DefaultFont;
            this.btnResetBatches.Location = new System.Drawing.Point(326, 3);
            this.btnResetBatches.Name = "btnResetBatches";
            this.btnResetBatches.Size = new System.Drawing.Size(110, 29);
            this.btnResetBatches.TabIndex = 4;
            this.btnResetBatches.Text = "Reset Batch";
            this.btnResetBatches.UseVisualStyleBackColor = true;
            this.btnResetBatches.Click += new System.EventHandler(this.btnResetBatches_Click);
            // 
            // tlpConfirmBatches
            // 
            this.tlpConfirmBatches.ColumnCount = 2;
            this.tlpConfirmBatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpConfirmBatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConfirmBatches.Controls.Add(this.btnGoBack, 0, 0);
            this.tlpConfirmBatches.Controls.Add(this.lblConfirmHelp, 1, 0);
            this.tlpConfirmBatches.Controls.Add(this.lvConfirmBatches, 0, 1);
            this.tlpConfirmBatches.Controls.Add(this.panel1, 0, 2);
            this.tlpConfirmBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConfirmBatches.Font = global::Operose.Properties.Settings.Default.DefaultFont;
            this.tlpConfirmBatches.Location = new System.Drawing.Point(0, 0);
            this.tlpConfirmBatches.Name = "tlpConfirmBatches";
            this.tlpConfirmBatches.RowCount = 3;
            this.tlpConfirmBatches.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConfirmBatches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConfirmBatches.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConfirmBatches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpConfirmBatches.Size = new System.Drawing.Size(584, 510);
            this.tlpConfirmBatches.TabIndex = 0;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(3, 3);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(87, 27);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblConfirmHelp
            // 
            this.lblConfirmHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmHelp.Location = new System.Drawing.Point(96, 0);
            this.lblConfirmHelp.Name = "lblConfirmHelp";
            this.lblConfirmHelp.Size = new System.Drawing.Size(485, 33);
            this.lblConfirmHelp.TabIndex = 1;
            this.lblConfirmHelp.Text = "The batches below have been selected to have their batch status and posting statu" +
    "s reset.";
            this.lblConfirmHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvConfirmBatches
            // 
            this.tlpConfirmBatches.SetColumnSpan(this.lvConfirmBatches, 2);
            this.lvConfirmBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConfirmBatches.HideSelection = false;
            this.lvConfirmBatches.Location = new System.Drawing.Point(3, 36);
            this.lvConfirmBatches.Name = "lvConfirmBatches";
            this.lvConfirmBatches.Size = new System.Drawing.Size(578, 415);
            this.lvConfirmBatches.TabIndex = 2;
            this.lvConfirmBatches.UseCompatibleStateImageBehavior = false;
            this.lvConfirmBatches.View = System.Windows.Forms.View.Details;
            this.lvConfirmBatches.SizeChanged += new System.EventHandler(this.lvConfirmBatches_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.tlpConfirmBatches.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btnConfirmReset);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 50);
            this.panel1.TabIndex = 5;
            // 
            // btnConfirmReset
            // 
            this.btnConfirmReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmReset.Location = new System.Drawing.Point(500, 3);
            this.btnConfirmReset.Name = "btnConfirmReset";
            this.btnConfirmReset.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmReset.TabIndex = 5;
            this.btnConfirmReset.Text = "Confirm";
            this.btnConfirmReset.UseVisualStyleBackColor = true;
            this.btnConfirmReset.Click += new System.EventHandler(this.btnConfirmReset_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "By clicking this button you confirm that you know what you are doing and take res" +
    "ponsibility for this action.";
            // 
            // dgvBatches
            // 
            this.dgvBatches.AllowUserToAddRows = false;
            this.dgvBatches.AllowUserToDeleteRows = false;
            this.dgvBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBatches.Location = new System.Drawing.Point(0, 0);
            this.dgvBatches.Name = "dgvBatches";
            this.dgvBatches.Size = new System.Drawing.Size(578, 469);
            this.dgvBatches.TabIndex = 0;
            this.dgvBatches.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatches_CellValueChanged);
            this.dgvBatches.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvBatches_CurrentCellDirtyStateChanged);
            // 
            // ResetBatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpConfirmBatches);
            this.Controls.Add(this.tlpBatches);
            this.Font = global::Operose.Properties.Settings.Default.DefaultFont;
            this.Name = "ResetBatchesForm";
            this.Size = new System.Drawing.Size(584, 510);
            this.tlpBatches.ResumeLayout(false);
            this.tlpBatches.PerformLayout();
            this.pnlBatches.ResumeLayout(false);
            this.tlpConfirmBatches.ResumeLayout(false);
            this.tlpConfirmBatches.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBatches;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblBatchSearch;
        private System.Windows.Forms.Panel pnlBatches;
        private ResetBatchDGV dgvBatches;
        private System.Windows.Forms.Button btnResetBatches;
        private System.Windows.Forms.TableLayoutPanel tlpConfirmBatches;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblConfirmHelp;
        private System.Windows.Forms.ListView lvConfirmBatches;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirmReset;
        private System.Windows.Forms.Label label1;
    }
}

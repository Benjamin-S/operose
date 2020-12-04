namespace Operose
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pToolbars = new System.Windows.Forms.Panel();
            this.tsMain = new Operose.HelpersLib.Controls.ToolStripBorderRight();
            this.tsEnvironment = new Operose.HelpersLib.Controls.ToolStripBorderRight();
            this.tsddbEnvironment = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiProduction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDevelopment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tslbEnvironment = new System.Windows.Forms.ToolStripLabel();
            this.pMain = new System.Windows.Forms.Panel();
            this.pToolbars.SuspendLayout();
            this.tsEnvironment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pToolbars
            // 
            this.pToolbars.Controls.Add(this.tsMain);
            this.pToolbars.Controls.Add(this.tsEnvironment);
            this.pToolbars.Dock = System.Windows.Forms.DockStyle.Left;
            this.pToolbars.Location = new System.Drawing.Point(0, 0);
            this.pToolbars.Name = "pToolbars";
            this.pToolbars.Size = new System.Drawing.Size(165, 417);
            this.pToolbars.TabIndex = 0;
            // 
            // tsMain
            // 
            this.tsMain.CanOverflow = false;
            this.tsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsMain.DrawCustomBorder = true;
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(165, 374);
            this.tsMain.TabIndex = 2;
            this.tsMain.Text = "toolStrip1";
            this.tsMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.HandleToolStripItemChange);
            // 
            // tsEnvironment
            // 
            this.tsEnvironment.CanOverflow = false;
            this.tsEnvironment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsEnvironment.DrawCustomBorder = true;
            this.tsEnvironment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsEnvironment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbEnvironment,
            this.tslbEnvironment});
            this.tsEnvironment.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsEnvironment.Location = new System.Drawing.Point(0, 374);
            this.tsEnvironment.MinimumSize = new System.Drawing.Size(165, 0);
            this.tsEnvironment.Name = "tsEnvironment";
            this.tsEnvironment.Size = new System.Drawing.Size(165, 43);
            this.tsEnvironment.TabIndex = 3;
            this.tsEnvironment.Text = "toolStrip1";
            // 
            // tsddbEnvironment
            // 
            this.tsddbEnvironment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProduction,
            this.tsmiDevelopment,
            this.tsmiTest});
            this.tsddbEnvironment.Image = ((System.Drawing.Image)(resources.GetObject("tsddbEnvironment.Image")));
            this.tsddbEnvironment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsddbEnvironment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbEnvironment.Name = "tsddbEnvironment";
            this.tsddbEnvironment.Size = new System.Drawing.Size(163, 20);
            this.tsddbEnvironment.Text = "Environment";
            // 
            // tsmiProduction
            // 
            this.tsmiProduction.Name = "tsmiProduction";
            this.tsmiProduction.Size = new System.Drawing.Size(145, 22);
            this.tsmiProduction.Text = "Production";
            this.tsmiProduction.Click += new System.EventHandler(this.HandleEnvironmentChange);
            // 
            // tsmiDevelopment
            // 
            this.tsmiDevelopment.Name = "tsmiDevelopment";
            this.tsmiDevelopment.Size = new System.Drawing.Size(145, 22);
            this.tsmiDevelopment.Text = "Development";
            this.tsmiDevelopment.Click += new System.EventHandler(this.HandleEnvironmentChange);
            // 
            // tsmiTest
            // 
            this.tsmiTest.Name = "tsmiTest";
            this.tsmiTest.Size = new System.Drawing.Size(145, 22);
            this.tsmiTest.Text = "Test";
            this.tsmiTest.Click += new System.EventHandler(this.HandleEnvironmentChange);
            // 
            // tslbEnvironment
            // 
            this.tslbEnvironment.Name = "tslbEnvironment";
            this.tslbEnvironment.Size = new System.Drawing.Size(163, 15);
            this.tslbEnvironment.Text = "Environment";
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(165, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(508, 417);
            this.pMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(673, 417);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pToolbars);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pToolbars.ResumeLayout(false);
            this.pToolbars.PerformLayout();
            this.tsEnvironment.ResumeLayout(false);
            this.tsEnvironment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pToolbars;
        private Operose.HelpersLib.Controls.ToolStripBorderRight tsMain;
        private System.Windows.Forms.Panel pMain;
        private Operose.HelpersLib.Controls.ToolStripBorderRight tsEnvironment;
        private System.Windows.Forms.ToolStripDropDownButton tsddbEnvironment;
        private System.Windows.Forms.ToolStripMenuItem tsmiProduction;
        private System.Windows.Forms.ToolStripMenuItem tsmiDevelopment;
        private System.Windows.Forms.ToolStripMenuItem tsmiTest;
        private System.Windows.Forms.ToolStripLabel tslbEnvironment;
    }
}
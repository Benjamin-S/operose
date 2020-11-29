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
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.tsbBlockingSession = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsEnvironment = new Operose.HelpersLib.Controls.ToolStripBorderRight();
            this.tsddbEnvironment = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiProduction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDevelopment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tslbEnvironment = new System.Windows.Forms.ToolStripLabel();
            this.pMain = new System.Windows.Forms.Panel();
            this.pToolbars.SuspendLayout();
            this.tsMain.SuspendLayout();
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
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbHome,
            this.tsbBlockingSession,
            this.toolStripButton4,
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.tsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(165, 374);
            this.tsMain.TabIndex = 2;
            this.tsMain.Text = "toolStrip1";
            this.tsMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.HandleToolStripItemChange);
            // 
            // tsbHome
            // 
            this.tsbHome.Image = ((System.Drawing.Image)(resources.GetObject("tsbHome.Image")));
            this.tsbHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Size = new System.Drawing.Size(163, 20);
            this.tsbHome.Text = "Home";
            // 
            // tsbBlockingSession
            // 
            this.tsbBlockingSession.Image = ((System.Drawing.Image)(resources.GetObject("tsbBlockingSession.Image")));
            this.tsbBlockingSession.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbBlockingSession.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBlockingSession.Name = "tsbBlockingSession";
            this.tsbBlockingSession.Size = new System.Drawing.Size(163, 20);
            this.tsbBlockingSession.Text = "Blocking Sessions";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(163, 20);
            this.toolStripButton4.Text = "Home";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(163, 20);
            this.toolStripButton3.Text = "Home";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(163, 20);
            this.toolStripButton2.Text = "Home";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(163, 20);
            this.toolStripButton1.Text = "Home";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
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
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.tsEnvironment.ResumeLayout(false);
            this.tsEnvironment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pToolbars;
        private Operose.HelpersLib.Controls.ToolStripBorderRight tsMain;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.ToolStripButton tsbBlockingSession;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pMain;
        private Operose.HelpersLib.Controls.ToolStripBorderRight tsEnvironment;
        private System.Windows.Forms.ToolStripDropDownButton tsddbEnvironment;
        private System.Windows.Forms.ToolStripMenuItem tsmiProduction;
        private System.Windows.Forms.ToolStripMenuItem tsmiDevelopment;
        private System.Windows.Forms.ToolStripMenuItem tsmiTest;
        private System.Windows.Forms.ToolStripLabel tslbEnvironment;
    }
}
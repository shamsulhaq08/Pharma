
namespace Pharma
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineCompanyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.companyInfoToolStripMenuItem,
            this.medicineCompanyNameToolStripMenuItem,
            this.medicineTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1214, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(73, 32);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // companyInfoToolStripMenuItem
            // 
            this.companyInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.companyInfoToolStripMenuItem.Name = "companyInfoToolStripMenuItem";
            this.companyInfoToolStripMenuItem.Size = new System.Drawing.Size(137, 32);
            this.companyInfoToolStripMenuItem.Text = "Business Info";
            this.companyInfoToolStripMenuItem.Click += new System.EventHandler(this.companyInfoToolStripMenuItem_Click);
            // 
            // medicineCompanyNameToolStripMenuItem
            // 
            this.medicineCompanyNameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.medicineCompanyNameToolStripMenuItem.Name = "medicineCompanyNameToolStripMenuItem";
            this.medicineCompanyNameToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.medicineCompanyNameToolStripMenuItem.Text = "Medicine Company Name";
            this.medicineCompanyNameToolStripMenuItem.Click += new System.EventHandler(this.medicineCompanyNameToolStripMenuItem_Click);
            // 
            // medicineTypeToolStripMenuItem
            // 
            this.medicineTypeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.medicineTypeToolStripMenuItem.Name = "medicineTypeToolStripMenuItem";
            this.medicineTypeToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.medicineTypeToolStripMenuItem.Text = "Medicine Type";
            this.medicineTypeToolStripMenuItem.Click += new System.EventHandler(this.medicineTypeToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 653);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineCompanyNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineTypeToolStripMenuItem;
    }
}
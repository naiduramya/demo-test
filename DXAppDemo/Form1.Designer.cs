namespace DXAppDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.FromArgb(128, 128, 255);
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Location = new Point(0, 1);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(800, 58);
            panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            labelControl1.Appearance.ForeColor = Color.White;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(125, 7);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(550, 42);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Employee Management System";
            // 
            // panelControl2
            // 
            panelControl2.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            panelControl2.Appearance.Options.UseBackColor = true;
            panelControl2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl2.Controls.Add(simpleButton3);
            panelControl2.Controls.Add(simpleButton2);
            panelControl2.Controls.Add(simpleButton1);
            panelControl2.Location = new Point(0, 65);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(230, 255);
            panelControl2.TabIndex = 1;
            // 
            // simpleButton3
            // 
            simpleButton3.Appearance.BackColor = Color.FromArgb(192, 192, 255);
            simpleButton3.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            simpleButton3.Appearance.ForeColor = Color.Black;
            simpleButton3.Appearance.Options.UseBackColor = true;
            simpleButton3.Appearance.Options.UseFont = true;
            simpleButton3.Appearance.Options.UseForeColor = true;
            simpleButton3.BackgroundImageLayout = ImageLayout.Center;
            simpleButton3.Location = new Point(12, 194);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(201, 42);
            simpleButton3.TabIndex = 2;
            simpleButton3.Text = "Exit";
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.BackColor = Color.FromArgb(192, 192, 255);
            simpleButton2.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            simpleButton2.Appearance.ForeColor = Color.Black;
            simpleButton2.Appearance.Options.UseBackColor = true;
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.Appearance.Options.UseForeColor = true;
            simpleButton2.BackgroundImageLayout = ImageLayout.Center;
            simpleButton2.Location = new Point(12, 103);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(201, 61);
            simpleButton2.TabIndex = 1;
            simpleButton2.Text = "Employee Information";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = Color.FromArgb(192, 192, 255);
            simpleButton1.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            simpleButton1.Appearance.ForeColor = Color.Black;
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.BackgroundImageLayout = ImageLayout.Center;
            simpleButton1.Location = new Point(12, 22);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(201, 49);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "Employee";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources._18771;
            pictureBox1.Location = new Point(236, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(564, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 320);
            Controls.Add(pictureBox1);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            Name = "Form1";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private PictureBox pictureBox1;
    }
}

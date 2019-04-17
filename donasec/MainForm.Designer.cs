﻿namespace donasec
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxHelp2 = new System.Windows.Forms.TextBox();
            this.textBoxHelp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonProceed = new System.Windows.Forms.Button();
            this.comboBoxBrowsers = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxHelp2);
            this.groupBox2.Controls.Add(this.textBoxHelp);
            this.groupBox2.Location = new System.Drawing.Point(574, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tell me more...";
            // 
            // textBoxHelp2
            // 
            this.textBoxHelp2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHelp2.Location = new System.Drawing.Point(12, 100);
            this.textBoxHelp2.Multiline = true;
            this.textBoxHelp2.Name = "textBoxHelp2";
            this.textBoxHelp2.ReadOnly = true;
            this.textBoxHelp2.Size = new System.Drawing.Size(183, 27);
            this.textBoxHelp2.TabIndex = 2;
            this.textBoxHelp2.Text = "More info on www.donasec.com";
            // 
            // textBoxHelp
            // 
            this.textBoxHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHelp.Location = new System.Drawing.Point(12, 34);
            this.textBoxHelp.Multiline = true;
            this.textBoxHelp.Name = "textBoxHelp";
            this.textBoxHelp.ReadOnly = true;
            this.textBoxHelp.Size = new System.Drawing.Size(196, 60);
            this.textBoxHelp.TabIndex = 1;
            this.textBoxHelp.Text = "A weblink can get you anywhere, potentially installing software on your machine o" +
    "r trying to get sensitive information from you. Don\'t fall for it.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Link:";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(42, 60);
            this.textBoxLink.MaxLength = 2084;
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.ReadOnly = true;
            this.textBoxLink.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxLink.ShortcutsEnabled = false;
            this.textBoxLink.Size = new System.Drawing.Size(499, 20);
            this.textBoxLink.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonAbort);
            this.groupBox3.Location = new System.Drawing.Point(42, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 80);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "The safe option";
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(29, 46);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(190, 26);
            this.buttonAbort.TabIndex = 4;
            this.buttonAbort.Text = "Abort. Do not open the link.";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Only open the link if you are 100% sure.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxBrowsers);
            this.groupBox4.Controls.Add(this.buttonProceed);
            this.groupBox4.Location = new System.Drawing.Point(310, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 80);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "YOLO";
            // 
            // buttonProceed
            // 
            this.buttonProceed.Location = new System.Drawing.Point(30, 46);
            this.buttonProceed.Name = "buttonProceed";
            this.buttonProceed.Size = new System.Drawing.Size(172, 26);
            this.buttonProceed.TabIndex = 5;
            this.buttonProceed.Text = "Open the link.";
            this.buttonProceed.UseVisualStyleBackColor = true;
            this.buttonProceed.Click += new System.EventHandler(this.buttonProceed_Click);
            // 
            // comboBoxBrowsers
            // 
            this.comboBoxBrowsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrowsers.FormattingEnabled = true;
            this.comboBoxBrowsers.Location = new System.Drawing.Point(30, 19);
            this.comboBoxBrowsers.Name = "comboBoxBrowsers";
            this.comboBoxBrowsers.Size = new System.Drawing.Size(172, 21);
            this.comboBoxBrowsers.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.textBoxLink);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "\'d on a sec! Not so fast...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "You have clicked on a web link (email, etc.). This will open up a web browser. Is" +
    " it what you want?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 188);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donasec";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxHelp;
        private System.Windows.Forms.TextBox textBoxHelp2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ComboBox comboBoxBrowsers;
        private System.Windows.Forms.Button buttonProceed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}


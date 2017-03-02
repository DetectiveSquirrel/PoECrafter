﻿namespace WindowsFormsApplication3
{
    partial class ProgressBar
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
            this.RedWant = new System.Windows.Forms.NumericUpDown();
            this.BlueWant = new System.Windows.Forms.NumericUpDown();
            this.GreenWant = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WantLinks = new System.Windows.Forms.NumericUpDown();
            this.StartColors = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ChromaticsToUse = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.FusingLabel = new System.Windows.Forms.Label();
            this.FusingsToUse = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.JewelersToUse = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.SocketStart = new System.Windows.Forms.Button();
            this.WantSockets = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.RedWant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueWant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenWant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WantLinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChromaticsToUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FusingsToUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JewelersToUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WantSockets)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RedWant
            // 
            this.RedWant.Location = new System.Drawing.Point(293, 77);
            this.RedWant.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.RedWant.Name = "RedWant";
            this.RedWant.Size = new System.Drawing.Size(47, 20);
            this.RedWant.TabIndex = 1;
            this.RedWant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BlueWant
            // 
            this.BlueWant.Location = new System.Drawing.Point(437, 77);
            this.BlueWant.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.BlueWant.Name = "BlueWant";
            this.BlueWant.Size = new System.Drawing.Size(45, 20);
            this.BlueWant.TabIndex = 2;
            this.BlueWant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GreenWant
            // 
            this.GreenWant.Location = new System.Drawing.Point(372, 77);
            this.GreenWant.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.GreenWant.Name = "GreenWant";
            this.GreenWant.Size = new System.Drawing.Size(40, 20);
            this.GreenWant.TabIndex = 3;
            this.GreenWant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desired Colors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(304, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(382, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(450, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Desired Links";
            // 
            // WantLinks
            // 
            this.WantLinks.Location = new System.Drawing.Point(293, 355);
            this.WantLinks.Name = "WantLinks";
            this.WantLinks.Size = new System.Drawing.Size(47, 20);
            this.WantLinks.TabIndex = 9;
            this.WantLinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartColors
            // 
            this.StartColors.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartColors.Location = new System.Drawing.Point(293, 113);
            this.StartColors.Name = "StartColors";
            this.StartColors.Size = new System.Drawing.Size(271, 23);
            this.StartColors.TabIndex = 10;
            this.StartColors.Text = "GO!";
            this.StartColors.UseVisualStyleBackColor = true;
            this.StartColors.Click += new System.EventHandler(this.StartColors_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(293, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChromaticsToUse
            // 
            this.ChromaticsToUse.Location = new System.Drawing.Point(497, 77);
            this.ChromaticsToUse.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ChromaticsToUse.Name = "ChromaticsToUse";
            this.ChromaticsToUse.Size = new System.Drawing.Size(67, 20);
            this.ChromaticsToUse.TabIndex = 12;
            this.ChromaticsToUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Chromatics\r\nto use";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FusingLabel
            // 
            this.FusingLabel.AutoSize = true;
            this.FusingLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FusingLabel.Location = new System.Drawing.Point(500, 312);
            this.FusingLabel.Name = "FusingLabel";
            this.FusingLabel.Size = new System.Drawing.Size(57, 32);
            this.FusingLabel.TabIndex = 14;
            this.FusingLabel.Text = "Fusings\r\nto use";
            this.FusingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FusingsToUse
            // 
            this.FusingsToUse.Location = new System.Drawing.Point(497, 355);
            this.FusingsToUse.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.FusingsToUse.Name = "FusingsToUse";
            this.FusingsToUse.Size = new System.Drawing.Size(67, 20);
            this.FusingsToUse.TabIndex = 15;
            this.FusingsToUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 416);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(587, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 16;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(260, 369);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // JewelersToUse
            // 
            this.JewelersToUse.Location = new System.Drawing.Point(497, 215);
            this.JewelersToUse.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.JewelersToUse.Name = "JewelersToUse";
            this.JewelersToUse.Size = new System.Drawing.Size(67, 20);
            this.JewelersToUse.TabIndex = 22;
            this.JewelersToUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Jewelers\r\nto use";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SocketStart
            // 
            this.SocketStart.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SocketStart.Location = new System.Drawing.Point(293, 241);
            this.SocketStart.Name = "SocketStart";
            this.SocketStart.Size = new System.Drawing.Size(271, 23);
            this.SocketStart.TabIndex = 20;
            this.SocketStart.Text = "GO!";
            this.SocketStart.UseVisualStyleBackColor = true;
            this.SocketStart.Click += new System.EventHandler(this.SocketStart_Click);
            // 
            // WantSockets
            // 
            this.WantSockets.Location = new System.Drawing.Point(293, 215);
            this.WantSockets.Name = "WantSockets";
            this.WantSockets.Size = new System.Drawing.Size(47, 20);
            this.WantSockets.TabIndex = 19;
            this.WantSockets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(289, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Desired Sockets";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 439);
            this.Controls.Add(this.JewelersToUse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SocketStart);
            this.Controls.Add(this.WantSockets);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FusingsToUse);
            this.Controls.Add(this.FusingLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ChromaticsToUse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartColors);
            this.Controls.Add(this.WantLinks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GreenWant);
            this.Controls.Add(this.BlueWant);
            this.Controls.Add(this.RedWant);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProgressBar";
            this.Text = "PoECrafter";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedWant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueWant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenWant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WantLinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChromaticsToUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FusingsToUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JewelersToUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WantSockets)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown RedWant;
        private System.Windows.Forms.NumericUpDown BlueWant;
        private System.Windows.Forms.NumericUpDown GreenWant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown WantLinks;
        private System.Windows.Forms.Button StartColors;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown ChromaticsToUse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FusingLabel;
        private System.Windows.Forms.NumericUpDown FusingsToUse;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown JewelersToUse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SocketStart;
        private System.Windows.Forms.NumericUpDown WantSockets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
    }
}

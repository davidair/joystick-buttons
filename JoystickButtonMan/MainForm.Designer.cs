/*
Copyright 2020 Google Inc.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
namespace JoystickButtonMan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxOrange = new System.Windows.Forms.TextBox();
            this.textBoxYellow = new System.Windows.Forms.TextBox();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrange = new System.Windows.Forms.PictureBox();
            this.pictureBoxYellow = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxWhite = new System.Windows.Forms.PictureBox();
            this.textBoxWhite = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toggleVisibilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxKeyboardModifiers = new System.Windows.Forms.GroupBox();
            this.radioButtonCtrl = new System.Windows.Forms.RadioButton();
            this.radioButtonAlt = new System.Windows.Forms.RadioButton();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.groupBoxKeyboardModifiers.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.textBoxRed, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxGreen, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxOrange, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxYellow, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxRed, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxGreen, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxOrange, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxYellow, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxBlue, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxWhite, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxWhite, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxBlue, 3, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 13);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(973, 166);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // textBoxRed
            // 
            this.textBoxRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRed.Location = new System.Drawing.Point(544, 128);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(426, 20);
            this.textBoxRed.TabIndex = 16;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGreen.Location = new System.Drawing.Point(58, 128);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(425, 20);
            this.textBoxGreen.TabIndex = 15;
            // 
            // textBoxOrange
            // 
            this.textBoxOrange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOrange.Location = new System.Drawing.Point(544, 72);
            this.textBoxOrange.Name = "textBoxOrange";
            this.textBoxOrange.Size = new System.Drawing.Size(426, 20);
            this.textBoxOrange.TabIndex = 14;
            // 
            // textBoxYellow
            // 
            this.textBoxYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxYellow.Location = new System.Drawing.Point(58, 72);
            this.textBoxYellow.Name = "textBoxYellow";
            this.textBoxYellow.Size = new System.Drawing.Size(425, 20);
            this.textBoxYellow.TabIndex = 13;
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRed.Image")));
            this.pictureBoxRed.Location = new System.Drawing.Point(489, 113);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(49, 50);
            this.pictureBoxRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxRed.TabIndex = 10;
            this.pictureBoxRed.TabStop = false;
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGreen.Image")));
            this.pictureBoxGreen.Location = new System.Drawing.Point(3, 113);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(49, 50);
            this.pictureBoxGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGreen.TabIndex = 8;
            this.pictureBoxGreen.TabStop = false;
            // 
            // pictureBoxOrange
            // 
            this.pictureBoxOrange.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOrange.Image")));
            this.pictureBoxOrange.Location = new System.Drawing.Point(489, 58);
            this.pictureBoxOrange.Name = "pictureBoxOrange";
            this.pictureBoxOrange.Size = new System.Drawing.Size(49, 49);
            this.pictureBoxOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxOrange.TabIndex = 6;
            this.pictureBoxOrange.TabStop = false;
            // 
            // pictureBoxYellow
            // 
            this.pictureBoxYellow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxYellow.Image")));
            this.pictureBoxYellow.Location = new System.Drawing.Point(3, 58);
            this.pictureBoxYellow.Name = "pictureBoxYellow";
            this.pictureBoxYellow.Size = new System.Drawing.Size(49, 49);
            this.pictureBoxYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxYellow.TabIndex = 4;
            this.pictureBoxYellow.TabStop = false;
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBlue.Image")));
            this.pictureBoxBlue.Location = new System.Drawing.Point(489, 3);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(49, 49);
            this.pictureBoxBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBlue.TabIndex = 2;
            this.pictureBoxBlue.TabStop = false;
            // 
            // pictureBoxWhite
            // 
            this.pictureBoxWhite.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWhite.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWhite.Image")));
            this.pictureBoxWhite.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxWhite.Name = "pictureBoxWhite";
            this.pictureBoxWhite.Size = new System.Drawing.Size(49, 49);
            this.pictureBoxWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxWhite.TabIndex = 0;
            this.pictureBoxWhite.TabStop = false;
            // 
            // textBoxWhite
            // 
            this.textBoxWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWhite.Location = new System.Drawing.Point(58, 17);
            this.textBoxWhite.Name = "textBoxWhite";
            this.textBoxWhite.Size = new System.Drawing.Size(425, 20);
            this.textBoxWhite.TabIndex = 11;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBlue.Location = new System.Drawing.Point(544, 17);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(426, 20);
            this.textBoxBlue.TabIndex = 12;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Joystick Buttons";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleVisibilityToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(157, 48);
            // 
            // toggleVisibilityToolStripMenuItem
            // 
            this.toggleVisibilityToolStripMenuItem.Name = "toggleVisibilityToolStripMenuItem";
            this.toggleVisibilityToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.toggleVisibilityToolStripMenuItem.Text = "&Toggle Visibility";
            this.toggleVisibilityToolStripMenuItem.Click += new System.EventHandler(this.toggleVisibilityToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBoxKeyboardModifiers
            // 
            this.groupBoxKeyboardModifiers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxKeyboardModifiers.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxKeyboardModifiers.Controls.Add(this.radioButtonCtrl);
            this.groupBoxKeyboardModifiers.Controls.Add(this.radioButtonAlt);
            this.groupBoxKeyboardModifiers.Controls.Add(this.radioButtonNone);
            this.groupBoxKeyboardModifiers.Location = new System.Drawing.Point(12, 191);
            this.groupBoxKeyboardModifiers.Name = "groupBoxKeyboardModifiers";
            this.groupBoxKeyboardModifiers.Size = new System.Drawing.Size(973, 45);
            this.groupBoxKeyboardModifiers.TabIndex = 1;
            this.groupBoxKeyboardModifiers.TabStop = false;
            this.groupBoxKeyboardModifiers.Text = "Keyboard Modifiers";
            // 
            // radioButtonCtrl
            // 
            this.radioButtonCtrl.AutoSize = true;
            this.radioButtonCtrl.Location = new System.Drawing.Point(63, 19);
            this.radioButtonCtrl.Name = "radioButtonCtrl";
            this.radioButtonCtrl.Size = new System.Drawing.Size(40, 17);
            this.radioButtonCtrl.TabIndex = 2;
            this.radioButtonCtrl.TabStop = true;
            this.radioButtonCtrl.Text = "Ctrl";
            this.radioButtonCtrl.UseVisualStyleBackColor = true;
            this.radioButtonCtrl.CheckedChanged += new System.EventHandler(this.radioButtonCtrl_CheckedChanged);
            // 
            // radioButtonAlt
            // 
            this.radioButtonAlt.AutoSize = true;
            this.radioButtonAlt.Location = new System.Drawing.Point(120, 19);
            this.radioButtonAlt.Name = "radioButtonAlt";
            this.radioButtonAlt.Size = new System.Drawing.Size(37, 17);
            this.radioButtonAlt.TabIndex = 1;
            this.radioButtonAlt.TabStop = true;
            this.radioButtonAlt.Text = "Alt";
            this.radioButtonAlt.UseVisualStyleBackColor = true;
            this.radioButtonAlt.CheckedChanged += new System.EventHandler(this.radioButtonAlt_CheckedChanged);
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Location = new System.Drawing.Point(6, 19);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonNone.TabIndex = 0;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            this.radioButtonNone.CheckedChanged += new System.EventHandler(this.radioButtonNone_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(997, 244);
            this.Controls.Add(this.groupBoxKeyboardModifiers);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Joystick Buttons Binding";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBoxKeyboardModifiers.ResumeLayout(false);
            this.groupBoxKeyboardModifiers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBoxWhite;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.PictureBox pictureBoxOrange;
        private System.Windows.Forms.PictureBox pictureBoxYellow;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxOrange;
        private System.Windows.Forms.TextBox textBoxYellow;
        private System.Windows.Forms.TextBox textBoxWhite;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toggleVisibilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxKeyboardModifiers;
        private System.Windows.Forms.RadioButton radioButtonCtrl;
        private System.Windows.Forms.RadioButton radioButtonAlt;
        private System.Windows.Forms.RadioButton radioButtonNone;
    }
}


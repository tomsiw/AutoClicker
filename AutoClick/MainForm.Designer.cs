namespace AutoClick
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
            this.label1 = new System.Windows.Forms.Label();
            this.startClickingTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stopClickingTextBox = new System.Windows.Forms.TextBox();
            this.doubleClickCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clickEveryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startButton = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start clicking on:";
            // 
            // startClickingTextBox
            // 
            this.startClickingTextBox.Location = new System.Drawing.Point(104, 6);
            this.startClickingTextBox.Name = "startClickingTextBox";
            this.startClickingTextBox.Size = new System.Drawing.Size(113, 20);
            this.startClickingTextBox.TabIndex = 1;
            this.startClickingTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.startClickingTextBox_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stop clicking on:";
            // 
            // stopClickingTextBox
            // 
            this.stopClickingTextBox.Location = new System.Drawing.Point(104, 35);
            this.stopClickingTextBox.Name = "stopClickingTextBox";
            this.stopClickingTextBox.Size = new System.Drawing.Size(113, 20);
            this.stopClickingTextBox.TabIndex = 1;
            this.stopClickingTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.stopClickingTextBox_PreviewKeyDown);
            // 
            // doubleClickCheckBox
            // 
            this.doubleClickCheckBox.AutoSize = true;
            this.doubleClickCheckBox.Location = new System.Drawing.Point(15, 92);
            this.doubleClickCheckBox.Name = "doubleClickCheckBox";
            this.doubleClickCheckBox.Size = new System.Drawing.Size(85, 17);
            this.doubleClickCheckBox.TabIndex = 2;
            this.doubleClickCheckBox.Text = "Double-click";
            this.doubleClickCheckBox.UseVisualStyleBackColor = true;
            this.doubleClickCheckBox.CheckedChanged += new System.EventHandler(this.doubleClickCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Click every:";
            // 
            // clickEveryTextBox
            // 
            this.clickEveryTextBox.Location = new System.Drawing.Point(104, 63);
            this.clickEveryTextBox.Name = "clickEveryTextBox";
            this.clickEveryTextBox.Size = new System.Drawing.Size(51, 20);
            this.clickEveryTextBox.TabIndex = 1;
            this.clickEveryTextBox.Text = "1000";
            this.clickEveryTextBox.TextChanged += new System.EventHandler(this.clickEveryTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ms";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Auto Clicker";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripMenuItem2,
            this.quitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(104, 54);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 115);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(202, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 146);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.doubleClickCheckBox);
            this.Controls.Add(this.clickEveryTextBox);
            this.Controls.Add(this.stopClickingTextBox);
            this.Controls.Add(this.startClickingTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Click";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startClickingTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stopClickingTextBox;
        private System.Windows.Forms.CheckBox doubleClickCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clickEveryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button startButton;
    }
}


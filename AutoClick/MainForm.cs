using AutoClick.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClick
{
    public partial class MainForm : Form
    {
        private bool running = false;
        private KeyboardWatcher watcher;
        private Clicker cliker;

        public MainForm()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            startClickingTextBox.Text = Settings.Default.StartOn;
            stopClickingTextBox.Text = Settings.Default.StopOn;
            doubleClickCheckBox.Checked = Settings.Default.DoubleClick;
            clickEveryTextBox.Text = Settings.Default.ClickDelay.ToString();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            notifyIcon.Visible = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void startClickingTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            PreviewKeyDown(e, ks =>
            {
                startClickingTextBox.Text = ks.ToString();
                Settings.Default.StartOn = ks.ToString();
                Settings.Default.Save();
            });
        }

        private void stopClickingTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            PreviewKeyDown(e, ks => 
            {
                stopClickingTextBox.Text = ks.ToString();
                Settings.Default.StopOn = ks.ToString();
                Settings.Default.Save();
            });
        }

        private void clickEveryTextBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.ClickDelay = int.Parse(clickEveryTextBox.Text);
            Settings.Default.Save();
        }

        private void doubleClickCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.DoubleClick = doubleClickCheckBox.Checked;
            Settings.Default.Save();
        }

        private void PreviewKeyDown(PreviewKeyDownEventArgs e, Action<KeyStroke> postPressAction)
        {
            var keyStroke = KeyStroke.FromKeys(e.KeyCode, e.Shift, e.Control, e.Alt);
            if (keyStroke == null)
                return;
            if (postPressAction != null)
                postPressAction(keyStroke);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var controls = GetCommonControls();
            EnableControls(controls, running);
            running = !running;
            startButton.Text = running ? "Start" : "Stop";
            EnableWatcher(running);
        }

        private void EnableWatcher(bool enable)
        {
            if (enable)
            { 
                var onKey = KeyStroke.FromString(Settings.Default.StartOn);
                var offKey = KeyStroke.FromString(Settings.Default.StopOn);
                watcher = new KeyboardWatcher(onKey, offKey);
                watcher.KeyOffFired += Watcher_KeyOffFired;
                watcher.KeyOnFired += Watcher_KeyOnFired;
                watcher.Start();
            }
        }

        void Watcher_KeyOnFired(object sender, EventArgs e)
        {
            if (cliker != null)
                return;
            cliker = new Clicker(Settings.Default.ClickDelay, Settings.Default.DoubleClick);
            cliker.Start();
        }

        void Watcher_KeyOffFired(object sender, EventArgs e)
        {
            if (cliker == null)
                return;
            cliker.Stop();
            cliker = null;
        }

        private void EnableControls(Control[] controls, bool enable)
        {
            foreach (var control in controls)
                control.Enabled = enable;
        }

        private Control[] GetCommonControls()
        {
            return new Control[] { startClickingTextBox, stopClickingTextBox, clickEveryTextBox, doubleClickCheckBox };
        }
    }
}

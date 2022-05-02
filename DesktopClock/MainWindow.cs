using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClock
{
    public partial class MainWindow : Form
    {
        private bool DisplaySeconds = true;

        public MainWindow()
        {
            InitializeComponent();
            FormClosing += MainWindow_FormClosing;

            ShowInTaskbar = false;
            LbTime.Text = "";
            LbDate.Text = "";

            UpdateDateTime();

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void MiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateDateTime()
        {
            LbTime.Text = DateTime.Now.ToString(DisplaySeconds ? "HH:mm:ss" : "HH:mm");
            LbDate.Text = DateTime.Now.ToLongDateString();
        }

        private void toggleWindowFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
                FormBorderStyle = FormBorderStyle.Sizable;
            else if (FormBorderStyle == FormBorderStyle.Sizable)
                FormBorderStyle = FormBorderStyle.None;

            toggleWindowFrameToolStripMenuItem.Checked = FormBorderStyle == FormBorderStyle.Sizable;
        }

        private void togglSecondsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplaySeconds = !DisplaySeconds;
            togglSecondsToolStripMenuItem.Checked = DisplaySeconds;
            UpdateDateTime();
        }

        private void selectForegroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color color = SelectColor(LbDate.ForeColor);
            LbDate.ForeColor = color;
            LbTime.ForeColor = color;
        }

        private void selectBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color color = SelectColor(LbDate.BackColor);
            LbDate.BackColor = color;
            LbTime.BackColor = color;
        }

        private void selectBorderColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color color = SelectColor(BackColor);
            BackColor = color;
        }

        private Color SelectColor(Color color)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = color;
            if (dialog.ShowDialog() == DialogResult.OK)
                return dialog.Color;

            return color;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapsLook
{
    public partial class Form1 : Form
    {
        private bool showWindow = true,
            num, caps, scroll;
        private Timer checker;

        public Form1(bool isVisible)
        {
            InitializeComponent();
            Application.Idle += CheckLocks;
            showWindow = isVisible;
            checker = new Timer();
            checker.Tick += new EventHandler(CheckLocks);
            checker.Interval = 250;
            checker.Start();
        }

        private void CheckLocks(object sender, EventArgs e)
        {
            bool oldnum = num,
                oldcaps = caps,
                oldscroll = scroll;

            num = IsKeyLocked(Keys.NumLock);
            caps = IsKeyLocked(Keys.CapsLock);
            scroll = IsKeyLocked(Keys.Scroll);

            if (oldnum != num || oldcaps != caps || oldscroll != scroll)
            {
                numbox.Checked = num;
                capsbox.Checked = caps;
                scrollbox.Checked = scroll;

                UpdateIcon();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showWindowToolStripMenuItem.Checked = showWindow;
            SetWindowVisibility(showWindow);
        }

        private void SetWindowVisibility(bool visible)
        {
            this.ShowInTaskbar = visible;
            this.Visible = visible;
        }

        private void UpdateIcon()
        {
            if(!num && !caps && !scroll)
            {
                notifyIcon1.Icon = Properties.Resources.empty;
                this.Icon = Properties.Resources.empty;
            }

            if(num && !caps && !scroll)
            {
                notifyIcon1.Icon = Properties.Resources.num;
                this.Icon = Properties.Resources.num;
            }

            if (!num && caps && !scroll)
            {
                notifyIcon1.Icon = Properties.Resources.caps;
                this.Icon = Properties.Resources.caps;
            }

            if (!num && !caps && scroll)
            {
                notifyIcon1.Icon = Properties.Resources.scroll;
                this.Icon = Properties.Resources.scroll;
            }

            if (num && caps && !scroll)
            {
                notifyIcon1.Icon = Properties.Resources.numcaps;
                this.Icon = Properties.Resources.numcaps;
            }
            if (num && !caps && scroll)
            {
                notifyIcon1.Icon = Properties.Resources.numscroll;
                this.Icon = Properties.Resources.numscroll;
            }

            if (!num && caps && scroll)
            {
                notifyIcon1.Icon = Properties.Resources.capsscroll;
                this.Icon = Properties.Resources.capsscroll;
            }

            if (num && caps && scroll)
            {
                notifyIcon1.Icon = Properties.Resources.numcapsscroll;
                this.Icon = Properties.Resources.numcapsscroll;
            }

            List<String> tooltip = new List<String>();
            if(num)
            {
                tooltip.Add("Num lock");
            }

            if (caps)
            {
                tooltip.Add("Caps lock");
            }

            if (scroll)
            {
                tooltip.Add("Scroll lock");
            }

            if (tooltip.Count > 0) {
                notifyIcon1.Text = String.Join("\n", tooltip);
            } else
            {
                notifyIcon1.Text = "Nothing locked";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Idle -= CheckLocks;
            checker.Stop();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showWindow = !showWindow;
            showWindowToolStripMenuItem.Checked = showWindow;
            SetWindowVisibility(showWindow);
        }
    }
}

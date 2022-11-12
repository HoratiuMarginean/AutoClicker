using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        private Thread clickerThread;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (Clicker.isStopped)
            {
                Clicker.isStopped = false;

                clickerThread = new Thread(() => Clicker.StartLeftClicking((int)numericUpDownDelay.Value));
                clickerThread.Start();

                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (!Clicker.isStopped)
            {
                Clicker.isStopped = true;

                if (clickerThread != null && clickerThread.IsAlive)
                {
                    clickerThread.Join();
                }

                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
            }
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            Clicker.isInsideAppWindow = true;
            Debug.WriteLine("Inside");
        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            Clicker.isInsideAppWindow = false;
            Debug.WriteLine("Outside");
        }
    }
}

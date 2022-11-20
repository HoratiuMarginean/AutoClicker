using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
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

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            if (ClientRectangle.Contains(PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y))) &&
                !Clicker.isInsideAppWindow)
            {
                Clicker.isInsideAppWindow = true;
            }
        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            if (!ClientRectangle.Contains(PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y))) &&
                Clicker.isInsideAppWindow)
            {
                Clicker.isInsideAppWindow = false;
            }
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (Clicker.isStopped)
            {
                buttonStartStop.Enabled = false;

                Clicker.isStopped = false;

                clickerThread = new Thread(() => Clicker.StartLeftClicking((int)numericUpDownDelay.Value));
                clickerThread.Start();

                labelActiveInactive.Text = "ACTIVE";
                labelActiveInactive.ForeColor = Color.DarkGreen;

                buttonStartStop.Text = "STOP";
                buttonStartStop.Enabled = true;
            }
            else
            {
                buttonStartStop.Enabled = false;

                Clicker.isStopped = true;

                if (clickerThread != null && clickerThread.IsAlive)
                {
                    clickerThread.Join();
                }

                labelActiveInactive.Text = "INACTIVE";
                labelActiveInactive.ForeColor = Color.DarkRed;

                buttonStartStop.Text = "START";
                buttonStartStop.Enabled = true;
            }
        }
    }
}

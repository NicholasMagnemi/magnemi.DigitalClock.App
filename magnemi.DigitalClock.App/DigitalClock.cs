using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magnemi.DigitalClock.App
{
    public partial class frmDigitalClock : Form
    {
        public frmDigitalClock()
        {
            InitializeComponent();
        }

        private void frmDigitalClock_Load(object sender, EventArgs e)
        {
            lblTimeDisplay.Text = DateTime.Now.ToString("h:mm:ss tt"); // Only used to set the time as the Computers Current Time.
        }

        private void tmrAdvanceClock_Tick(object sender, EventArgs e)
        {
            Time clock = new Time(lblTimeDisplay.Text);

            lblTimeDisplay.Text = clock.showTime();
        }

        private void btnExitApplication_MouseHover(object sender, EventArgs e)
        {
            btnExitApplication.BackColor = SystemColors.ControlDark;
        }

        private void btnExitApplication_MouseLeave(object sender, EventArgs e)
        {
            btnExitApplication.BackColor = SystemColors.ControlLight;
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

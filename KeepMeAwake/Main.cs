using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using KeepMeAwake.Business;
using System.Diagnostics;

namespace KeepMeAwake
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Methods.SetWindowPos(this.Handle, Methods.HWND_TOPMOST, 0, 0, 0, 0, Methods.TOPMOST_FLAGS);
                statusbar1.Items[0].Text = "Data e Hora Locais : " + DateTime.Now;
            }
            catch (Exception expt)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Methods.LeftClick();
        }

        private void clocktimer_Tick(object sender, EventArgs e)
        {
            statusbar1.Items[0].Text = "Data e Hora Locais : " + DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            automationtimer.Enabled = true;
            controllertimer.Enabled = true;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            automationtimer.Enabled = false;
            controllertimer.Enabled = false;
            lblvstatus.Text = "PARADO";
            lblvstatus.ForeColor = Color.Red;
            lblvtempo.Text = "00:00:00";
        }

        private void controllertimer_Tick(object sender, EventArgs e)
        {
            lblvstatus.Text = "EXECUTANDO";
            lblvstatus.ForeColor = Color.DarkGreen;
            lblvtempo.Text = Convert.ToString(DateTime.UtcNow - Process.GetCurrentProcess().StartTime.ToUniversalTime()).Substring(0,8);        
        }
    }
}

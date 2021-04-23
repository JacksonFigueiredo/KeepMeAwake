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
                statusbar1.Items[0].Text = "Data e Hora Locais : " + DateTime.UtcNow;
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
            statusbar1.Items[0].Text = "Data e Hora Locais : " + DateTime.UtcNow;
        }
    }
}

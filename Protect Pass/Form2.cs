using Protect_Pass.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protect_Pass
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void exitclick_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitclick_MouseHover(object sender, EventArgs e)
        {
            exitclick.Image = Resources.exit_button;
        }

        private void exitclick_MouseLeave(object sender, EventArgs e)
        {
            exitclick.Image = Resources.exitbtn;
        }

        private void miniclick_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void miniclick_MouseHover(object sender, EventArgs e)
        {
            miniclick.Image = Resources.minimalize_button;
        }

        private void miniclick_MouseLeave(object sender, EventArgs e)
        {
            miniclick.Image = Resources.minimalize_btn;
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

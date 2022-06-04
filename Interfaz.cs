using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensajeria
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void TimerAbrir_Tick(object sender, EventArgs e)
        {
            if (PnlInfo.Width < 320)
            {
                PnlInfo.Width = PnlInfo.Width + 20;
            }
            else
            {
                TimerAbrir.Stop();
            }
        }

        private void TimerCerrar_Tick(object sender, EventArgs e)
        {
            if (PnlInfo.Width > 0)
            {
                PnlInfo.Width = PnlInfo.Width - 20;
            }
            else
            {
                TimerCerrar.Stop();
            }
        }

        private void CPtbPerfil_Click(object sender, EventArgs e)
        {
            CPtbInfoPerfil.BackgroundImage = CPtbPerfil.BackgroundImage;
            TimerAbrir.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimerCerrar.Start();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }

            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

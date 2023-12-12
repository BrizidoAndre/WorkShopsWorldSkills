using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Enabled = true;

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                CapslockLabel.Visible = true;
            }
            else
            {
                CapslockLabel.Visible = false;
            }
        }

        private void CadastreText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CadastroPage().Show();
        }
    }
}

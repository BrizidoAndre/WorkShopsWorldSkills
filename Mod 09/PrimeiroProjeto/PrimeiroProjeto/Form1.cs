using PrimeiroProjeto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class Form1 : Form
    {
        TesteEntities ctx = new TesteEntities(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {

            var user = ctx.Usuario.FirstOrDefault( z => z.Email == TxtEmail.Text);

            if (user != null)
            {
                MessageBox.Show($"O usuário {user.Nome} foi encontrado!");

                return;
            }

            MessageBox.Show("O Usuário não foi encontrado!");
        }
    }
}

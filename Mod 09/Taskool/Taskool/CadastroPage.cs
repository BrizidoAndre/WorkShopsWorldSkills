using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taskool.Model;

namespace Taskool
{
    public partial class CadastroPage : Form
    {
        TesteEntities3 ctx = new TesteEntities3();
        public CadastroPage()
        {
            InitializeComponent();
        }

        private void CadastroPage_Load(object sender, EventArgs e)
        {

        }

        private void Cor_Click(object sender, EventArgs e)
        {

        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeText_Click(object sender, EventArgs e)
        {

        }

        private void ApelidoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApelidoText_Click(object sender, EventArgs e)
        {

        }

        private void SenhaInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void SenhaText_Click(object sender, EventArgs e)
        {

        }

        private void EmailText_Click(object sender, EventArgs e)
        {

        }

        private void CorInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmailInput.Text == "" || SenhaInput.Text == "" || UsernameInput.Text == "" || TelefoneInput.Text == "" || NomeInput.Text == "")
            {
                MessageBox.Show("É necessário prencher todos os campos");
                return;
            }

            Usuario users = new Usuario();


            users.Email = EmailInput.Text;
            users.Nome = NomeInput.Text;
            users.Telefone = TelefoneInput.Text;
            users.Username = UsernameInput.Text;
            users.Nascimento = dateTimePicker1.Value;

           ctx.Usuario.Add(users);
           ctx.SaveChanges();

            MessageBox.Show("Usuario Cadastrado com sucesso");

            this.Close();
        }
    }
}

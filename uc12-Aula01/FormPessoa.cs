using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uc12_Aula01
{
    public partial class FormPessoa : Form
    {
        public FormPessoa(Pessoa pessoa)
        {
            InitializeComponent();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormPessoa_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Nome = this.txtNome.Text;
            p.Cpf = this.txtCPF.Text;
            p.NomeSocial = this.txtNomeSocial.Text;
            FrmPerfil perfil = new FrmPerfil(p);
            this.Hide();
            perfil.Show();
        }

        private void txtNomeSocial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

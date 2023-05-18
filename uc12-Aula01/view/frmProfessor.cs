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
    public partial class frmProfessor : Form
    {
        public frmProfessor(Pessoa p)
        {
            InitializeComponent();
            this.txtNome.Text = p.Nome;
            this.txtCpf.Text = p.Cpf;
            this.txtNomeSocial.Text = p.NomeSocial;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}

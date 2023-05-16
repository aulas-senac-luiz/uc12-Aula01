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
    public partial class FrmEscola : Form
    {
        public FrmEscola(Escola e)
        {
            InitializeComponent();
            this.txtNome.Text = e.nome;
            this.txtCnpj.Text = e.getCnpj();
            this.txtEndereco.Text = e.endereco;
        }

        private void FrmEscola_Load(object sender, EventArgs e)
        {

        }

        private void Encerrar(object sender, FormClosedEventArgs e)
        {
            Inicio telaAnterior = new Inicio();
            telaAnterior.Show();
        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnEscola_Click(object sender, EventArgs e)
        {
            Escola e2;
            e2 = new Escola();
            e2.nome = "Senac Aclimação";
            e2.endereco = "R. Pires da Mota, 838";
            e2.setCnpj("03.709.814 / 0073 - 61");
            Pessoa professorInformatica;
            FrmEscola tela;
            tela = new FrmEscola(e2);
             
            tela.Show();
            this.Hide();
        }
        public bool Encerrar()
        {
            System.Windows.Forms.Application.ExitThread();
            return true;
        }
        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Encerrar(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnPessoa_Click(object sender, EventArgs e){
            Pessoa pessoa = new Pessoa();
            FormPessoa tela = new FormPessoa(pessoa);
            this.Hide();
            tela.Show();
        }
    }
}

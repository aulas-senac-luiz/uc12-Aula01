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
    public partial class FrmPerfil : Form
    {
        Pessoa pessoa;//this
        public FrmPerfil(Pessoa p)
        {
            InitializeComponent();
            this.pessoa = p;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmProfessor tela = new frmProfessor(this.pessoa);
            tela.Show();
        }
    }
}

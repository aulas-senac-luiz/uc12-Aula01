using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uc12_Aula01
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Escola e1 = new Escola("Senac Santana - ANA", "03.709.814/ddasdaasdasvxcvxc0001-98", "Rua Voluntários da Pátria, 3167, Santana");
            
            if (e1.getCnpj()==null)
            {
                MessageBox.Show("CNPJ Inválido");
                return;
            }

            Escola e2 = new Escola();

            e2.nome = "Senac Aclimação";
            e2.endereco = "R. Pires da Mota, 838";
            e2.setCnpj("03.709.81dsadsadsadas4 / 0073 - 62");
            Application.Run(new FrmEscola(e2));

       
            
            

        }
    }
}

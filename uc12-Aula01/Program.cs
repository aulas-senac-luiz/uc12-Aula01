using MySql.Data.MySqlClient;
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
            
            /*BancoDeDados bd = new BancoDeDados();
            MySqlConnection con = bd.conectar();
            string sql = "insert into teste.aluno(a,b) values(2,3);";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MessageBox.Show(cmd.ExecuteNonQuery().ToString());*/
            
            Application.Run(new Inicio());

        }
    }
}

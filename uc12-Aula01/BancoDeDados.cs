using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc12_Aula01
{
    public class BancoDeDados
    {
        static string conexao = "server=localhost;port=3306;database=teste;uid=root;password=";
        static MySqlConnection connection;
        public MySqlConnection conectar()
        {
            connection = new MySqlConnection(conexao);
            if (!connection.State.HasFlag(ConnectionState.Open)) 
            {
                connection.Close();
                connection.Open();
            }
            return connection;
        }

    }
}

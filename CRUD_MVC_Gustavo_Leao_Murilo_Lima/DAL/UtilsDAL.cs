using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_Gustavo_Leao_Murilo_Lima.DAL
{
    internal class UtilsDAL
    {
        public static MySqlConnection GetConnection()
        {
            //oobjeto "builder" irá conter os dados de conexão
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "cod_usuarios",
                UserID = "root",
                Password = ""
            };

            //criando a conexão
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            return connection;
        }
    }
}

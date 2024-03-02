using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Biometrico1
{
    internal class ConexionMysql : Conexion
    {
        private MySqlConnection connection;
        private string cadenaConexion;
        public ConexionMysql()
        {
            cadenaConexion = "Database= " + database +
                "; DataSource= " + server +
                "; User Id= " + user +
                "; Password= " + password;

            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return connection;
        }

    }
}

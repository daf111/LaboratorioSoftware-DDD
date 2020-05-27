using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InfraestructuraDatos.MySQL
{
    public class BaseDeDatos
    {

        private static BaseDeDatos _instancia = null;
        private string stringConexion = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLServerConnection"].ConnectionString;
        private MySqlConnection conexion = null;

        private BaseDeDatos()
        {
            try
            {
                this.conexion = new MySqlConnection(stringConexion);
                this.conexion.Open();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static BaseDeDatos getIntancia()
        {
            if (_instancia == null)
            {
                _instancia = new BaseDeDatos();
            }
            return _instancia;
        }

        public MySqlConnection getConexion()
        {
            return _instancia.conexion;
        }

        public static T GetDataValue<T>(MySqlDataReader dr, string columna)
        {
            int i = dr.GetOrdinal(columna);
            if (!dr.IsDBNull(i))
            {
                return (T)dr.GetValue(i);
            }
            else
            {
                return default(T);
            }
        }
    }
}

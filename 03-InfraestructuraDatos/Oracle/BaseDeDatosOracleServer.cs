using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InfraestructuraDatos.Oracle
{
    public class BaseDeDatosOracleServer
    {

        private static BaseDeDatosOracleServer _instancia = null;
        private string stringConexion = "Data Source=.;Initial Catalog=laboratorio-software;User ID=test;Password=test";
        private SqlConnection conexion = null;

        private BaseDeDatosOracleServer()
        {
            try
            {
                this.conexion = new SqlConnection(stringConexion);
                this.conexion.Open();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static BaseDeDatosOracleServer getIntancia()
        {
            if (_instancia == null)
            {
                _instancia = new BaseDeDatosOracleServer();
            }
            return _instancia;
        }

        public SqlConnection getConexion()
        {
            return _instancia.conexion;
        }

        public static T GetDataValue<T>(SqlDataReader dr, string columna)
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

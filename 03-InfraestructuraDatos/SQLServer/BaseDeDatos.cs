using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InfraestructuraDatos.SQLServer
{
    public class BaseDeDatos
    {

        private static BaseDeDatos _instancia = null;
        private string stringConexion = System.Configuration.ConfigurationManager.ConnectionStrings["SQLServerConnection"].ConnectionString;
        private SqlConnection conexion = null;

        private BaseDeDatos()
        {
            try
            {
                this.conexion = new SqlConnection(stringConexion);
                this.conexion.Open();
            } catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                _04_InfraestructuraTransversal.Bitacora.GuardarExcepcion(ex);
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

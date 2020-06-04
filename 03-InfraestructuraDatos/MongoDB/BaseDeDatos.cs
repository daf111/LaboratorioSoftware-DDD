using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InfraestructuraDatos.MongoDB
{
    public class BaseDeDatos
    {

        private static BaseDeDatos _instancia = null;
        private string stringDeConexion = System.Configuration.ConfigurationManager.ConnectionStrings["MongoDBConnection"].ConnectionString;
        private MongoClient conexion = null;
        private IMongoDatabase database = null;

        private BaseDeDatos()
        {
            try
            {
                conexion = new MongoClient(stringDeConexion);
                database = conexion.GetDatabase("laboratorio-software");
            }

            catch (Exception e)
            {
                //Console.Write(e.Message);
                _04_InfraestructuraTransversal.Bitacora.GuardarExcepcion(e);
            }
        }

        public static BaseDeDatos getInstancia()
        {
            if (_instancia == null)
            {
                if (_instancia == null)
                {
                    _instancia = new BaseDeDatos();
                }
            }
            return _instancia;
        }

        public IMongoDatabase getConexion()
        {
            return _instancia.database;
        }

        public static T GetDataValue<T>(BsonDocument dr, string columnName)
        {
            return (T)dr.GetElement(columnName).Value.RawValue;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Dominio.Entidades;
using MongoDB.Driver;
using MongoDB.Bson;

namespace _03_InfraestructuraDatos.MongoDB
{
    public class TipoProductoRepositorio : _02_Dominio.Repositorio.IRepositorio<_02_Dominio.Entidades.TipoProducto>
    {
        public TipoProducto Actualizar(TipoProducto entidad)
        {
            throw new NotImplementedException();
        }

        public TipoProducto Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public TipoProducto Guardar(TipoProducto entidad)
        {
            throw new NotImplementedException();
        }

        public List<TipoProducto> Leer()
        {
            List<TipoProducto> result = new List<TipoProducto>();
            IMongoDatabase conexion = BaseDeDatos.getInstancia().getConexion();
            IMongoCollection<BsonDocument> collection = conexion.GetCollection<BsonDocument>("categorias", null);
            var document = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument dr in document)
            {
                TipoProducto tipoProducto = MapeoTipoProducto(dr);
                result.Add(tipoProducto);
            }
            return result;
        }

        public TipoProducto LeerPor(int id)
        {
            throw new NotImplementedException();
        }

        private TipoProducto MapeoTipoProducto(BsonDocument dr)
        {
            TipoProducto tipoServicio = new TipoProducto();
            tipoServicio.Id = BaseDeDatos.GetDataValue<int>(dr, "id");
            tipoServicio.Nombre = BaseDeDatos.GetDataValue<string>(dr, "name");
            return tipoServicio;
        }
    }
}

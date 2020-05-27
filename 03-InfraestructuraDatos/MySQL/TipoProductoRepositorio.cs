using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace _03_InfraestructuraDatos.MySQL
{
    public class TipoProductoRepositorio : _02_Dominio.Repositorio.IRepositorio<_02_Dominio.Entidades.TipoProducto>
    {
        public _02_Dominio.Entidades.TipoProducto Actualizar(_02_Dominio.Entidades.TipoProducto entidad)
        {
            throw new NotImplementedException();
        }

        public _02_Dominio.Entidades.TipoProducto Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public _02_Dominio.Entidades.TipoProducto Guardar(_02_Dominio.Entidades.TipoProducto entidad)
        {
            throw new NotImplementedException();
        }

        public List<_02_Dominio.Entidades.TipoProducto> Leer()
        {
            const string SQL_STATEMENT = "SELECT id, nombre FROM tipo_producto";

            List<_02_Dominio.Entidades.TipoProducto> resultado = new List<_02_Dominio.Entidades.TipoProducto>();
            using (MySqlConnection conexion = BaseDeDatos.getIntancia().getConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_STATEMENT, conexion);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        _02_Dominio.Entidades.TipoProducto tipoProducto = MapeoTipoProducto(dr);
                        resultado.Add(tipoProducto);
                    }
                }
            }
            return resultado;
        }

        public _02_Dominio.Entidades.TipoProducto LeerPor(int id)
        {
            throw new NotImplementedException();
        }

        private _02_Dominio.Entidades.TipoProducto MapeoTipoProducto(MySqlDataReader dr)
        {
            _02_Dominio.Entidades.TipoProducto tipoProducto = new _02_Dominio.Entidades.TipoProducto();
            tipoProducto.Id = BaseDeDatos.GetDataValue<int>(dr, "id");
            tipoProducto.Nombre = BaseDeDatos.GetDataValue<string>(dr, "nombre");
            return tipoProducto;
        }
    }
}

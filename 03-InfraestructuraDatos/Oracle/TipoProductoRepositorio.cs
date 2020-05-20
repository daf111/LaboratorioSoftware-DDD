using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _03_InfraestructuraDatos.Oracle
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
            using (SqlConnection conexion = BaseDeDatosOracleServer.getIntancia().getConexion())
            {
                SqlCommand cmd = new SqlCommand(SQL_STATEMENT, conexion);
                using (SqlDataReader dr = cmd.ExecuteReader())
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

        private _02_Dominio.Entidades.TipoProducto MapeoTipoProducto(SqlDataReader dr)
        {
            _02_Dominio.Entidades.TipoProducto tipoProducto = new _02_Dominio.Entidades.TipoProducto();
            tipoProducto.Id = BaseDeDatosOracleServer.GetDataValue<int>(dr, "id");
            tipoProducto.Nombre = BaseDeDatosOracleServer.GetDataValue<string>(dr, "nombre");
            return tipoProducto;
        }
    }
}

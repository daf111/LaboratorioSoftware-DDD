using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using _02_Dominio.Entidades;

namespace _03_InfraestructuraDatos.SQLServer
{
    public class TipoProductoRepositorio : _02_Dominio.Repositorio.IRepositorio<_02_Dominio.Entidades.TipoProducto>
    {
        public _02_Dominio.Entidades.TipoProducto Actualizar(_02_Dominio.Entidades.TipoProducto entidad)
        {
            throw new NotImplementedException();
        }

        public _02_Dominio.Entidades.TipoProducto Eliminar(int id)
        {
            string SQL_STATEMENT = "DELETE * FROM tipo_producto where id=" + id;

            TipoProducto resultad = new TipoProducto();
            using (SqlConnection conexion = BaseDeDatosSQLServer.getIntancia().getConexion())
            {
                SqlCommand cmd = new SqlCommand(SQL_STATEMENT);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        _02_Dominio.Entidades.TipoProducto tipoProducto = MapeoTipoProducto(dr);
                        resultad = tipoProducto;
                    }
                }
            }
            return resultad;
        }

        public _02_Dominio.Entidades.TipoProducto Guardar(_02_Dominio.Entidades.TipoProducto entidad)
        {
            throw new NotImplementedException();
        }

       

        public List<_02_Dominio.Entidades.TipoProducto> Leer()
        {
            const string SQL_STATEMENT = "SELECT id, nombre FROM tipo_producto";

            List<_02_Dominio.Entidades.TipoProducto> resultado = new List<_02_Dominio.Entidades.TipoProducto>();
            SqlConnection conexion = BaseDeDatosSQLServer.getIntancia().getConexion();
            SqlCommand cmd = new SqlCommand(SQL_STATEMENT, conexion);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    _02_Dominio.Entidades.TipoProducto tipoProducto = MapeoTipoProducto(dr);
                    resultado.Add(tipoProducto);
                }
            }
            return resultado;
        }

        public _02_Dominio.Entidades.TipoProducto LeerPor(int id)
        {
            
            string SQL_STATEMENT = "SELECT id, nombre FROM tipo_producto where id="+id;

            TipoProducto resultad= new TipoProducto();
            SqlConnection conexion = BaseDeDatosSQLServer.getIntancia().getConexion();
            SqlCommand cmd = new SqlCommand(SQL_STATEMENT, conexion);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    _02_Dominio.Entidades.TipoProducto tipoProducto = MapeoTipoProducto(dr);
                    resultad=tipoProducto;
                }
            }
            return resultad;
        }

        private _02_Dominio.Entidades.TipoProducto MapeoTipoProducto(SqlDataReader dr)
        {
            _02_Dominio.Entidades.TipoProducto tipoProducto = new _02_Dominio.Entidades.TipoProducto();
            tipoProducto.Id = BaseDeDatosSQLServer.GetDataValue<int>(dr, "id");
            tipoProducto.Nombre = BaseDeDatosSQLServer.GetDataValue<string>(dr, "nombre");
            return tipoProducto;
        }
    }
}

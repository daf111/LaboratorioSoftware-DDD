using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using NPoco;

namespace _03_InfraestructuraDatos.NPOCO
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
            List<_02_Dominio.Entidades.TipoProducto> resultado = new List<_02_Dominio.Entidades.TipoProducto>();
            using (IDatabase db = BaseDeDatos.getInstancia())
            {
                resultado = db.Fetch<_02_Dominio.Entidades.TipoProducto>();
            }
            return resultado;
        }

        public _02_Dominio.Entidades.TipoProducto LeerPor(int id)
        {
            throw new NotImplementedException();
        }

    }
}

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
            _02_Dominio.Entidades.TipoProducto nuevoTipo = new _02_Dominio.Entidades.TipoProducto();
            nuevoTipo = entidad;
            using (IDatabase db = BaseDeDatos.getInstancia())
            {
                var nuevoTip = db.SingleById<_02_Dominio.Entidades.TipoProducto>(nuevoTipo.Id);
                nuevoTip.Id = entidad.Id;
                nuevoTip.Nombre = entidad.Nombre;
                db.Update(nuevoTip);
            }
            return nuevoTipo;
        }

        public _02_Dominio.Entidades.TipoProducto Eliminar(int id)
        {
            _02_Dominio.Entidades.TipoProducto nuevoTipo = new _02_Dominio.Entidades.TipoProducto();
            nuevoTipo.Id = id;
            using (IDatabase db = BaseDeDatos.getInstancia())
            {
                var nuevoTip = db.SingleById<_02_Dominio.Entidades.TipoProducto>(nuevoTipo.Id);
                db.Delete(nuevoTip);
            }
            return nuevoTipo;//no deberia ser un void?
        }

        public _02_Dominio.Entidades.TipoProducto Guardar(_02_Dominio.Entidades.TipoProducto entidad)
        {
            _02_Dominio.Entidades.TipoProducto nuevoTipo = new _02_Dominio.Entidades.TipoProducto();
            using (IDatabase db = BaseDeDatos.getInstancia())
            {
                nuevoTipo.Id = entidad.Id;
                nuevoTipo.Nombre = entidad.Nombre;
                db.Insert(nuevoTipo);
            }
            return nuevoTipo;
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
            _02_Dominio.Entidades.TipoProducto nuevoTipo;
            //nuevoTipo.Id = id;
            using (IDatabase db = BaseDeDatos.getInstancia())
            {
                nuevoTipo = db.SingleById<_02_Dominio.Entidades.TipoProducto>(id);
            }
            return nuevoTipo;
        }

    }
}

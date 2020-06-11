using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InfraestructuraDatos.NPOCO
{
    public class ClienteRepositorio : _02_Dominio.Repositorio.IRepositorio<_02_Dominio.Entidades.Cliente>
    {
        public _02_Dominio.Entidades.Cliente Actualizar(_02_Dominio.Entidades.Cliente entidad)
        {
            using (IDatabase db = BaseDeDatos.getInstancia())
            {
                db.Update(entidad);
            }
            return entidad;
        }

        public _02_Dominio.Entidades.Cliente Eliminar(int id)
        {
            _02_Dominio.Entidades.Cliente nuevoTip;
            using (IDatabase db = BaseDeDatos.getInstancia())
            {
                nuevoTip = db.SingleById<_02_Dominio.Entidades.Cliente>(id);
                db.Delete(nuevoTip);
            }
            return nuevoTip;
        }

        public _02_Dominio.Entidades.Cliente Guardar(_02_Dominio.Entidades.Cliente entidad)
        {
            using (IDatabase db = BaseDeDatos.getInstancia())
            {

                db.Insert(entidad);
            }
            return entidad;
        }

        public List<_02_Dominio.Entidades.Cliente> Leer()
        {
            List<_02_Dominio.Entidades.Cliente> resultado = new List<_02_Dominio.Entidades.Cliente>();
            using (IDatabase db = BaseDeDatos.getInstancia())
            {
                resultado = db.Fetch<_02_Dominio.Entidades.Cliente>();
            }
            return resultado;
        }

        public _02_Dominio.Entidades.Cliente LeerPor(int id)
        {
            _02_Dominio.Entidades.Cliente nuevoTipo;
            //nuevoTipo.Id = id;
            using (IDatabase db = BaseDeDatos.getInstancia())
            {
                nuevoTipo = db.SingleById<_02_Dominio.Entidades.Cliente>(id);
            }
            return nuevoTipo;
        }
    }
}

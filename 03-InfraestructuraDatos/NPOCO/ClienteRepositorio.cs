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
        public const string MensajeIdClienteNoExiste = "La secuencia no contiene elementos";
        public _02_Dominio.Entidades.Cliente Actualizar(_02_Dominio.Entidades.Cliente modific)
        {
            using (IDatabase db = BaseDeDatos.getInstancia())
            {
                db.Update(modific);
            }
            return modific;
        }

        public _02_Dominio.Entidades.Cliente Eliminar(int id)
        {
            _02_Dominio.Entidades.Cliente borrar;
            using (IDatabase db = BaseDeDatos.getInstancia())
            {
                borrar = db.SingleById<_02_Dominio.Entidades.Cliente>(id);
                db.Delete(borrar);
            }
            return borrar;
        }

        public _02_Dominio.Entidades.Cliente Guardar(_02_Dominio.Entidades.Cliente nuevo)
        {
            using (IDatabase db = BaseDeDatos.getInstancia())
            {

                db.Insert(nuevo);
            }
            return nuevo;
        }

        public List<_02_Dominio.Entidades.Cliente> Leer()
        {
            List<_02_Dominio.Entidades.Cliente> leerto = new List<_02_Dominio.Entidades.Cliente>();
            using (IDatabase db = BaseDeDatos.getInstancia())
            {
                leerto = db.Fetch<_02_Dominio.Entidades.Cliente>();
            }
            return leerto;
        }

        public _02_Dominio.Entidades.Cliente LeerPor(int id)
        {
            _02_Dominio.Entidades.Cliente leerc;
            using (IDatabase db = BaseDeDatos.getInstancia())
            {
                leerc = db.SingleById<_02_Dominio.Entidades.Cliente>(id);
            }

            if (leerc == null)
            {
                throw new InvalidOperationException(MensajeIdClienteNoExiste);
            }

            return leerc;

            
        }
    }
}

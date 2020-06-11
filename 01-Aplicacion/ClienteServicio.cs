using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class ClienteServicio
    {
        private _02_Dominio.Repositorio.IRepositorio<_02_Dominio.Entidades.Cliente> _repositorio;
        public ClienteServicio(_02_Dominio.Repositorio.IRepositorio<_02_Dominio.Entidades.Cliente> repositorio)
        {
            _repositorio = repositorio;
        }

        public List<_02_Dominio.Entidades.Cliente> Listar()
        {
            return _repositorio.Leer();
        }
        public _02_Dominio.Entidades.Cliente ListarPor(int id)
        {
            return _repositorio.LeerPor(id);
        }
        public _02_Dominio.Entidades.Cliente Guardar(_02_Dominio.Entidades.Cliente nuevo)
        {
            return _repositorio.Guardar(nuevo);
        }
        public _02_Dominio.Entidades.Cliente Eliminar(int id)
        {
            return _repositorio.Eliminar(id);
        }
        public _02_Dominio.Entidades.Cliente Actualizar(_02_Dominio.Entidades.Cliente nuev)
        {
            return _repositorio.Actualizar(nuev);
        }
    }
}

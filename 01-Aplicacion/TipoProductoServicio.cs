using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class TipoProductoServicio
    {
        private _02_Dominio.Repositorio.IRepositorio<_02_Dominio.Entidades.TipoProducto> _repositorio;
        public TipoProductoServicio(_02_Dominio.Repositorio.IRepositorio<_02_Dominio.Entidades.TipoProducto> repositorio)
        {
            _repositorio = repositorio;
        }

        public List<_02_Dominio.Entidades.TipoProducto> Listar()
        {
            return _repositorio.Leer();
        }
        public _02_Dominio.Entidades.TipoProducto ListarPor(int id)
        {
            return _repositorio.LeerPor(id);
        }
        public _02_Dominio.Entidades.TipoProducto Guardar(_02_Dominio.Entidades.TipoProducto nuevo)
        {
            return _repositorio.Guardar(nuevo);
        }
        public _02_Dominio.Entidades.TipoProducto Eliminar(int id)
        {
            return _repositorio.Eliminar(id);
        }
    }
}

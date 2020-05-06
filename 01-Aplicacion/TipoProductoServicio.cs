using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class TipoProductoServicio
    {
        public List<_02_Dominio.Entidades.TipoProducto> Listar()
        {
            _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio repositorio = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();
            return repositorio.Leer();
        }
    }
}

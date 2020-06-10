using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioDeSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            _01_Aplicacion.TipoProductoServicio tipoProductoServicio = kernel.Get<_01_Aplicacion.TipoProductoServicio>();

            List<_02_Dominio.Entidades.TipoProducto> listado = tipoProductoServicio.Listar();
            _02_Dominio.Entidades.TipoProducto tipoProducto = tipoProductoServicio.ListarPor(2);
            _02_Dominio.Entidades.TipoProducto nuevo = new _02_Dominio.Entidades.TipoProducto();
            nuevo.Nombre = "hogar";
            //tipoProductoServicio.Guardar(nuevo);
            //_02_Dominio.Entidades.TipoProducto eliminado = tipoProductoServicio.Eliminar(4);
            tipoProducto.Nombre = "didactico";
            tipoProductoServicio.Actualizar(tipoProducto);

        }
    }
}

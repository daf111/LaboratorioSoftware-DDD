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
        }
    }
}

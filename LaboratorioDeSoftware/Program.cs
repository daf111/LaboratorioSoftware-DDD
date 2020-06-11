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
            nuevo.Nombre = "didactico";
            //tipoProductoServicio.Guardar(nuevo);
            tipoProducto.Nombre = "hogar";
            tipoProductoServicio.Actualizar(tipoProducto);
            //_02_Dominio.Entidades.TipoProducto eliminado = tipoProductoServicio.Eliminar(4);

            _01_Aplicacion.ClienteServicio clienteServicio = new _01_Aplicacion.ClienteServicio(new _03_InfraestructuraDatos.NPOCO.ClienteRepositorio());
            List<_02_Dominio.Entidades.Cliente> listadoC = clienteServicio.Listar();


        }
    }
}

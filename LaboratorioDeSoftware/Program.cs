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
            nuevo.Nombre = "juguetes";
            //tipoProductoServicio.Guardar(nuevo);
            tipoProducto.Nombre = "hogar";
            //tipoProductoServicio.Actualizar(tipoProducto);
            //_02_Dominio.Entidades.TipoProducto eliminado = tipoProductoServicio.Eliminar(4);

            //Aplicando Ninject
            _01_Aplicacion.ClienteServicio clienteServicio = kernel.Get<_01_Aplicacion.ClienteServicio>();
            //_01_Aplicacion.ClienteServicio clienteServicio = new _01_Aplicacion.ClienteServicio(new _03_InfraestructuraDatos.NPOCO.ClienteRepositorio());
            List<_02_Dominio.Entidades.Cliente> listadoC = clienteServicio.Listar();
            _02_Dominio.Entidades.Cliente cliente = clienteServicio.ListarPor(1);//Sirve como un buscador, lo utilizo en Actualizar también
            _02_Dominio.Entidades.Cliente nuevoC = new _02_Dominio.Entidades.Cliente();
            DateTime estafecha = new DateTime(1996, 04, 09);
            nuevoC.Nombre = "nuevo";
            //clienteServicio.Guardar(nuevoC);
            //cliente.Nombre = "Ambar";
            cliente.FechaNac = estafecha;
            clienteServicio.Actualizar(cliente);
            //_02_Dominio.Entidades.Cliente eliminaC = clienteServicio.Eliminar(6);
        }
    }
}

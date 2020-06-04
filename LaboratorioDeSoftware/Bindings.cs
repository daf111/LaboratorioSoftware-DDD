using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioDeSoftware
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<_02_Dominio.Repositorio.IRepositorio<_02_Dominio.Entidades.TipoProducto>>().To<_03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio>();
        }
    }
}

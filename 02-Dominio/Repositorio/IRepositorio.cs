using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.Repositorio
{
    public interface IRepositorio<TEntidad> where TEntidad : Entidades.IEntidad
    {
        List<TEntidad> Leer();
        TEntidad LeerPor(int id);
        TEntidad Guardar(TEntidad entidad);
        TEntidad Actualizar(TEntidad entidad);
        TEntidad Eliminar(int id);
    }
}

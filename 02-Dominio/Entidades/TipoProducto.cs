using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.Entidades
{
    public class TipoProducto : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public bool Validar()
        {
            if (this.Nombre == String.Empty)
            {
                return false;
            }
            return true;
        }
    }
}

using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.Entidades
{
    [TableName("cliente")]
    [PrimaryKey("id")]
    public class Cliente : IEntidad
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("fechaNac")]
        public DateTime FechaNac { get; set; }

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

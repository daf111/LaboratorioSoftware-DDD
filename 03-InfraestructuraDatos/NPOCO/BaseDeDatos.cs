using MySql.Data.MySqlClient;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InfraestructuraDatos.NPOCO
{
    public class BaseDeDatos
    {
        public static Database getInstancia()
        {
            return new Database("SQLServerConnection");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InfraestructuraTransversal
{
    public static class Bitacora
    {

        public static void GuardarExcepcion(Exception ex)
        {
            Desharp.Debug.Log(ex);
        }

        public static void GuardarExcepcion(Object obj, Exception ex)
        {
            Desharp.Debug.Log(obj, Desharp.Level.DEBUG);
            GuardarExcepcion(ex);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    public class _3_Guia_OperadoresLogicos
    {
        public static bool ELogico(bool a, bool b)
        {
            return a && b;
        }
        public static bool OuLogico(bool a, bool b)
        {
            return a || b;
        }

        public static bool Negacao(bool a, bool b)
        {
            return !a;
        }
        public static bool OuExclusivo(bool a, bool b)
        {
            return a ^ b;
        }

    }
}



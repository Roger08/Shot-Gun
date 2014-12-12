using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editeur_Objets
{
    public static class Var
    {
        public static BinaryDatabase fileDB = new BinaryDatabase();
        public static byte currentData;
        public static bool changed;
    }
}

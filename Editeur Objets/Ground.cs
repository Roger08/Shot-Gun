using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editeur_Objets
{
    [Serializable()]
    public class Ground
    {
        public string name;
        public byte pic;
        public bool blocking;

        public Ground()
        {
            name = "";
            pic = 0;
            blocking = false;
        }
    }
}

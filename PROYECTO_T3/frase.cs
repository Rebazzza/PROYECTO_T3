using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_T3
{
    public class frase
    {
        public string fr;
        public int num;

        public frase(string fr, int num)
        {
            this.fr = fr;
            this.num = num;
        }
    }
    public class Nodof
    {
        public Nodof sig = null;
        public frase dato;
    }
}

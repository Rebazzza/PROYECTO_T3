using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_T3
{
    public class Tarea
    {
        public string nombre;
        public string desc;
        public string estado;

        public Tarea(string nombre, string desc, string estado)
        {
            this.nombre = nombre;
            this.desc = desc;
            this.estado = estado;
        }

       
        
    }
}

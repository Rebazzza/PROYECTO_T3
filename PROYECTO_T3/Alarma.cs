using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_T3
{
    public class Alarma
    {
        public string Nombre;
        public string Desc;
        public DateTime Hora;
        public bool estado;

        public Alarma(string nombre, string desc, DateTime hora, bool estado)
        {
            Nombre = nombre;
            Desc = desc;
            Hora = hora;
            this.estado = estado;
        }

    }
}

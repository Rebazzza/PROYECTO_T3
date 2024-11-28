using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_T3
{
    public class Evento
    {
        public string Nombre;
        public string Desc;
        public DateTime Fecha;
        public bool estado;

        public Evento(string nombre, string desc, DateTime fecha, bool estado)
        {
            Nombre = nombre;
            Desc = desc;
            Fecha = fecha;
            this.estado = estado;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\n" + "\n" + "Fecha: " + Fecha.ToString("dd/MM/yyy HH:mm tt") + "Desc: " + Desc;
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_T3
{
    public class Pila
    {
        
        public void insertar (ref NodoP cima, Tarea t)
        {
            NodoP nuevo = new NodoP();
            nuevo.datoT = t;
            if (cima == null)
            {
                cima = nuevo;
            }
            else
            {
                NodoP temp = cima;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }

        }
        public void Mostrar(NodoP cima)
        {
            NodoP temp = cima;
            while (temp != null)
            {

                temp = temp.sig;
            }
        }
        public Tarea Desapilar(ref NodoP Cima)
        {
            Tarea dato = Cima.datoT;

            Cima = Cima.sig;

            return dato;
        }
        public void buscar(string nombre,ref NodoP Cima1, ref NodoP Cima2)
        {
            Tarea aux = null;
            do
            {
                aux = Desapilar(ref Cima1);
                insertar(ref Cima2, aux);
                if (aux.nombre == nombre)
                {
                    Desapilar(ref  Cima2);
                }
            } while (nombre != aux.nombre);
            do
            {
                aux = Desapilar(ref Cima2);
                insertar(ref Cima1, aux);

            } while (Cima2 != null);

        }

    }
}

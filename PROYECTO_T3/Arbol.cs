using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_T3
{
    public class Arbol
    {
        public Nodo raiz_pruncipal = null;
        public bool Ingresar(ref Nodo Raiz, Evento Dato)
        {
            bool au = false;
            if (Raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.datoE = Dato;
                Raiz = nuevo;
                return au = true;
            }   
            else if (DateTime.Compare(Raiz.datoE.Fecha, Dato.Fecha)< 0)
            {
                Ingresar(ref Raiz.der, Dato);
            }
            else if (DateTime.Compare(Raiz.datoE.Fecha, Dato.Fecha) > 0)
            {
                Ingresar(ref Raiz.izq, Dato);
            }
            else
            {
                return au = false;
            }
            return au;
        }
        public void Recorrer(Nodo raiz, int nivel)
        {
            if (raiz == null)
            {
                return;
            }
            else
            {
                Recorrer(raiz.der, nivel + 1);
                for (int i = 0; i < nivel; i++)
                {
                    Console.Write("     ");
                }
                Console.WriteLine(raiz.datoE.Nombre);
                for (int i = 0; i < nivel; i++)
                {
                    Console.Write("     ");
                }

                Console.WriteLine("Fecha: " + raiz.datoE.Fecha);
                for (int i = 0; i < nivel; i++)
                {
                    Console.Write("     ");
                }
                Console.WriteLine(raiz.datoE.Desc);
                {
                    Console.Write("     ");
                }

                Console.WriteLine(" ");
                Recorrer(raiz.izq, nivel + 1);

            }
        }
        public bool EliminarRecursivo(ref Nodo Raiz, DateTime fecha)
        {
            bool va = false;
            if (Raiz == null)
            {
                
                va = false;

            }
            else if (DateTime.Compare(Raiz.datoE.Fecha, fecha) < 0)
            {
                EliminarRecursivo(ref Raiz.der, fecha);
            }
            else if (DateTime.Compare(Raiz.datoE.Fecha, fecha) > 0)
            {
                EliminarRecursivo(ref Raiz.izq, fecha);
            }
            else if (Raiz.datoE.Fecha == fecha)
            {
                if (Raiz.izq == null && Raiz.der == null)
                {
                    Raiz = null;
                    Console.WriteLine("Raiz eliminada");
                }
                else if (Raiz.izq != null && Raiz.der == null)
                {
                    Nodo mayor = Mayor(Raiz.izq);
                    Evento aux = Raiz.datoE;
                    Raiz.datoE = mayor.datoE;
                    mayor.datoE = aux;
                    EliminarRecursivo(ref Raiz.izq, fecha);
                }
                else if (Raiz.izq == null && Raiz.der != null)
                {

                    Nodo menor = Menor(Raiz.der);
                    Evento aux = Raiz.datoE;
                    Raiz.datoE = menor.datoE;
                    menor.datoE = aux;
                    EliminarRecursivo(ref Raiz.der,fecha);
                }
                else 
                {
                    Raiz = null;
                    va = true;
                }
                


            }
            return va;
        }
        public Nodo Menor(Nodo Raiz)
        {
            if (Raiz.izq == null)
            {
                return Raiz;
            }
            else
            {
                return Menor(Raiz.izq);
            }
        }
            public Nodo Mayor(Nodo Raiz)
        {
            if (Raiz.der == null)
            {
                return Raiz;
            }
            else
            {
                return Mayor(Raiz.der);
            }
        }
    }
    }

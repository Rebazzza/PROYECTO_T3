using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_T3
{
    public  class Lista
    {
        
        public void insertar(ref NodoL primero, Tarea t)
        {
            NodoL nuevo = new NodoL();
            nuevo.datoT = t;
            if (primero == null)
            {

                primero = nuevo;
            }
            else
            {
                NodoL temp = primero;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
        }
        public void insertarfrase(ref Nodof primero, frase t)
        {
            Nodof nuevo = new Nodof();
            nuevo.dato = t;
            if (primero == null)
            {

                primero = nuevo;
            }
            else
            {
                Nodof temp = primero;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
        }
        public void mostrar(NodoL primero)
        {
            NodoL temp = primero;
            while (temp != null)
            {

                temp = temp.sig;
            }
        }
        public Tarea eliminar(ref NodoL primero,string n)
        {
            Tarea dato = primero.datoT;
            NodoL temp = primero;
            NodoL ant = null;
            
            while (temp != null)
            {
                if (primero.datoT.nombre == n)
                {
                    primero = primero.sig;
                }
                else if (temp.datoT.nombre == n)    
                {
                    dato = temp.datoT;
                    ant.sig = temp.sig;

                }
                ant = temp;
                temp = temp.sig;
            }   
            
            return dato;
        }
        public bool recorrer(NodoL primero, string nombre)
        {
            bool nuevo = false;
            NodoL temp = primero;
            do
            {
                if (temp == null)
                {
                    return false;
                }
                else if (temp.datoT.nombre == nombre)
                {
                    return true;
                }
                temp = temp.sig;

            } while (temp != null);
            return nuevo;
        }
    }
}

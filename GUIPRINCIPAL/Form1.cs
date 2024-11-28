using PROYECTO_T3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GUIPRINCIPAL
{
    public partial class Form1 : Form
    {
        private Timer timer;


        private Nodo arbol11 = null; //EVENTOS
        private NodoL lista11 = null;//T.Incompletas
        private NodoP pila11 = null;//T.Completas
        private Nodo arbol22 = null;//ALARMAS
        private Nodof frases = null;
        string[] frase = new string[8];

        private Nodo ordenado1 = null;//Eventos 
        
        private Nodo ordenado3 = null;//Alarmas
        



        public Form1()
        {
            InitializeComponent();
            Arbol arbol1 = new Arbol();
            Pila pl = new Pila();
            Lista ls = new Lista();
            pl.insertar(ref pila11, new Tarea("Vacío1", "Vacío", "Completo"));
            ls.insertar(ref lista11, new Tarea("Vacío1", "Vacío", "Incompleto"));
            arbol1.Ingresar(ref arbol11, new Evento("Vacío", "Vacío", DateTime.Parse("1/1/3500"), false));
            arbol1.Ingresar(ref arbol22, new Evento("Vacío", "Vacío", DateTime.Parse("1/1/3500"), false));
            arbol1.Ingresar(ref ordenado1, new Evento("Vacío", "Vacío", DateTime.Parse("1/1/1000"), false));
            
            
            frase[0] = "Tu tiempo es limitado.";
            frase[1] = "Haz que los dias cuenten.";
            frase[2] = "Hoy es el dia perfecto para alcanzar tus metas.";
            frase[3] = "Cada minuto cuenta, haz que valga la pena.";
            frase[4] = "Organízate hoy, disfruta mañana.";
            frase[5] = "Conviértete en el dueño de tu tiempo.";
            frase[6] = "El tiempo no se espera, pero tú puedes dominarlo.";
            frase[7] = "Con cada tarea completada, estás más cerca de tus sueños.";
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += VerificarAlarma;
            timer.Start();
        }
        private void VerificarAlarma(object sender, EventArgs e)
        {
            
            Arbol arbol = new Arbol();
            Random rn = new Random();
            int cont = rn.Next(1, 8);
            label1.Text = frase[cont];
            Evento proxima = null;
            Evento sig = null;
            Evento pasado = null;
            InOrden(arbol22,ref ordenado3);
            if (ordenado3 != null)
            {
                proxima = Menor(ordenado3).datoE;
                if (proxima.estado != false)
                {
                    arbol.EliminarRecursivo(ref ordenado3, proxima.Fecha);

                    
                }
                 
            }
            if (proxima != null && DateTime.Now >= proxima.Fecha && proxima.estado == false)
            {
                SoundPlayer SP = new SoundPlayer("C:\\Users\\ma5ti\\OneDrive\\Documentos\\UPN Mauricio\\Ciclo 4\\Estructura de datos\\Proyecto\\⌚ [EFECTO DE SONIDO] Reloj DESPERTADOR digital ◾  sound effect.wav");
                proxima.estado = true;
                pasado = proxima;
                SP.Play();
                MessageBox.Show(proxima.Nombre + "-" + proxima.Desc + "-" + proxima.Fecha.ToString("dd/MM/yyyy hh:mm:ss tt "));
                SP.Stop();
                arbol.EliminarRecursivo(ref ordenado3, proxima.Fecha);
                labelalarma.Text = "Vacío";
                
            }
            


            InOrden(arbol11, ref ordenado1);

            if (ordenado1 == null || ordenado1.datoE.Nombre == "Vacío" && ordenado1.der == null)
            {
                labelEvento.Text = "Vacío";
            }
            else if (ordenado1.datoE.Nombre == "Vacío" && ordenado1.der != null)
            {
                Nodo menor1 = Menor(arbol11);
                labelEvento.Text = menor1.datoE.Nombre;
            }
            else if (ordenado1 != null || ordenado1.datoE.Nombre != "Vacío")
            {
                Nodo menor1 = Menor(arbol11);
                labelEvento.Text = menor1.datoE.Nombre;
            }
            Nodo ordenado2 = null;//Alarmas
        InOrden(arbol22, ref ordenado2);

            if (ordenado2 == null || ordenado2.datoE.Nombre == "Vacío" && ordenado2.der == null && ordenado2.datoE.estado ==true )
            {
                labelalarma.Text = "Vacío";
            }
            else if (ordenado2.datoE.Nombre == "Vacío" && ordenado2.der != null&&ordenado1.datoE != pasado)
            {
                Nodo menor1 = Menor(arbol22);
                labelalarma.Text = menor1.datoE.Nombre;
            }
            else if (ordenado2 != null || ordenado2.datoE.Nombre != "Vacío"&& ordenado1.datoE != pasado)
            {
                Nodo menor1 = Menor(arbol22);
                labelalarma.Text = menor1.datoE.Nombre;
            }


            if (lista11 == null || lista11.datoT.nombre == "Vacío" && lista11.sig == null)
            {
                labeltarea.Text = "Vacío";
            }
            else if (lista11 != null && lista11.sig != null)
            {
                labeltarea.Text = lista11.sig.datoT.nombre;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = frase[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            EVENTOS ev = new EVENTOS(arbol11,ordenado1);
            ev.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TAREAS tr = new TAREAS(pila11,lista11);
            tr.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ALARMA al = new ALARMA(arbol22);   
            al.ShowDialog();
        }
        private void ActualizarLabel(Nodo orden)
        {
            if (orden != null)
            {

                labelEvento.Text = orden.datoE.Nombre;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }
        
        public void InOrden(Nodo raiz,ref Nodo ordenado)
        {
            Arbol arbol = new Arbol();
            
            if (raiz != null)
            {
                InOrden(raiz.izq,ref ordenado);
                if (raiz.datoE.estado == false)
                { 
                    arbol.Ingresar(ref ordenado, raiz.datoE);

                }
                InOrden(raiz.der,ref ordenado);
            }
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

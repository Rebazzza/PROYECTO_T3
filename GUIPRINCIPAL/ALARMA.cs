using PROYECTO_T3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPRINCIPAL
{
    public partial class ALARMA : Form
    {
        private Nodo arbol22;
        private Timer timer;
        private Nodo ordenado1;
        
        public ALARMA(Nodo arbol2)
        {
            InitializeComponent();
            arbol22 = arbol2;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 4500;
            timer.Tick += VerificarAlarma;
            timer.Start();
        }
        private void VerificarAlarma(object sender, EventArgs e)
        {
            Evento proxima = null;
            InOrden(arbol22);
            if (ordenado1 != null)
            {
                proxima = Menor(ordenado1).datoE;
            }
            if (proxima != null && DateTime.Now >= proxima.Fecha && proxima.estado == false  )
            {

                Arbol arbol = new Arbol();
                SoundPlayer SP = new SoundPlayer("C:\\Users\\ma5ti\\OneDrive\\Documentos\\UPN Mauricio\\Ciclo 4\\Estructura de datos\\Proyecto\\⌚ [EFECTO DE SONIDO] Reloj DESPERTADOR digital ◾  sound effect.wav");
                proxima.estado = true; 
            
            SP.Play();
                MessageBox.Show(proxima.Nombre+"-"+proxima.Desc+"-"+proxima.Fecha.ToString("dd/MM/yyyy hh:mm tt "));
                SP.Stop();
                arbol.EliminarRecursivo(ref ordenado1, proxima.Fecha);
                

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MOSTRARALARMA MA = new MOSTRARALARMA(arbol22);
            MA.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            INGRESARALARMA IA = new INGRESARALARMA(arbol22);
            IA.Show();
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
        private void ALARMA_Load(object sender, EventArgs e)
        {

        }
        public void InOrden(Nodo raiz)
        {
            Arbol arbol = new Arbol();
            if (raiz != null)
            {
                InOrden(raiz.izq);
                if (raiz.datoE.estado == false)
                {
                    arbol.Ingresar(ref ordenado1, raiz.datoE);
                }
                
                InOrden(raiz.der);
            }
        }
    }
}

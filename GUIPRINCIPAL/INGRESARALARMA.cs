using PROYECTO_T3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPRINCIPAL
{
    public partial class INGRESARALARMA : Form
    {
        private Nodo arbol22;
        private Timer t;
        public INGRESARALARMA(Nodo arbol2)
        {
            InitializeComponent();
            arbol22 = arbol2;
            t = new Timer();
            t.Interval = 1000;
            t.Tick += timer1_Tick;
        }

        private void INGRESARALARMA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arbol arbol = new Arbol();
            string hora = textBox4.Text, dia = textBox3.Text;
            string fecha1 = dia + " " + hora + " " + comboBox1.Text;
            DateTime fecha = DateTime.Parse(fecha1);
            Evento ev = new Evento(textBox1.Text, textBox2.Text, fecha, false);
            Ingresar(ref arbol22, ev);
            MessageBox.Show("Alarma agregada correctamente");
            t.Start(); 


        }
        public void Ingresar(ref Nodo Raiz, Evento Dato)
        {
            if (Raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.datoE = Dato;
                Raiz = nuevo;

            }
            else if (DateTime.Compare(Raiz.datoE.Fecha, Dato.Fecha) > 0)
            {
                Ingresar(ref Raiz.izq, Dato);
            }
            else if (DateTime.Compare(Raiz.datoE.Fecha, Dato.Fecha) < 0)
            {
                Ingresar(ref Raiz.der, Dato);
            }
            else
            {
                MessageBox.Show("Elemento ya ingresado");
            }
        } 
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Actual = DateTime.Now;
            if (Actual == arbol22.datoE.Fecha)
            {
                t.Stop();
                MessageBox.Show("A");
                Console.Beep(100, 100);
                
            }
        }
    }
}

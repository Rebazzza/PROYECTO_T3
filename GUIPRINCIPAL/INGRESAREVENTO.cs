using PROYECTO_T3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPRINCIPAL
{
    public partial class INGRESAREVENTO : Form
    {
        private Nodo arbol11;
        private Nodo ordenado1;
        
        public INGRESAREVENTO(Nodo arbol1,Nodo ordenado)
        {
            InitializeComponent();
            arbol11 = arbol1;
            ordenado1 = ordenado;
        }

        private void INGRESAREVENTO_Load(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arbol arbol = new Arbol();

            string hora = textBox4.Text, dia = textBox3.Text;
            string fecha1 = dia + " " + hora + " " + comboBox1.Text;
            DateTime fecha = DateTime.Parse(fecha1);
            Evento ev = new Evento(textBox1.Text, textBox2.Text, fecha, false);
            Ingresar(ref arbol11, ev);
            MessageBox.Show("Evento Agregado Correctamente");


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
        public void InOrden(Nodo raiz)
        {
            Arbol arbol = new Arbol();
            if (raiz != null)
            {
                InOrden(raiz.izq);
                arbol.Ingresar(ref ordenado1, raiz.datoE);
                InOrden(raiz.der);
            }
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUIPRINCIPAL
{
    public partial class MOSTRARTAREA : Form
    {
        private NodoL primero1;
        private NodoP cima1;
        public MOSTRARTAREA(NodoP cima, NodoL primero)
        {
            InitializeComponent();
            cima1 = cima;
            primero1 = primero;
        }
        private void ActualizarLabel(NodoL primero)
        {
            if (primero != null)
            {
                label6.Text = primero.datoT.nombre;
                label4.Text = primero.datoT.desc;
                label1.Text = primero.datoT.estado;
            }
        }
        private void MOSTRARTAREA_Load(object sender, EventArgs e)
        {

            Lista ls = new Lista();
            if (primero1.datoT.nombre == "Vacío1" && primero1.sig == null)
            {
                label6.Text = "Vacío";
                label4.Text = "Vacío";
                label1.Text = "Vacío";
            }
            else if (primero1.datoT.nombre == "Vacío1" && primero1.sig != null)
            {
                label6.Text = primero1.sig.datoT.nombre;
                label4.Text = primero1.sig.datoT.desc;
                label1.Text = primero1.sig.datoT.estado;
            }
            else if (primero1 != null)
            {
                label6.Text = primero1.datoT.nombre;
                label4.Text = primero1.datoT.desc;
                label1.Text = primero1.datoT.estado;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (primero1.sig != null)
            {
                primero1 = primero1.sig;
                ActualizarLabel(primero1); 
            }
            else
            {
                MessageBox.Show("No hay mas tareas.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pila pl = new Pila();
            Lista ls = new Lista();


            if (ls.recorrer(primero1, label6.Text) == false)
            {
                MessageBox.Show("Elemento no encontrado");
            }
            else
            {
                NodoP nuevo = new NodoP();
                nuevo.datoT = ls.eliminar(ref primero1, label6.Text);
                nuevo.datoT.estado = "Completo";
                pl.insertar(ref cima1, nuevo.datoT);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

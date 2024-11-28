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
    public partial class MostrarCompletos : Form
    {

        private NodoP cima1;
        public MostrarCompletos(NodoP cima)
        {
            InitializeComponent();
            cima1 = cima;
        }
        private void ActualizarLabel(NodoP primero)
        {
            if (primero != null)
            {
                label6.Text = primero.datoT.nombre;
                label4.Text = primero.datoT.desc;
                label1.Text = primero.datoT.estado;
            }
            else if (cima1 == null )
            {
                label6.Text = "Vacío";
                label4.Text = "Vacío";
                label1.Text = "Vacío";
            }
        }
        private void MostrarCompletos_Load(object sender, EventArgs e)
        {
            Pila pila = new Pila();

            if (cima1.datoT.nombre == "Vacío1" && cima1.sig == null)
            {
                label6.Text = "Vacío";
                label4.Text = "Vacío";
                label1.Text = "Vacío";
            }
            else if (cima1.datoT.nombre == "Vacío1" && cima1.sig != null)
            {
                label6.Text = cima1.sig.datoT.nombre;
                label4.Text = cima1.sig.datoT.desc;
                label1.Text = cima1.sig.datoT.estado;
            }
            else if (cima1 != null)
            {
                label6.Text = cima1.datoT.nombre;
                label4.Text = cima1.datoT.desc;
                label1.Text = cima1.datoT.estado;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (cima1.sig != null)
                {
                cima1 = cima1.sig;
                    ActualizarLabel(cima1);
                }
                else
                {
                    MessageBox.Show("No hay mas tareas.");
                }
            
        }
    }
}

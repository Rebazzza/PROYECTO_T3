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
    public partial class MOSTRAREVENTO : Form
    {
        private Nodo arbol11;
        private Nodo ordenado1;

        public MOSTRAREVENTO(Nodo arbol1)
        {

            InitializeComponent();
            arbol11 = arbol1;
        }
        private void ActualizarLabel(Nodo orden)
        {
            
            if (orden != null)
            {
                
                labelNombre.Text = orden.datoE.Nombre;
                labelFecha.Text = orden.datoE.Fecha.ToString("dd/MM/yyyy hh:mm tt");
                labelDesc.Text = orden.datoE.Desc;
            }
            else if (orden == null)
            {
                labelNombre.Text = "Vacío";
                labelFecha.Text = "Vacío";
                labelDesc.Text = "Vacío";
            }
        }
        
        private void MOSTRAREVENTO_Load(object sender, EventArgs e)
        {

            InOrden(arbol11);

            if (ordenado1 == null || ordenado1.datoE.Nombre == "Vacío" && ordenado1.der == null)
            {
                labelNombre.Text = "Vacío";
                labelFecha.Text = "Vacío";
                labelDesc.Text = "Vacío";
            }
            else if (ordenado1.datoE.Nombre == "Vacío" && ordenado1.der != null)
            {
                labelNombre.Text = ordenado1.der.datoE.Nombre;
                labelFecha.Text = ordenado1.der.datoE.Fecha.ToString("dd/MM/yyyy hh:mm tt");
                labelDesc.Text = ordenado1.der.datoE.Desc;
            }
            else if (ordenado1!=null || ordenado1.datoE.Nombre != "Vacío")
            {
                labelNombre.Text = ordenado1.datoE.Nombre;
                labelFecha.Text = ordenado1.datoE.Fecha.ToString("dd/MM/yyyy hh:mm tt");
                labelDesc.Text = ordenado1.datoE.Desc;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ordenado1 != null && ordenado1.der != null && ordenado1.der.datoE.Nombre != "Vacío")
            {
                ordenado1 = ordenado1.der;
                ActualizarLabel(ordenado1);
            }
            else if (ordenado1.der.datoE.Nombre == "Vacío")
            {
                MessageBox.Show("No hay mas eventos.");
            }
            else
            {
                MessageBox.Show("No hay mas eventos.");
            }
        }
        public void InOrden(Nodo raiz)
        {
            Arbol arbol = new Arbol();
            if (raiz != null)
            {
                InOrden(raiz.izq);
                arbol.Ingresar(ref ordenado1,raiz.datoE);
                InOrden(raiz.der);
            }
        }
        private void alarma(Nodo arbol)
        {
            bool aux = false;
            while (aux == false)
            {
                if (arbol.datoE.Fecha == DateTime.Now)
                {
                    MessageBox.Show("a");
                    aux = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Arbol arbol = new Arbol();


            arbol.EliminarRecursivo(ref arbol11, DateTime.Parse(labelFecha.Text));
            arbol.EliminarRecursivo(ref ordenado1 , DateTime.Parse(labelFecha.Text));

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

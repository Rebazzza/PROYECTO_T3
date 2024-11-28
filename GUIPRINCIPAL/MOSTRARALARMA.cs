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
    public partial class MOSTRARALARMA : Form
    {
        private Nodo arbol22;
        private Nodo ordenado;
        public MOSTRARALARMA(Nodo arbol2)
        {
            InitializeComponent();
            arbol22 = arbol2;
        }

        private void MOSTRARALARMA_Load(object sender, EventArgs e)
        {
            Arbol arbol = new Arbol();
            
            InOrden(arbol22);
            if(ordenado.datoE.Nombre=="Vacío") 
            {

            }
            else if (ordenado != null)
            {
                labelNombre.Text = ordenado.datoE.Nombre;
                labelDia.Text = ordenado.datoE.Fecha.ToString("dd/MM/yyyy");
                labelHora.Text = ordenado.datoE.Fecha.ToString("HH:mm:ss tt");
                labelDesc.Text = ordenado.datoE.Desc;
            }
            if (ordenado == null)
            {
                labelNombre.Text = "Vacío";
                labelDia.Text = "Vacío";
                labelHora.Text = "Vacío";
                labelDesc.Text = "Vacío";
            }
        }
        private void ActualizarLabel(Nodo orden)
        {
            if (orden.datoE.Nombre=="Vacío" && orden.der == null )
            {
                labelNombre.Text = "Vacío";
                labelDia.Text = "Vacío";
                labelHora.Text = "Vacío";
                labelDesc.Text = "Vacío";
            }
            else if (orden.datoE.Nombre == "Vacío" && orden.der != null)
            {
                labelNombre.Text = orden.der.datoE.Nombre;
                labelDia.Text = orden.der.datoE.Fecha.ToString("dd/MM/yyyy");
                labelHora.Text = orden.der.datoE.Fecha.ToString("HH:mm:ss tt");
                labelDesc.Text = orden.der.datoE.Desc;
            }
            else if (orden != null)
            {

                labelNombre.Text = orden.datoE.Nombre;
                labelDia.Text = orden.datoE.Fecha.ToString("dd/MM/yyyy");
                labelHora.Text = orden.datoE.Fecha.ToString("HH:mm:ss tt");
                labelDesc.Text = orden.datoE.Desc;
            }
        }
       
        public void InOrden(Nodo raiz)
        {
            Arbol arbol = new Arbol();
            if (raiz != null)
            {
                InOrden(raiz.izq);
                arbol.Ingresar(ref ordenado, raiz.datoE);
                InOrden(raiz.der);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ordenado != null && ordenado.der != null && ordenado.der.datoE.Nombre!="Vacío" )
            {
                ordenado = ordenado.der;
                ActualizarLabel(ordenado);
            }
            else if ( ordenado.der.datoE.Nombre == "Vacío"   )
            {
                MessageBox.Show("No hay mas alarmas.");
            }
            else
            {
                MessageBox.Show("No hay mas alarmas.");
            }
        }
    }
}

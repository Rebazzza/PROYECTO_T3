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
using System.Xml.Linq;

namespace GUIPRINCIPAL
{
    public partial class EVENTOS : Form
    {
        private Nodo arbol1;
        private Nodo ordenado1;
        public EVENTOS(Nodo arbol, Nodo ordenado)
        {
            InitializeComponent();
            arbol1 = arbol;
            ordenado1 = ordenado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            INGRESAREVENTO IE = new INGRESAREVENTO(arbol1,ordenado1);
            IE.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MOSTRAREVENTO ME = new MOSTRAREVENTO(arbol1); 
            ME.ShowDialog();
        }

        private void EVENTOS_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ELIMINAREVENTO EE = new ELIMINAREVENTO(arbol1);
            EE.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

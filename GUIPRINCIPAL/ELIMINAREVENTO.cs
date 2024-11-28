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
    public partial class ELIMINAREVENTO : Form
    {
        private Nodo arbol11;
        public ELIMINAREVENTO(Nodo arbol1)
        {
            InitializeComponent();

            arbol11 = arbol1;
        }

        private void ELIMINAREVENTO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arbol arbol = new Arbol();
            string hora = textBox2.Text, dia = textBox1.Text;
            string fecha1 = dia +" "+ hora+" " + comboBox1.Text ;
            arbol.EliminarRecursivo(ref arbol11, DateTime.Parse(fecha1));
            

            
        }
        

    }
}

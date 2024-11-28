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
    public partial class TAREAS : Form
    {
        private NodoL primero1;
        private NodoP cima1;
        public TAREAS(NodoP cima, NodoL primero11)
        {
            InitializeComponent();
            cima1 = cima;
            primero1 = primero11;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INGRESARTAREA IT = new INGRESARTAREA(cima1,primero1);
            IT.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MOSTRARTAREA MT = new MOSTRARTAREA(cima1,primero1);
            MT.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            COMPLETAR CP = new COMPLETAR(primero1,cima1);
            CP.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarCompletos MC = new MostrarCompletos(cima1);
            MC.ShowDialog();
        }

        private void TAREAS_Load(object sender, EventArgs e)
        {

        }
    }
}

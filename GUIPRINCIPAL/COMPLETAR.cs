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
    public partial class COMPLETAR : Form
    {
        private NodoP cima1;
        private NodoL primero1;
        public COMPLETAR(NodoL primero,NodoP cima)
        {
            InitializeComponent();
            this.primero1 = primero;
            this.cima1 = cima;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pila pl = new Pila();
            Lista ls = new Lista();
            
            
            if (ls.recorrer(primero1,textBox1.Text) == false )
            {
                MessageBox.Show("Elemento no encontrado");
            }
            else
            {
                NodoP nuevo = new NodoP();
                nuevo.datoT = ls.eliminar(ref primero1, textBox1.Text);
                nuevo.datoT.estado = "Completo";
                pl.insertar(ref cima1, nuevo.datoT);
            }

        
        }

        private void COMPLETAR_Load(object sender, EventArgs e)
        {

        }
    }
}

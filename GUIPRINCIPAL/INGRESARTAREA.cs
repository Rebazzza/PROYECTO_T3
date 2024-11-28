using PROYECTO_T3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPRINCIPAL
{
    public partial class INGRESARTAREA : Form
    {
        private NodoL primero1;
        private NodoP cima1;
        
        
        public INGRESARTAREA(NodoP Cima1,NodoL primero)
        {
            InitializeComponent();
            primero1 = primero; 
            cima1 = Cima1;
        }

        private void INGRESARTAREA_Load(object sender, EventArgs e)
        {
                      
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Lista ls = new Lista();
            Pila pl = new Pila();
            
            if (comboBox1.Text == "Incompleto")
            {

                Tarea tarea = new Tarea(textBox1.Text, textBox2.Text, comboBox1.Text);

                ls.insertar(ref primero1, tarea);
                ls.eliminar(ref primero1, "Vacío1");
            }

            else if (comboBox1.Text == "Completo")
            {
                Tarea tarea = new Tarea(textBox1.Text, textBox2.Text, comboBox1.Text);
                pl.insertar(ref cima1, tarea);

            }

            MessageBox.Show("Tarea ingresada correctamente");
}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2TP9
{
    public partial class Form1 : Form
    {
        /*2 - Crear un programa donde se muestre la suma, resta división y multiplicación entre dos números que
deberá ingresar el usuario.*/

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int operador1 = int.Parse(textBox1.Text);
            int operador2 = int.Parse(textBox2.Text);
            int multiplicar = operador1 * operador2;
            int sumar = operador1 + operador2;
            int restar = operador1 - operador2;
            int dividir = operador1 / operador2;
            label1.Text = multiplicar.ToString();
            label6.Text = sumar.ToString();
            label7.Text = restar.ToString();
            label8.Text = dividir.ToString();
        }
    }
}

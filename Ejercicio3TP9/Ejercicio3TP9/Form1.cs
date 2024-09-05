using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3TP9
{
    public partial class Form1 : Form
    {
        /*3- Crear un programa donde el usuario ingrese dos números (a y b), el mismo deberá mostrar el resultado
de las operaciones (a+b)*(a-b) y el resultado de la operación a2-b2. */

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int multiplicar = (a + b)*(a-b);
            int restar = (a * a) - (b * b);
            label2.Text = multiplicar.ToString();
            label3.Text = restar.ToString();
        }
    }
}

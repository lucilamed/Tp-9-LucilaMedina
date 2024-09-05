using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5TP9
{
    public partial class Form1 : Form
    {
        /*Crear un programa que calcule el número de CDs necesarios para hacer una copia de seguridad de la
información almacenada en un disco rígido cuya capacidad se conoce. Considerar que el disco duro está
lleno de información, además expresado en Gigabytes. Un CD virgen tiene 700 Megabytes de capacidad y
un Gigabyte es igual a 1024 Megabytes.*/

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tamanio = int.Parse(textBox1.Text);
            double tamanioMB = tamanio * 1024;

            double tamanioalc = tamanioMB / 700;

            label2.Text = "Los CDs a utilizar son de: " + Math.Ceiling(tamanioalc);
        }
    }
}

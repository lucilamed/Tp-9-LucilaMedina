using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4TP9
{
    public partial class Form1 : Form
    {
        /*4- Crear un programa donde el usuario ingrese una letra y diga si es una vocal.*/
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vocal = (textBox1.Text);

            string a = "a";
            string E = "e";
            string i = "i";
            string o = "o";
            string u = "u";

            if (vocal == a | vocal == E |vocal == i | vocal == o | vocal == u)
            {
                label2.Text = "La letra ingresada es una vocal";
            }
            else
            {
                label2.Text = "La letra ingresada NO es una vocal";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMENMULTIZ5SD12023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //EJERCICIO 1
        public string ejercicio1(int n)
        {
            int c,s1,c2;
            c = 1;
            string suma="";
            bool ban = true;
            s1 = n;
            c2 = 1;
            while (n>=c)
            {

                if (ban==true)
                {
                    suma = suma + s1+" , ";
                    s1 = s1 - 1;
                }
                else
                {
                    suma = suma + c2 + " , ";
                    c2 = c2 + 1;
                }

                c = c + 1;
                ban = !ban;
            }

            return suma;
        }
        private void eJERCICIO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = ejercicio1(  int.Parse(textBox1.Text)  );
        }
    }
}

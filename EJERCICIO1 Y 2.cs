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


        //EJERCICIO 2
        public string Inv(string s)
        {

            string sr = "";
            for (int i = 1; i <= s.Length; i++)
            {
                sr = s[i - 1] + sr;

            }

            return sr;

        }

        public bool VerifVoc(char car)
        {
            const string VOCALES = "AEIOU";
            bool b;
            int i, n;
            b = false;
            i = 1;
            n = VOCALES.Length;
            car = RetMayus(car);
            while ((i <= n) && (b == false))
            {
                if (car == VOCALES[i - 1])
                {
                    b = true;

                }
                i++;
            }
            return b;
        }
        public char RetMayus(char car)
        {
            return char.ToUpper(car); // ToUpper(car) Metodo que convierte un caracter a Mayuscula
        }

        public string ejercicio2(string s)
        {
         
            int i = 1;
            char c;
            string sr = "";
            string s1 = "";
            while ((i <= s.Length))
            {
                c = s[i - 1];

                if (char.IsLetter(c)==true)
                {
                    sr = sr+ c;

                }
                else
                {
                    sr = Inv(sr); 
                    s1 = s1 + sr;
                    s1 = s1 + c;
                    sr = "";
                }

                i++;
            }

            return s1;
            
        }

        private void eJERCICIO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(ejercicio2(textBox1.Text));
        }
    }
}

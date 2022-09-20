using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace casino_caliente
{
    public partial class Form1 : Form
    {
        int i, j, k, max1, max2, max3;
        string digito1, digito2, digito3;
        Random numeroAleatorio1 = new Random(), numeroAleatorio2 = new Random(), numeroAleatorio3 = new Random();
        //Creo 3 objetos de la clase ''random'' (aleatoio) para generar numeros al azar.
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            j = 0;
            k = 0;
            max1 = numeroAleatorio1.Next(10, 100);
            max2 = numeroAleatorio1.Next(10, 100) + numeroAleatorio2.Next(10, 100);
            max3 = numeroAleatorio1.Next(10, 100) + numeroAleatorio2.Next(10, 100) + numeroAleatorio3.Next(10, 100);
            while (k <= max3)
            {
                if (i <= max1)
                {
                    digito1 = Convert.ToString(i);
                }
                if (j <= max2)
                {
                    digito2 = Convert.ToString(j);
                }
                digito3 = Convert.ToString(k);
                label1.Text = digito1.Substring(digito1.Length - 1);
                label2.Text = digito2.Substring(digito2.Length - 1);
                label3.Text = digito3.Substring(digito3.Length - 1);
                label1.Refresh();
                label2.Refresh();
                label3.Refresh();
                i++;
                j++;
                k++;
                Thread.Sleep(10);
            }
            if (label1.Text == label2.Text && label2.Text == label3.Text)
                MessageBox.Show("Ganaste $1000,000 dlls !!!", "FELICIDADES!!!");
            else
                MessageBox.Show("Suerte para la proxima!!!", "LASTIMA!!!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisakenar, uzunkenar, alan, cevre;
            kisakenar = Convert.ToInt16(textBox1.Text);
            uzunkenar = Convert.ToInt16(textBox2.Text);
            cevre = (kisakenar + uzunkenar) * 2;
            alan = kisakenar * uzunkenar;

            MessageBox.Show("Kısa Kenar = " + kisakenar + "\n" +
                "Uzun Kenar = " + uzunkenar + "\n" +
                "Cevre = " + cevre + "\n" +
                "Alan = " + alan + "\n" 
                );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //klavyeden yarı çapı girilen çemberin alan ve çevresini hesaplayan program
            double pi,yaricap, alan, cevre;           

            yaricap = Convert.ToInt16(textBox3.Text);
            pi = 3.14;
            cevre = 2 * pi * yaricap;
            alan = pi * (yaricap * yaricap);

            MessageBox.Show("Yarı Cap = " + yaricap + "\n" +
                "Pi = " + pi + "\n"+
                "Cevre = " + cevre + "\n" +
                "Alan = " + alan + "\n" 
                );
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Entrada de dados
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);

            //Processamento
            int resultado = n1 + n2;

            //Saída de dados
            textBox3.Text = resultado.ToString();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projecto_ISI.ServiceReference1;

namespace Projecto_ISI
{
    //falta aqui uma linha new client qualquer coisa para chamar o metodo do webservice

    public partial class Form3 : Form
    {
        int idade;
        String genero;
        double altura, pesoExtra, alturaExtra, alturaInches;

        public Form3()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       private void button2_Click(object sender, EventArgs e)
            {
                this.Close();
            }


        private void button1_Click(object sender, EventArgs e)
        {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Preencha o campo da Idade. ");
                }
                if (String.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Preencha o campo do Género. ");
                }
                if (String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Preencha o campo da Altura. ");
                }
            
            else
            {
                idade = int.Parse(textBox1.Text);
                genero = comboBox1.Text;
                altura = double.Parse(textBox2.Text);
               // richTextBox1.Text = client.CalculadoraPesoIdeal(genero, altura);
                
                /*alturaInches = altura * 0.39370079;
                alturaExtra = alturaInches - 60;
                
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        pesoExtra = alturaExtra * 1.9;
                        float pesoIdealM = ((float)(52 + pesoExtra));
                        int peso = (int) pesoIdealM;
                        richTextBox1.Text = peso.ToString() + " Kgs";                      
                        break;
                    case 1:
                        pesoExtra = alturaExtra * 1.7;
                        float pesoIdealF = ((float)(49 + pesoExtra));
                        int pesoF = (int)pesoIdealF;
                        richTextBox1.Text = pesoF.ToString() + " Kgs";
                        break;
                }*/
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

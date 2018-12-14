using System;
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
    public partial class Form3 : Form
    {
        int idade, altura;
        string genero;
        //double pesoExtra, alturaExtra, alturaInches;

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
            Service1Client client = new Service1Client();

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
                altura = int.Parse(textBox2.Text);
                richTextBox1.Text = client.CalculadoraPesoIdeal(genero, altura).ToString();
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

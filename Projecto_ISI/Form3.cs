using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_ISI
{
    public partial class Form3 : Form
    {
        int idade;
        double altura, pesoExtra, alturaExtra, alturaInches;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Preencha  Campo da Idade. ");
            }
            if (String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Preencha  Campo da Genero. ");
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Preencha  Campo da altura. ");
            }

            else
            {
                idade = int.Parse(textBox1.Text);
                altura = double.Parse(textBox2.Text);
                alturaInches = altura * 0.39;
                alturaExtra = alturaInches - 60;
                
                //peso = double.Parse(textBox3.Text);

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        pesoExtra = alturaExtra * 1.9;
                        int pesoIdealM = ((int)(52 + pesoExtra));
                        MessageBox.Show("Peso ideal " + pesoIdealM.ToString() + "KG" + "\n alturaInches" + alturaInches + " \n alturaExtra " + alturaExtra + " \n pesoExtra " + pesoExtra);//Melhorar print
                        break;
                    case 1:
                        pesoExtra = alturaExtra * 1.7;
                        int pesoIdealF = ((int)(49 + pesoExtra));
                        MessageBox.Show("Peso ideal " + pesoIdealF.ToString() + "KG" + "\n alturaInches" + alturaInches + " \n alturaExtra " + alturaExtra + " \n pesoExtra " + pesoExtra);//Melhorar print
                        break;
                }
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

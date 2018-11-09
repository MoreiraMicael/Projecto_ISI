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
    public partial class Form2 : Form
    {
        int idade;
        double altura, peso;

        public Form2()
        {
            InitializeComponent();
        }

        private bool ValidaTexbox(object sender, KeyPressEventArgs e)
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

            return false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTexbox(sender, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTexbox(sender, e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTexbox(sender, e);
        }

        public void CalcularCalorias()
        {
            double bmr = 0.0;
            double sedent = 1.2;
            double light = 1.375;
            double moderate = 1.55;
            double very = 1.725;
            double extra = 1.9;
            idade = int.Parse(textBox1.Text);
            altura = double.Parse(textBox2.Text);
            peso = double.Parse(textBox3.Text);

            int caloriasM = ((int)(10 * peso + 6.25 * altura - 5 * idade + 5));

            int caloriasF = ((int)(10 * peso + 6.25 * altura - 5 * idade - 161));

            int calorias = 0;
            double exercicio = 0;

            if (comboBox2.SelectedItem.Equals("Masculino"))
            {
                calorias = caloriasM;
            }
            else
            {
                calorias = caloriasF;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                exercicio = bmr;
                if (comboBox1.SelectedIndex == 1)
                {
                    exercicio = sedent;
                    if (comboBox1.SelectedIndex == 2)
                    {
                        exercicio = light;
                        if (comboBox1.SelectedIndex == 3)
                        {
                            exercicio = moderate;
                            if (comboBox1.SelectedIndex == 4)
                            {
                                exercicio = very;
                                if (comboBox1.SelectedIndex == 5)
                                {
                                    exercicio = extra;
                                }
                            }
                        }
                    }
                }
            }

            double totalCalorias = ((calorias * exercicio));
            double menosMeio = ((calorias * exercicio) - 500);
            double menosUm = ((calorias * exercicio) - 1000);
            double maisMeio = ((calorias * exercicio) + 500);
            double maisUm = ((calorias * exercicio) + 1000);

            MessageBox.Show("Precisa de " + (int)calorias + " para manter o seu peso.\n" + (int)menosMeio + " Perder meio kilo\n" + (int)maisMeio + " Ganhar meio kilo\n");//Melhorar print
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Preencha  Campo da Idade. ");
            }
            if (String.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Preencha  Campo da Genero. ");
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Preencha  Campo da altura. ");
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Preencha  Campo da peso. ");
            }
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Preencha  Campo da Actividade. ");
            }
            else
            {
                CalcularCalorias();
            }
        }
    }
}

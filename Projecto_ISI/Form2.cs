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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)//Falta o Exercicio Fisico
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
            /*
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Preencha  Campo da Actividade. ");
            }
            */
            else
            {
                idade = int.Parse(textBox1.Text);
                altura = double.Parse(textBox2.Text);
                peso = double.Parse(textBox3.Text);

                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        int caloriasM = ((int)(10 * peso + 6.25 * altura - 5 * idade + 5));
                        int menosMeio = ((int)(10 * peso + 6.25 * altura - 5 * idade + 5) - 500);
                        int menosUm = ((int)(10 * peso + 6.25 * altura - 5 * idade + 5) - 1000);
                        int maisMeio = ((int)(10 * peso + 6.25 * altura - 5 * idade + 5) + 500);
                        int maisUm = ((int)(10 * peso + 6.25 * altura - 5 * idade + 5) + 1000);
                        MessageBox.Show("Precisa de " + caloriasM.ToString() + " para manter o seu peso.\n" + menosMeio + " Perder peso\n" + maisMeio + " Ganhar Peso\n" );//Melhorar print
                        break;
                    case 1:
                        int caloriasF = ((int)(10 * peso + 6.25 * altura - 5 * idade - 161));
                        MessageBox.Show(caloriasF.ToString());
                        break;
                }
            }
                     
        }
    }
}

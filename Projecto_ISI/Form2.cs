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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Preencha  Campo da Actividade. ");
            }         
            else
            {
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
                
                switch (comboBox1.SelectedIndex)
                {
                    
                    case 0:
                        
                        if (comboBox2.SelectedItem.Equals("Feminino"))
                        {

                         double calorias = caloriasF *  sedent;
                            textBox4.Text = calorias.ToString();
                            textBox5.Text = (calorias - 500).ToString();
                            textBox6.Text = (calorias + 500).ToString();
                           // MessageBox.Show("Precisa de " + (int) calorias + " para manter o seu peso.\n" + (int) (calorias-500) + " Perder peso\n" + (int) (calorias+500) + " Ganhar Peso\n");//Melhorar print
                            break;
                        }
                         double caloriasMasc = ((caloriasM * sedent));
                         double menosMeio = ((caloriasM * sedent)-500);
                         double menosUm = ((caloriasM * sedent) - 1000);
                         double maisMeio = ((caloriasM * sedent) + 500);
                         double maisUm = ((caloriasM * sedent) + 1000);
                        textBox4.Text = caloriasMasc.ToString();
                        textBox5.Text = menosMeio.ToString();
                        textBox6.Text = maisMeio.ToString();
                      //  MessageBox.Show("Precisa de " + (int)caloriasMasc + " para manter o seu peso.\n" + (int)menosMeio + " Perder peso\n" + (int)maisMeio + " Ganhar Peso\n");//Melhorar print
                        break; 
                      
                    case 1:

                        if (comboBox2.SelectedItem.Equals("Feminino"))
                        {

                            double calorias = caloriasF * light;

                            MessageBox.Show("Precisa de " + (int)calorias + " para manter o seu peso.\n" + (int)(calorias - 500) + " Perder peso\n" + (int)(calorias + 500) + " Ganhar Peso\n");//Melhorar print
                            break;
                        }
                         caloriasMasc = ((caloriasM * light));
                         menosMeio = ((caloriasM * light) - 500);
                         menosUm = ((caloriasM * light) - 1000);
                         maisMeio = ((caloriasM * light) + 500);
                         maisUm = ((caloriasM * light) + 1000);
                        textBox4.Text = caloriasMasc.ToString();
                        textBox5.Text = menosMeio.ToString();
                        textBox6.Text = maisMeio.ToString();
                       // MessageBox.Show("Precisa de " + (int)caloriasMasc + " para manter o seu peso.\n" + (int)menosMeio + " Perder peso\n" + (int)maisMeio + " Ganhar Peso\n");//Melhorar print
                        break;
                    case 2:
                        if (comboBox2.SelectedItem.Equals("Feminino"))
                        {

                            double calorias = caloriasF * moderate;

                            MessageBox.Show("Precisa de " + (int)calorias + " para manter o seu peso.\n" + (int)(calorias - 500) + " Perder peso\n" + (int)(calorias + 500) + " Ganhar Peso\n");//Melhorar print
                            break;
                        }
                        caloriasMasc = ((caloriasM * moderate));
                        menosMeio = ((caloriasM * moderate) - 500);
                        menosUm = ((caloriasM * moderate) - 1000);
                        maisMeio = ((caloriasM * moderate) + 500);
                        maisUm = ((caloriasM * moderate) + 1000);
                        textBox4.Text = caloriasMasc.ToString();
                        textBox5.Text = menosMeio.ToString();
                        textBox6.Text = maisMeio.ToString();
                        //  MessageBox.Show("Precisa de " + (int)caloriasMasc + " para manter o seu peso.\n" + (int)menosMeio + " Perder peso\n" + (int)maisMeio + " Ganhar Peso\n");//Melhorar print
                        break;
                    case 3:
                        if (comboBox2.SelectedItem.Equals("Feminino"))
                        {

                            double calorias = caloriasF * very;

                            MessageBox.Show("Precisa de " + (int)calorias + " para manter o seu peso.\n" + (int)(calorias - 500) + " Perder peso\n" + (int)(calorias + 500) + " Ganhar Peso\n");//Melhorar print
                            break;
                        }
                        caloriasMasc = ((caloriasM * very));
                        menosMeio = ((caloriasM * very) - 500);
                        menosUm = ((caloriasM * very) - 1000);
                        maisMeio = ((caloriasM * very) + 500);
                        maisUm = ((caloriasM * very) + 1000);
                        textBox4.Text = caloriasMasc.ToString();
                        textBox5.Text = menosMeio.ToString();
                        textBox6.Text = maisMeio.ToString();
                    //    MessageBox.Show("Precisa de " + (int)caloriasMasc + " para manter o seu peso.\n" + (int)menosMeio + " Perder peso\n" + (int)maisMeio + " Ganhar Peso\n");//Melhorar print
                        break;
                    case 4:
                        if (comboBox2.SelectedItem.Equals("Feminino"))
                        {

                            double calorias = caloriasF * extra;

                            MessageBox.Show("Precisa de " + (int)calorias + " para manter o seu peso.\n" + (int)(calorias - 500) + " Perder peso\n" + (int)(calorias + 500) + " Ganhar Peso\n");//Melhorar print
                            break;
                        }
                        caloriasMasc = ((caloriasM * extra));
                        menosMeio = ((caloriasM * extra) - 500);
                        menosUm = ((caloriasM * extra) - 1000);
                        maisMeio = ((caloriasM * extra) + 500);
                        maisUm = ((caloriasM * extra) + 1000);
                        textBox4.Text = caloriasMasc.ToString();
                        textBox5.Text = menosMeio.ToString();
                        textBox6.Text = maisMeio.ToString();
                      //  MessageBox.Show("Precisa de " + (int)caloriasMasc + " para manter o seu peso.\n" + (int)menosMeio + " Perder peso\n" + (int)maisMeio + " Ganhar Peso\n");//Melhorar print
                        break;


                }
            }
                     
        }
    }
}

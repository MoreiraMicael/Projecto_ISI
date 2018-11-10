using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WebServiceProjecto_ISI;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Projecto_ISI
{
    public partial class Form1 : Form
    {
        private readonly WebServiceProjecto_ISI.Service1 service1 = new Service1();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                    System.IO.StreamReader(openFileDialog1.FileName);
                //MessageBox.Show(sr.ReadToEnd());
                richTextBox1.Text = sr.ReadToEnd();
                //string texto = richTextBox1.Text;
                segmenta_2();
                sr.Close();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void segmenta_2()
        {
            string texto = richTextBox1.Text;
            string[] linhas = texto.Split(new[] { "�" }, StringSplitOptions.RemoveEmptyEntries);
            string[] campos = texto.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            //string[] digits = Regex.Split(texto, @"\§");

            int numLinhas = 0;
            int numCampos = 0;
            foreach (var linha in linhas)
            {
                //richTextBox2.Text += "Linha: " + linha + "\n";
                numLinhas++;

                foreach (var campo in campos)
                {
                    numCampos++;
                }
            }

            richTextBox2.Text = "Numero de Linhas: " + numLinhas + "\n" + "Numero de Campos: " + numCampos;
        }

        private void button4_Click(object sender, EventArgs e)//Print do refeicoes1.xml por refeicao
        {
            //service1.GetRefeicoes();
            foreach(var Refeicao in service1.GetRefeicoes())
            {
                richTextBox1.Text += Refeicao.ToString() + "\n";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*List<Refeicao> refeicoes = new List<Refeicao>();

            string maisrefeicoes = File.ReadAllText(@"C:\Users\Moreira\Documents\ISI\Projecto_ISI\calorias_restaurantes_3.json");

            List<Refeicao> mais_refeicoes = JsonConvert.DeserializeObject<List<Refeicao>>(maisrefeicoes);

            var text_ref = String.Join("\n", mais_refeicoes);
            richTextBox2.Text = text_ref;*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var txt = string.Empty;

            using (var stream = File.OpenText("App_Data\\calorias_restaurantes_1.txt"))
            {
                txt = stream.ReadToEnd();
            }

            string texto = richTextBox1.Text;
            string[] linhas = texto.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            string[] campos = texto.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
            //string[] digits = Regex.Split(texto, @"\§");

            int numLinhas = 0;
            int numCampos = 0;

            foreach (var linha in linhas)
            {
                //richTextBox2.Text += "Linha: " + linha + "\n";
                numLinhas++;

                foreach (var campo in campos)
                {
                    numCampos++;
                }
            }
            String[] data = File.ReadAllLines("App_Data\\calorias_restaurantes_1.txt");
            XElement root = new XElement("Refeicoes",
                                        from item in data
                                        select new XElement("Refeicao", item));

            root.Save(Path.ChangeExtension("App_Data\\calorias_restaurantes_1XML", ".xml"));
        }
    }
}

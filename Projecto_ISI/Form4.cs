using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Projecto_ISI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new
                StreamReader(openFileDialog1.FileName);
                sr.Close();
            }

            List<Refeicao> refeicoes = new List<Refeicao>();

            string maisrefeicoes = File.ReadAllText(openFileDialog1.FileName);

            List<Refeicao> mais_refeicoes = JsonConvert.DeserializeObject<List<Refeicao>>(maisrefeicoes);

            var text_ref = String.Join("\n", mais_refeicoes);
            richTextBox1.Text = text_ref;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        this.Close();            
        }
    }
}
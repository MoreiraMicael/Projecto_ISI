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
using Projecto_ISI.ServiceReference1;

namespace Projecto_ISI
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            mostraRefeicoes();
        }

        public void mostraRefeicoes()
        {
            Service1Client client = new Service1Client();

           

            //richTextBox1.Text = client.GetRefeicoes().ToString();

            //var refeicoesDataSet = client.GetRefeicoes();

            /*var refeicoesDataSet = new DataTable("Refeicoes");
            var refeicoes = client.GetRefeicoes();
            foreach (var item in client.GetRefeicoes())
            {
                refeicoesDataSet.Rows.Add(item);
            }

            dataGridView1.DataSource = refeicoesDataSet;*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
             /*   StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                string[] colunas = sr.ReadLine().Split('\n');
              //  string[] campo = colunas[1].Split('\t');
                
                DataTable dt = new DataTable();
                foreach (string c in colunas)
                {
                    dt.Columns.Add(c);
                }
                string newline;
                while ((newline = sr.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();
                    string[] values = newline.Split(' ');
                    for (int i = 0; i < values.Length; i++)
                    {
                        dr[i] = values[i];
                    }
                    dt.Rows.Add(dr);
                }
                */

                
                

               /* foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    //    foreach()
                }


               System.IO.StreamReader file = new System.IO.StreamReader("yourfile.txt");
                string[] columnnames = file.ReadLine().Split(' ');
                DataTable dt = new DataTable();
                foreach (string c in columnnames)
                {
                    dt.Columns.Add(c);
                }
                string newline;
                while ((newline = file.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();
                    string[] values = newline.Split(' ');
                    for (int i = 0; i < values.Length; i++)
                    {
                        dr[i] = values[i];
                    }
                    dt.Rows.Add(dr);
                }
                file.Close();
                dataGridView1.DataSource = dt;*/

/*
                sr.Close();
                dataGridView1.DataSource = dt;
                */
            }



        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

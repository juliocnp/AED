using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenacao
{
    public partial class Form1 : Form
    {
        Gerador g;
        int[] vetor;
        public Form1()
        {
            InitializeComponent();
            g = new Gerador(100);
            vetor = g.vetAleatorio();
            for (int i = 0; i < vetor.Length; i++)
            {
                listBox1.Items.Add(vetor[i].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            vetor = MetodosOrdenacao.QuickSort(vetor);
            for (int i = 0; i < vetor.Length; i++)
            {
                listBox1.Items.Add(vetor[i].ToString());
            }
        }
    }
}

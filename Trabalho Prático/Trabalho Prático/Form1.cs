using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Trabalho_Prático
{
    public partial class FormEscolha : Form
    {
        Stopwatch tempo;

        public FormEscolha()
        {
            InitializeComponent();
            comboBox1.Visible = false;
            label2.Visible = false;
            tempo = new Stopwatch();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonFatRe.Checked == true)
            {
                tempo.Start();
                long resultado = Fatorial.Recursivo(int.Parse(textBox1.Text));
                tempo.Stop();
                Form2 form = new Form2(tempo.Elapsed, resultado.ToString());
                form.Visible = true;
                tempo.Reset();
            }
            else if (radioButtonFatIte.Checked == true)
            {
                tempo.Start();
                long resultado = Fatorial.Iterativo(int.Parse(textBox1.Text));
                tempo.Stop();
                Form2 form = new Form2(tempo.Elapsed, resultado.ToString());
                form.Visible = true;
                tempo.Reset();
            }
            else if (radioButtonFiboRe.Checked == true)
            {
                tempo.Start();
                long resultado = Fibonacci.Recursivo(int.Parse(textBox1.Text));
                tempo.Stop();
                Form2 form = new Form2(tempo.Elapsed, resultado.ToString());
                form.Visible = true;
                tempo.Reset();
            }
            else if (radioButtonFiboIte.Checked == true)
            {
                tempo.Start();
                long resultado = Fibonacci.Iterativo(int.Parse(textBox1.Text));
                tempo.Stop();
                Form2 form = new Form2(tempo.Elapsed, resultado.ToString());
                form.Visible = true;
                tempo.Reset();
            }
            else if (radioButtonPesSeq.Checked == true)
            {
                int[] vetor;
                if (comboBox1.SelectedIndex == 0)
                    vetor = new int[10000];
                else if (comboBox1.SelectedIndex == 1)
                    vetor = new int[20000];
                else if (comboBox1.SelectedIndex == 2)
                    vetor = new int[100000];
                else if (comboBox1.SelectedIndex == 3)
                    vetor = new int[1000000];
                else if (comboBox1.SelectedIndex == 4)
                    vetor = new int[10000000];
                else if (comboBox1.SelectedIndex == 5)
                    vetor = new int[20000000];
                else if (comboBox1.SelectedIndex == 6)
                    vetor = new int[50000000];
                else
                {
                    MessageBox.Show("Selecione o tamanho do vetor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 1; i < vetor.Length; i++)
                {
                    vetor[i - 1] = i;
                }

                tempo.Start();
                int resultado = Pesquisa.Sequencial(vetor, int.Parse(textBox1.Text));
                tempo.Stop();
                Form2 form = new Form2(tempo.Elapsed, resultado.ToString());
                form.Visible = true;
                tempo.Reset();
            }
            else if (radioButtonPesBin.Checked == true)
            {
                int[] vetor;
                if (comboBox1.SelectedIndex == 0)
                    vetor = new int[10000];
                else if (comboBox1.SelectedIndex == 1)
                    vetor = new int[20000];
                else if (comboBox1.SelectedIndex == 2)
                    vetor = new int[100000];
                else if (comboBox1.SelectedIndex == 3)
                    vetor = new int[1000000];
                else if (comboBox1.SelectedIndex == 4)
                    vetor = new int[10000000];
                else if (comboBox1.SelectedIndex == 5)
                    vetor = new int[20000000];
                else if (comboBox1.SelectedIndex == 6)
                    vetor = new int[50000000];
                else
                {
                    MessageBox.Show("Selecione o tamanho do vetor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 1; i < vetor.Length; i++)
                {
                    vetor[i - 1] = i;
                }

                tempo.Start();
                int resultado = Pesquisa.Binaria(vetor, int.Parse(textBox1.Text), 0, vetor.Length-1);
                tempo.Stop();
                Form2 form = new Form2(tempo.Elapsed, resultado.ToString());
                form.Visible = true;
                tempo.Reset();
            }
            else if (radioButtonHanoi.Checked == true)
            {
                Form3 form = new Form3(tempo, int.Parse(this.textBox1.Text));
                form.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            label2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            label2.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            label2.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            label2.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            label2.Visible = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            label2.Visible = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            label2.Visible = false;
        }
    }
}

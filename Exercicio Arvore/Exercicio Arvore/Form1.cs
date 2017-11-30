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

namespace Exercicio_Arvore
{
    public partial class Form1 : Form
    {
        ABB Contas, Cpfs;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string caminho = ofd.FileName;
            LerDados(caminho);
        }

        private void LerDados (string caminho)
        {
            StreamReader reader = new StreamReader(caminho);
            string texto = reader.ReadToEnd();
            reader.Close();

            texto = texto.Replace("\r", null);
            string[] linhas = texto.Split('\n');

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] dados = linhas[i].Split(';');
                long id = long.Parse(dados[0]);
                dados[1] = dados[1].Replace(".", null);
                dados[1] = dados[1].Replace("-", null);
                long cpf = long.Parse(dados[1]);
                int tipo = int.Parse(dados[2]);

                Cpf aux = (Cpf)Cpfs.buscar(cpf);
                Conta auxConta = new Conta(id, cpf, tipo);
                Contas.inserir(auxConta);

                if (aux != null)
                    aux.Contas.Add(auxConta);
                else
                {
                    aux.Contas.Add(auxConta);
                    Cpfs.inserir(aux);
                }
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (radioButtonConta.Checked)
            {
                Conta conta = (Conta)Contas.buscar(long.Parse(textBoxCpfId.Text));
                textBoxContasCpf.Text = "Cpf: " + conta.Cpf;
            }
            else if (radioButtonCpf.Checked)
            {
                Cpf conta = (Cpf)Cpfs.buscar(long.Parse(textBoxCpfId.Text));
                Conta[] = 
            }
        }

        public Form1()
        {
            InitializeComponent();
            Contas = new ABB();
            Cpfs = new ABB();
            radioButtonCpf.Checked = true;
        }

        
    }
}

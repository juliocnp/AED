using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hash
{
    public partial class Form1 : Form
    {
        long cpf;
        Hash hash;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.SafeFileName != "" && ofd.SafeFileName == "passageiros.txt")
                CarregarCpfs(@ofd.FileName);
            else if (ofd.SafeFileName != "" && ofd.SafeFileName == "reservas.txt")
            {
                if (hash == null)
                    MessageBox.Show("Carregue os passageiros!");
                else
                    CarregarReservas(@ofd.FileName);
            }
        }

        private void CarregarCpfs(string caminho)
        {
            hash = new Hash(1601, new Hash.expressao(cpf => (int)cpf % 1601));
            StreamReader reader = new StreamReader(caminho);
            string texto = reader.ReadToEnd();
            reader.Close();
            texto = texto.Replace("\r", null);
            string[] linhas = texto.Split('\n');
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] dados = linhas[i].Split(';');
                dados[0] = dados[0].Replace(".", null);
                Pessoa p = new Pessoa(long.Parse(dados[0]), dados[1]);
                hash.Inserir(p.Cpf, p);
            }
            MessageBox.Show("Numero de máximo de colisoes: " + hash.Colisao.ToString());
        }

        private void CarregarReservas(string caminho)
        {
            StreamReader reader = new StreamReader(caminho);
            string texto = reader.ReadToEnd();
            reader.Close();
            texto = texto.Replace("\r", null);
            string[] linhas = texto.Split('\n');
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] dados = linhas[i].Split(';');
                dados[0] = dados[0].Replace(".", null);
                Pessoa p = (Pessoa)hash.Buscar(long.Parse(dados[0]));
                p.AddVoo(dados[1]);
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (textBoxCPF.Text != "")
            {
                listBoxVoos.Items.Clear();
                cpf = long.Parse(textBoxCPF.Text.Replace(".", null));
                Pessoa p = (Pessoa)hash.Buscar(cpf);
                if (p != null)
                {
                    listBoxVoos.Items.Add(p.Nome);
                    Dados[] voos = p.Voos.Imprimir();
                    for (int i = 0; i < voos.Length; i++)
                    {
                        Voo v = (Voo)voos[i];
                        listBoxVoos.Items.Add(v.Id);
                    }
                }
                else
                    listBoxVoos.Items.Add("CPF não encontrado.");
            }
        }
    }
}

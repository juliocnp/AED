using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Pilha pilhaOperadores, pilhaNumeros;
        Fila saida;
        bool erro = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string auxTexto = textBoxEquacao.Text.Replace("\r", null);
            string[] linhas = auxTexto.Split('\n');
            if (linhas[linhas.Length-1].Length > 0)
            {
                pilhaOperadores = new Pilha();
                pilhaNumeros = new Pilha();
                saida = new Fila();
                PolonesInvertido(linhas[linhas.Length-1]);
                Resultado();
                textBoxEquacao.AppendText (Environment.NewLine);
                textBoxEquacao.Select(textBoxEquacao.Text.Length, 0);
            }
        }

        private void PolonesInvertido(string expressao)
        {
            if (expressao.Length != 0)
            {
                int cont = 0;
                bool number = false, operador = false;

                while (cont < expressao.Length && (Valor.IsNumber(expressao[cont]) || expressao[cont].Equals(',')))
                {
                    cont++;
                    number = true;
                }

                while (cont < expressao.Length && Operador.IsEspecial(expressao[cont].ToString()) && Operador.IsOperator(expressao[cont].ToString()) && number == false)
                {
                    cont++;
                    operador = true;
                }

                if (cont < expressao.Length && !number && (expressao[cont].Equals('(') || !Operador.IsEspecial(expressao[cont].ToString())))
                    operador = true;

                if (operador == true)
                {
                    Operador aux;
                    if (cont > 0)
                        aux = new Operador(expressao.Substring(0, cont));
                    else
                        aux = new Operador(expressao.Substring(0, 1));

                    if (aux.Op.Equals("("))
                    {
                        pilhaOperadores.Empilhar(null);
                        operador = false;
                        if (cont > 0)
                            PolonesInvertido(expressao.Substring(cont));
                        else
                            PolonesInvertido(expressao.Substring(cont + 1));
                        return;
                    }

                    if ((pilhaOperadores.OlharTopo() == null || pilhaOperadores.OlharTopo().CompareTo(aux) < 0) && !aux.Op.Equals(")"))
                    {
                        pilhaOperadores.Empilhar(aux);
                        operador = false;
                        if (cont > 0)
                            PolonesInvertido(expressao.Substring(cont));
                        else
                            PolonesInvertido(expressao.Substring(cont + 1));
                        return;
                    }
                    else
                    {
                        Operador auxOp;
                        if (aux.Prioridade != 0)
                        {
                            do
                            {
                                if (pilhaOperadores.OlharTopo() != null)
                                    auxOp = (Operador)pilhaOperadores.Desempilhar();
                                else auxOp = null;

                                if (auxOp != null)
                                    saida.Inserir(auxOp);
                            } while (auxOp != null);

                            pilhaOperadores.Empilhar(aux);
                        }
                        else
                        {
                            do
                            {
                                auxOp = (Operador)pilhaOperadores.Desempilhar();

                                if (auxOp != null)
                                    saida.Inserir(auxOp);
                            } while (auxOp != null);

                        }
                        operador = false;
                        if (cont > 0)
                            PolonesInvertido(expressao.Substring(cont));
                        else
                            PolonesInvertido(expressao.Substring(cont + 1));
                        return;
                    }
                }

                if (number == true)
                {
                    string auxString = expressao.Substring(0, cont);
                    if (Valor.IsNumber(auxString))
                    {
                        saida.Inserir(new Valor(double.Parse(auxString)));
                        number = false;
                        PolonesInvertido(expressao.Substring(cont));
                        return;
                    }
                    else
                    {
                        erro = true;
                        number = false;
                    }
                }
            }
            else
            {
                while (pilhaOperadores.OlharTopo() != null)
                    saida.Inserir(pilhaOperadores.Desempilhar());
            }
        }
        # region buttons
        private void button9_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("1");
            textBoxEquacao.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("2");
            textBoxEquacao.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("3");
            textBoxEquacao.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("4");
            textBoxEquacao.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("5");
            textBoxEquacao.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("6");
            textBoxEquacao.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("7");
            textBoxEquacao.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("8");
            textBoxEquacao.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("9");
            textBoxEquacao.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("0");
            textBoxEquacao.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText(",");
            textBoxEquacao.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string auxTexto = textBoxEquacao.Text.Replace("\r", null);
            string[] linhas = auxTexto.Split('\n');
            if (linhas[linhas.Length - 1].Length > 0)
            {
                string aux = textBoxEquacao.Text.Substring(0, textBoxEquacao.Text.Length - 1);
                textBoxEquacao.Clear();
                textBoxEquacao.AppendText(aux);
            }
            textBoxEquacao.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("^");
            textBoxEquacao.Focus();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("-");
            textBoxEquacao.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("+");
            textBoxEquacao.Focus();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("*");
            textBoxEquacao.Focus();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("/");
            textBoxEquacao.Focus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("(");
            textBoxEquacao.Focus();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText(")");
            textBoxEquacao.Focus();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("LOGe(");
            textBoxEquacao.Focus();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string auxTexto = textBoxEquacao.Text.Replace("\r", null);
            string[] linhas = auxTexto.Split('\n');
            if (linhas.Length > 1)
            {
                textBoxEquacao.AppendText(linhas[linhas.Length - 2]);
            }
            textBoxEquacao.Focus();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("COS(");
            textBoxEquacao.Focus();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("SEN(");
            textBoxEquacao.Focus();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("TAN(");
            textBoxEquacao.Focus();
        }
# endregion

        private void textBoxEquacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('1'))
                button9_Click(this, e);
            else if (e.KeyChar.Equals('2'))
                button8_Click(this, e);
            else if (e.KeyChar.Equals('3'))
                button7_Click(this, e);
            else if (e.KeyChar.Equals('4'))
                button6_Click(this, e);
            else if (e.KeyChar.Equals('5'))
                button5_Click(this, e);
            else if (e.KeyChar.Equals('6'))
                button4_Click(this, e);
            else if (e.KeyChar.Equals('7'))
                button1_Click(this, e);
            else if (e.KeyChar.Equals('8'))
                button2_Click(this, e);
            else if (e.KeyChar.Equals('9'))
                button3_Click(this, e);
            else if (e.KeyChar.Equals('0'))
                button11_Click(this, e);
            else if (e.KeyChar.Equals('/'))
                button18_Click(this, e);
            else if (e.KeyChar.Equals('*'))
                button15_Click(this, e);
            else if (e.KeyChar.Equals('-'))
                button17_Click(this, e);
            else if (e.KeyChar.Equals('+'))
                button16_Click(this, e);
            else if (e.KeyChar.Equals(','))
                button10_Click(this, e);
            else if (e.KeyChar.Equals('\r'))
                buttonCalcular_Click(this, e);
            else if (e.KeyChar.Equals('\b'))
                button12_Click(this, e);
            else if (e.KeyChar.Equals('^'))
                button13_Click(this, e);
            else if (e.KeyChar.Equals('('))
                button14_Click(this, e);
            else if (e.KeyChar.Equals(')'))
                button19_Click(this, e);
            else if (e.KeyChar.Equals('c') || e.KeyChar.Equals('C'))
                button24_Click(this, e);
            else if (e.KeyChar.Equals('s') || e.KeyChar.Equals('S'))
                button23_Click(this, e);
            else if (e.KeyChar.Equals('t') || e.KeyChar.Equals('T'))
                button22_Click(this, e);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("LOG(");
            textBoxEquacao.Focus();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("SEC(");
            textBoxEquacao.Focus();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("COSSEC(");
            textBoxEquacao.Focus();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("COTG(");
            textBoxEquacao.Focus();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBoxEquacao.AppendText("MOD(");
            textBoxEquacao.Focus();
        }

        private void Resultado()
        {
            if (!saida.Vazia())
            {
                Dados aux = saida.Retirar();
                if (aux.IsNumber())
                {
                    pilhaNumeros.Empilhar(aux);
                    Resultado();
                }
                else
                {
                    Operador op = (Operador)aux;
                    if (Operador.Need2Numbers(op))
                    {
                        try
                        {
                            Valor auxN1 = (Valor)pilhaNumeros.Desempilhar();
                            Valor auxN2 = (Valor)pilhaNumeros.Desempilhar();
                            Valor result = new Valor(op.FazerOperacao(new double[2] { auxN2.Num, auxN1.Num }));
                            pilhaNumeros.Empilhar(result);
                            Resultado();
                            return;
                        }
                        catch (Exception e)
                        {
                            textBoxEquacao.AppendText(Environment.NewLine + "ERRO");
                        }
                    }
                    else
                    {
                        try
                        {
                            Valor auxN1 = (Valor)pilhaNumeros.Desempilhar();
                            Valor result = new Valor(op.FazerOperacao(new double[1] { auxN1.Num }));
                            pilhaNumeros.Empilhar(result);
                            Resultado();
                            return;
                        }
                        catch (Exception e)
                        {
                            textBoxEquacao.AppendText(Environment.NewLine + "ERRO");
                        }
                    }
                }
            }
            else
            {if (erro == false)
                    textBoxEquacao.AppendText(Environment.NewLine + pilhaNumeros.Desempilhar().ToString());
                else
                {
                    textBoxEquacao.Text += Environment.NewLine + "ERRO";
                    erro = false;
                }
            }
        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3(Stopwatch tempo, int valor)
        {
            InitializeComponent();
            Stack<int>[] torres = new Stack<int>[3];
            torres[0] = new Stack<int>(valor);
            torres[1] = new Stack<int>(valor);
            torres[2] = new Stack<int>(valor);
            for (int i = valor; i >= 1; i--)
            {
                torres[0].Push(i);
            }
            tempo.Start();
            Hanoi.Recursivo(valor, torres, 0, 2, 1);
            tempo.Stop();
            textBoxMinutos.Text = tempo.Elapsed.Minutes.ToString();
            textBoxSegundos.Text = tempo.Elapsed.Seconds.ToString();
            textBoxMilisegundos.Text = tempo.Elapsed.TotalMilliseconds.ToString();
            tempo.Reset();
        }
    }
}

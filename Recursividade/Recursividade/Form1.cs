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


namespace Recursividade
{
    public partial class Form1 : Form
    {
        Calculos calc;
        Stopwatch relogio;
        public Form1()
        {
            InitializeComponent();
            calc = new Calculos();
            relogio = new Stopwatch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioFatIte.Checked == true)
            {
                relogio.Start();
                result.Text = calc.FatIterativo(int.Parse(numBox.Text)).ToString();
                relogio.Stop();
            }
            else if (radioFatRe.Checked == true)
            {
                relogio.Start();
                result.Text = calc.FatRecursivo(int.Parse(numBox.Text)).ToString();
                relogio.Stop();
            }
            else if (radioFiRe.Checked == true)
            {
                relogio.Start();
                result.Text = calc.FiboRecursivo(int.Parse(numBox.Text)).ToString();
                relogio.Stop();
            }


            tempo.Text = relogio.ElapsedMilliseconds.ToString() + " ms";
            relogio.Reset();
        }
    }
}

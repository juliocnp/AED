using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Prático
{
    public partial class Form2 : Form
    {
        public Form2(TimeSpan tempo, string resultado)
        {
            InitializeComponent();

            textBoxMinutos.Text = tempo.Minutes.ToString();
            textBoxSegundos.Text = tempo.Seconds.ToString();
            textBoxMilisegundos.Text = tempo.TotalMilliseconds.ToString();

            textBoxResultado.Text = resultado;
        }
    }
}

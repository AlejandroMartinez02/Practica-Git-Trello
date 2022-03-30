using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Git___Trello
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();

        }

        private void cambiarTamanyo(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 25, label1.Font.Style);
        }

        private void retornarTamanyo(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 20, label1.Font.Style);
        }

        private void ticks(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Blue;
            this.progressBar1.Increment(1);
        }
        // a

        int i = 1;

        private void tick_3(object sender, EventArgs e)
        {
            if(i == 1)
            {
                label2.Text = "Cargando .";
                i++;
            }else if(i == 2)
            {
                label2.Text = "Cargando . .";
                i++;
            }
            else
            {
                label2.Text = "Cargando . . .";
                i = 1;
            }
        }

        private void tick_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        private void ticks(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Blue;
            this.progressBar1.Increment(1);
            
        }


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
    }
}

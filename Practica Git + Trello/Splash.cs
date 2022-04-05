using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Practica_Git___Trello
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
            this.circularProgressBar1.Value = 0;


        }
        private void ticks(object sender, EventArgs e)
        {
            this.circularProgressBar1.Increment(1);
            this.circularProgressBar1.Text = this.circularProgressBar1.Value.ToString() + "%";
            if (this.circularProgressBar1.Value == this.circularProgressBar1.Maximum) {
                this.timer2.Enabled = true;
            }
            
        }

        private void cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

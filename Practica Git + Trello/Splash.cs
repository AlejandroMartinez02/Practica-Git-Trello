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

        NpgsqlConnection conn = new NpgsqlConnection(@"Host=ec2-34-246-227-219.eu-west-1.compute.amazonaws.com;Username=cejtrhepkvtxov;Password=78988b91e1724a5a9ec6e0447a558529359ffe42e3c2cbf1e03ec1cda2abbac8;Database=d9d9c375se63vc;");
        bool aux = true;
        public splash()
        {
            InitializeComponent();
            this.circularProgressBar1.Value = 0;

        }
        private void ticks(object sender, EventArgs e)
        {

            this.circularProgressBar1.Increment(1);
            this.circularProgressBar1.Text = this.circularProgressBar1.Value.ToString() + "%";
            if (this.circularProgressBar1.Value == this.circularProgressBar1.Maximum) 
            {
                this.timer2.Enabled = true;
            }
            if(this.circularProgressBar1.Value == 50)
            {
                try
                {
                    conn.Open();
                    
                }
                catch (Exception ex)
                {
                    aux = false;
                }

                this.circularProgressBar1.Value = 86;
            }
            
        }

        private void cerrar(object sender, EventArgs e)
        {
            
            if (aux)
            {

                conn.Close();
                this.Close();
            }
            else
            {
                Application.Exit();
            };
        }
    }
}

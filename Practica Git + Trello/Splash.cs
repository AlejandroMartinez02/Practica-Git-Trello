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

        NpgsqlConnection conn = new NpgsqlConnection(@"Host=ec2-52-48-159-67.eu-west-1.compute.amazonaws.com;Username=hipogxdbddiilb;Password=54dafab8b0782f75f681da9e42410f32bddd82a201c20678ffafb97c4bfa6339;Database=dfcnacrkg93eqm;");
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
                conn.Close();
                Application.Exit();
            };
        }
    }
}

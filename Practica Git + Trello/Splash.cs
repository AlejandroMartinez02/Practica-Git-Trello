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
            NpgsqlConnection conn = new NpgsqlConnection(@"Host=ec2-52-48-159-67.eu-west-1.compute.amazonaws.com;
                                Username=hipogxdbddiilb;
                                Password=54dafab8b0782f75f681da9e42410f32bddd82a201c20678ffafb97c4bfa6339;
                                Database=dfcnacrkg93eqm;");
            this.circularProgressBar1.Value = 0;
            this.circularProgressBar1.Font = new Font(this.circularProgressBar1.Font.Name, 15, this.circularProgressBar1.Font.Style);
        }
        private void ticks(object sender, EventArgs e)
        {
            this.circularProgressBar1.Increment(1);
            this.circularProgressBar1.Text = this.circularProgressBar1.Value.ToString() + "%";

            if(this.circularProgressBar1.Value == this.circularProgressBar1.Maximum)
            {
                this.timer2.Enabled = true;
            }
            
        }

        private void cerrar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

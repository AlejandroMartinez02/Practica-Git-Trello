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
    public partial class Resultado : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection(@"Host=ec2-52-48-159-67.eu-west-1.compute.amazonaws.com;Username=hipogxdbddiilb;Password=54dafab8b0782f75f681da9e42410f32bddd82a201c20678ffafb97c4bfa6339;Database=dfcnacrkg93eqm;");


        public Resultado()
        {
            InitializeComponent();

            try
            {
                conn.Open();
                label2.Text = conn.State.ToString();
            }
            catch (Exception ex)
            {
                label2.Text = conn.State.ToString();
            }

            
        }

        public DataTable SelectT(string nom)
        {
            string cons = "select * from \"Usuario\" ";
            NpgsqlCommand conector = new NpgsqlCommand(cons, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable table = new DataTable();
            datos.Fill(table);

            return table;
        }


        public NpgsqlCommand GetCommand()
        {
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = this.conn;

            comm.CommandText = "SELECT nombre from USUARIO";

            

            return comm;
        }


        private void cerrarJuego(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarNombre(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            formPrincipal formP = new formPrincipal();
            formP.ShowDialog();
            this.Show();
        }

        private void reiniciar(object sender, EventArgs e)
        {
            this.Hide();
            formPrincipal formP = new formPrincipal();
            formP.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

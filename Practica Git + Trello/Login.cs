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
    public partial class Login : Form
    {
        
        NpgsqlConnection conn = new NpgsqlConnection(@"Host=ec2-52-48-159-67.eu-west-1.compute.amazonaws.com;Username=hipogxdbddiilb;Password=54dafab8b0782f75f681da9e42410f32bddd82a201c20678ffafb97c4bfa6339;Database=dfcnacrkg93eqm;");

        public Login()
        {
            InitializeComponent();
            conn.Open();
        }

        public NpgsqlCommand GetCommand()
        {
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = this.conn;

            return comm;
        }

        public void insert_Values(String nombre)
        {
            NpgsqlCommand comm = this.GetCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "INSERT INTO USUARIO(nombre) VALUES('" + nombre + "')";
            comm.ExecuteNonQuery();
        }

        private void btn_avanzar_Click(object sender, EventArgs e)
        {
            if (tb_usuario.Text.Equals(""))
            {
                MessageBox.Show("No ha introducido ningún nombre, por favor introduzca uno.", "El sistema le dice...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                insert_Values(tb_usuario.Text);
                conn.Close();
                this.Close();

            }
        }

    }
}

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
using System.Media;


namespace Practica_Git___Trello
{
    public partial class Login : Form
    {
        
        NpgsqlConnection conn = new NpgsqlConnection(@"Host=ec2-34-246-227-219.eu-west-1.compute.amazonaws.com;Username=cejtrhepkvtxov;Password=78988b91e1724a5a9ec6e0447a558529359ffe42e3c2cbf1e03ec1cda2abbac8;Database=d9d9c375se63vc;");

        public Login()
        {
            InitializeComponent();
            conn.Open();
            playSimpleSound();
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

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\dam1\Desktop\song.wav");
            simpleSound.Play();
        }

        private void pb_Logo_Click(object sender, EventArgs e)
        {

        }
    }
}

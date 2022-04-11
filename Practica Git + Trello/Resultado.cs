using System;
using System.Collections;
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
        NpgsqlConnection conn = new NpgsqlConnection(@"Host=ec2-34-246-227-219.eu-west-1.compute.amazonaws.com;Username=cejtrhepkvtxov;Password=78988b91e1724a5a9ec6e0447a558529359ffe42e3c2cbf1e03ec1cda2abbac8;Database=d9d9c375se63vc;");


        public Resultado()
        {
            InitializeComponent();

            try
            {
                conn.Open();
                label3.Text = conn.State.ToString();
            }
            catch (Exception ex)
            {
                label3.Text = conn.State.ToString();
            }

            String SelectN = "SELECT nombre, id_usuario FROM usuario";
            String SelectPun = "SELECT puntos FROM responder";
            String SelectAci = "SELECT acierto FROM responder";
            NpgsqlCommand comm = new NpgsqlCommand(SelectN, conn);
            NpgsqlDataReader nda = comm.ExecuteReader();
            ArrayList NameId = new ArrayList();
            ArrayList Puntos = new ArrayList();
            ArrayList Acierto = new ArrayList();
            //
            while (nda.Read())
            {
                String name = nda["nombre"].ToString();
                String id = nda["id_usuario"].ToString();
                String punt = nda["puntos"].ToString();
                String acierto = nda["acierto"].ToString();
                NameId.Add(name);
                Puntos.Add(punt);
                Acierto.Add(acierto);
            }

            int max = 0, pos1 = 0;

            for(int i =0; i < Acierto.Count; i++)
            {
                if(Convert.ToInt32(Acierto[i].ToString()) > max)
                {
                    max = Convert.ToInt32(Acierto[i].ToString());
                    pos1 = i;
                }



            }
            
            
            Top1.Text = NameId[pos1].ToString() + "///" + Puntos[pos1].ToString() + "///" + Acierto[pos1].ToString();
            Top2.Text = NameId[0].ToString() + "///" + Puntos[0].ToString() + "///" + Acierto[0].ToString();
            Top3.Text = NameId[0].ToString() + "///" + Puntos[0].ToString() + "///" + Acierto[0].ToString();
            Top4.Text = NameId[0].ToString() + "///" + Puntos[0].ToString() + "///" + Acierto[0].ToString();
            Top5.Text = NameId[0].ToString() + "///" + Puntos[0].ToString() + "///" + Acierto[0].ToString();
            Top6.Text = NameId[0].ToString() + "///" + Puntos[0].ToString() + "///" + Acierto[0].ToString(); 

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

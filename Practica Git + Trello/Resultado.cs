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
            conn.Open();
            String SelectN = "SELECT u.nombre, u.id_usuario, SUM(r.puntos) as puntos, COUNT(r.acierto) FROM usuario u, responder r WHERE r.id_usuario = u.id_usuario GROUP BY(u.id_usuario, u.nombre, r.acierto) ORDER BY puntos DESC LIMIT 6; ";
            NpgsqlCommand comm = new NpgsqlCommand(SelectN, conn);
            NpgsqlDataReader nda = comm.ExecuteReader();
            ArrayList NameId = new ArrayList();
            ArrayList Puntos = new ArrayList();
            ArrayList Acierto = new ArrayList();
            //
            while (nda.Read())
            {
                String name = nda["nombre"].ToString();  //Aqui si sale error es porque a lo mejor le falta o le sobra (u.* o r.*)
                String id = nda["id_usuario"].ToString();
                String punt = nda["puntos"].ToString();
                String acierto = nda["acierto"].ToString();
                NameId.Add(name);
                Puntos.Add(punt);
                Acierto.Add(acierto);
            }

            Top1.Text = NameId[1].ToString() + "///" + Puntos[1].ToString() + "///" + Acierto[1].ToString();
            Top2.Text = NameId[2].ToString() + "///" + Puntos[2].ToString() + "///" + Acierto[2].ToString();
            Top3.Text = NameId[3].ToString() + "///" + Puntos[3].ToString() + "///" + Acierto[3].ToString();
            Top4.Text = NameId[4].ToString() + "///" + Puntos[4].ToString() + "///" + Acierto[4].ToString();
            Top5.Text = NameId[5].ToString() + "///" + Puntos[5].ToString() + "///" + Acierto[5].ToString();
            Top6.Text = NameId[6].ToString() + "///" + Puntos[6].ToString() + "///" + Acierto[6].ToString();


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

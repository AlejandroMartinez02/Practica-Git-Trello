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
            int aci = 0;
            InitializeComponent();
            conn.Open();
            String SelectN = "SELECT u.nombre, u.id_usuario, SUM(r.puntos) as puntos, COUNT(r.acierto) as acierto FROM usuario u, responder r WHERE r.id_usuario = u.id_usuario and r.acierto = true GROUP BY(u.id_usuario, u.nombre) ORDER BY puntos DESC LIMIT 6; ";
            NpgsqlCommand comm = new NpgsqlCommand(SelectN, conn);
            NpgsqlDataReader nda = comm.ExecuteReader();
            ArrayList NameId = new ArrayList();
            ArrayList Puntos = new ArrayList();
            ArrayList Acierto = new ArrayList();

            while (nda.Read())
            {
                String name = nda["nombre"].ToString();  
                String punt = nda["puntos"].ToString();
                String acierto = nda["acierto"].ToString();
                NameId.Add(name);
                Puntos.Add(punt);
                Acierto.Add(acierto);
            }

            
            Label[] label = new Label[6];
            label[0] = Top1;
            label[1] = Top2;
            label[2] = Top3;
            label[3] = Top4;
            label[4] = Top5;
            label[5] = Top6;
            Label [] label1 = new Label[6];
            label1[0] = r1;
            label1[1] = r2;
            label1[2] = r3;
            label1[3] = r4;
            label1[4] = r5;
            label1[5] = r6;

           

            for (int i = 0; i < NameId.Count; i++)
            {
                label[i].Text = NameId[i].ToString();
                label1[i].Text = "Puntos: " + Puntos[i].ToString() +"\n"+ "Aciertos: " + Acierto[i].ToString();
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Resultado_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Top6_Click(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
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
            String SelectN = "SELECT u.nombre, u.id_usuario, SUM(r.puntos) as puntos, r.acierto FROM usuario u, responder r WHERE r.id_usuario = u.id_usuario GROUP BY(u.id_usuario, u.nombre, r.acierto) ORDER BY puntos DESC LIMIT 6; ";
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

            int p1 = 0, pos1 = 0, p2 = 0, pos2 = 0, pos3 = 0, pos4 = 0, pos5 = 0, pos6 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0;

            for (int i = 0; i < Puntos.Count; i++)
            {
                if (Convert.ToInt32(Puntos[i].ToString()) > p1)
                {
                    p1 = Convert.ToInt32(Puntos[i].ToString());
                    pos1 = i;
                }
                else if (Convert.ToInt32(Puntos[i].ToString()) > p2 & Convert.ToInt32(Puntos[i].ToString()) < p1)
                {
                    p2 = Convert.ToInt32(Puntos[i].ToString());
                    pos2 = i;
                }
                else if (Convert.ToInt32(Puntos[i].ToString()) > p3 & Convert.ToInt32(Puntos[i].ToString()) < p2)
                {
                    p3 = Convert.ToInt32(Puntos[i].ToString());
                    pos3 = i;
                }
                else if (Convert.ToInt32(Puntos[i].ToString()) > p4 & Convert.ToInt32(Puntos[i].ToString()) < p3)
                {
                    p4 = Convert.ToInt32(Puntos[i].ToString());
                    pos4 = i;
                }
                else if (Convert.ToInt32(Puntos[i].ToString()) > p5 & Convert.ToInt32(Puntos[i].ToString()) < p4)
                {
                    p5 = Convert.ToInt32(Puntos[i].ToString());
                    pos5 = i;
                }
                else if (Convert.ToInt32(Puntos[i].ToString()) > p6 & Convert.ToInt32(Puntos[i].ToString()) < p5)
                {
                    p6 = Convert.ToInt32(Puntos[i].ToString());
                    pos6 = i;
                }
            }


            Top1.Text = NameId[pos1].ToString() + "///" + Puntos[pos1].ToString() + "///" + Acierto[pos1].ToString();
            Top2.Text = NameId[pos2].ToString() + "///" + Puntos[pos2].ToString() + "///" + Acierto[pos2].ToString();
            Top3.Text = NameId[pos3].ToString() + "///" + Puntos[pos3].ToString() + "///" + Acierto[pos3].ToString();
            Top4.Text = NameId[pos4].ToString() + "///" + Puntos[pos4].ToString() + "///" + Acierto[pos4].ToString();
            Top5.Text = NameId[pos5].ToString() + "///" + Puntos[pos5].ToString() + "///" + Acierto[pos5].ToString();
            Top6.Text = NameId[pos6].ToString() + "///" + Puntos[pos6].ToString() + "///" + Acierto[pos6].ToString();


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

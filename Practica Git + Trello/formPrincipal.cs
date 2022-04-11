using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Npgsql;
using System.Collections;

namespace Practica_Git___Trello
{
    public partial class formPrincipal : Form
    {

        public int counter = 30;
        public NpgsqlConnection conn = new NpgsqlConnection(@"Host=ec2-34-246-227-219.eu-west-1.compute.amazonaws.com;Username=cejtrhepkvtxov;Password=78988b91e1724a5a9ec6e0447a558529359ffe42e3c2cbf1e03ec1cda2abbac8;Database=d9d9c375se63vc;");
        ArrayList numeros = new ArrayList();
        ArrayList preguntas = new ArrayList();
        ArrayList respuestas = new ArrayList();

        public formPrincipal()
        {
            InitializeComponent();
            boton_A.Size = new Size(panel1.Size.Width / 2, panel1.Size.Height / 2);
            boton_B.Size = new Size(panel1.Size.Width / 2, panel1.Size.Height / 2);
            boton_C.Size = new Size(panel1.Size.Width / 2, panel1.Size.Height / 2);
            boton_D.Size = new Size(panel1.Size.Width / 2, panel1.Size.Height / 2);
            conn.Open();



            //Iteramos hasta que la lista tenga 10 elementos
            while (numeros.Count < 10)
            {
                //Recuperamos un número aleatorio entre 10000 y 100000
                int numeroAleatorio = new Random().Next(1, 61);

                //Sólo si el número generado no existe en lalista se agrega
                if (!numeros.Contains(numeroAleatorio))
                {
                    numeros.Add(numeroAleatorio);
                }
            }

            foreach (int n in numeros)
            {
                NpgsqlCommand comm = new NpgsqlCommand("SELECT * FROM pregunta WHERE id_pregunta = " + n, conn);
                NpgsqlDataReader nda = comm.ExecuteReader();
                while (nda.Read())
                {
                    String titulo = nda["titulo"].ToString();
                    String respuestaA = nda["respuesta_A"].ToString();
                    String respuestaB = nda["respuesta_B"].ToString();
                    String respuestaC = nda["respuesta_C"].ToString();
                    String respuestaD = nda["respuesta_D"].ToString();
                    preguntas.Add(titulo);
                    respuestas.Add(respuestaA);
                    respuestas.Add(respuestaB);
                    respuestas.Add(respuestaC);
                    respuestas.Add(respuestaD);
                }
                nda.Close();
            }

            
            
        }

        private void cambiarTamanyo(object sender, EventArgs e)
        {
            boton_A.Size = new Size(panel1.Size.Width / 2, panel1.Size.Height / 2);
            boton_B.Size = new Size(panel1.Size.Width / 2, panel1.Size.Height / 2);
            boton_C.Size = new Size(panel1.Size.Width / 2, panel1.Size.Height / 2);
            boton_D.Size = new Size(panel1.Size.Width / 2, panel1.Size.Height / 2);
        }

        private void clickBotonA(object sender, EventArgs e)
        {
            int usuario = encontrarIdUsuario();
            String respuestaCorrecta = encontrarRespuestaCorrecta();

            if (respuestaCorrecta.Equals("A"))
            {
                NpgsqlCommand comm = new NpgsqlCommand("INSERT INTO responder VALUES(" + usuario + ", " + preguntas[0] + ", A ," + respuestaCorrecta + ", " + true + ", " + counter + ", " + 20 + "); ", conn);
                NpgsqlDataReader nda = comm.ExecuteReader();
            }
            else
            {
                NpgsqlCommand comm = new NpgsqlCommand("INSERT INTO responder VALUES(" + usuario + ", " + preguntas[0] + ", A ," + respuestaCorrecta + ", " + false + ", " + counter + ", " + 0 + "); ", conn);
                NpgsqlDataReader nda = comm.ExecuteReader();
            }

        }
        private int encontrarIdUsuario()
        {
            NpgsqlCommand usu = new NpgsqlCommand("SELECT MAX(id_usuario) FROM usuarios", conn);
            NpgsqlDataReader commUsu = usu.ExecuteReader();
            return int.Parse(commUsu.ToString());
        }

        private String encontrarRespuestaCorrecta()
        {
            NpgsqlCommand pregunta = new NpgsqlCommand("SELECT r_correcta FROM preguntas WHERE id_pregunta = " + preguntas[0]);
            NpgsqlDataReader commPreg = pregunta.ExecuteReader();
            return commPreg.ToString();
        }
    }
}

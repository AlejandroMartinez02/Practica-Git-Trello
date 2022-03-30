using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Git___Trello
{
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            formPrincipal formP = new formPrincipal();

            formP.Show();
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
            formPrincipal otroIntento = new formPrincipal();
            otroIntento.ShowDialog();
            this.Show();
        }
    }
}

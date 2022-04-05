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

namespace Practica_Git___Trello
{
    public partial class formPrincipal : Form
    {
        String rutaDelArchivo = "./datos.txt";

        int counter = 30;

        public formPrincipal()
        {
            this.autoTamaño();
            InitializeComponent();
            boton_A.BackColor = ColorTranslator.FromHtml("#e21b3c");
            boton_B.BackColor = ColorTranslator.FromHtml("#1268cd");
            boton_C.BackColor = ColorTranslator.FromHtml("#d89e00");
            boton_D.BackColor = ColorTranslator.FromHtml("#2a8f0d");

            this.BackColor = ColorTranslator.FromHtml("#f2f2f2");
        }

        private void boton_A_Click(object sender, EventArgs e)
        {

        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void CambioTamaño(object sender, EventArgs e)
        {
            this.autoTamaño();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void cambiarPanel(object sender, EventArgs e)
        {
            formPrincipal f1 = new formPrincipal();
            panel1.Size = new Size(f1.Size.Width, f1.Size.Height / 3);
        }

        private void ticks(object sender, EventArgs e)
        {
            
            label1.Text = counter.ToString();
            counter -= 1;
        }

        public void autoTamaño()
        {
            boton_A.Size = new Size(panel1.Size.Width / 2, panel1.Size.Height / 2);
            boton_B.Size = new Size(panel1.Size.Width / 2, panel1.Size.Height / 2);
            boton_C.Size = new Size(panel1.Size.Width / 2, panel1.Size.Height / 2);
            boton_D.Size = new Size(panel1.Size.Width / 2, panel1.Size.Height / 2);
        }

    }
}

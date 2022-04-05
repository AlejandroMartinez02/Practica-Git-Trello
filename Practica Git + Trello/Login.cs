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
    public partial class Login : Form
    {
        String nombreUsuario;
        public Login()
        {
            InitializeComponent();
            
        }



        private void btn_avanzar_Click(object sender, EventArgs e)
        {
            if (tb_usuario.Text.Equals(""))
            {
                MessageBox.Show("No ha introducido ningún nombre, por favor introduzca uno.", "El sistema le dice...", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                nombreUsuario = tb_usuario.Text;

                this.Close();

            }
        }

        private void tb_usuario_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

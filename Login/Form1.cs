using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Ventana : Form
    {
        Entrada log;
        public Ventana()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UsuarioLB_Click(object sender, EventArgs e)
        {

        }

        private void Ventana_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if ((tbusuario.Text != "") && (tbcontraseña.Text != "")) ;
            {
                if ((tbusuario.Text == "admin") && (tbcontraseña.Text == "pass")) ;
                {
                    log = new Entrada();
                    log.Show();
                    this.Hide();
                }
            }
        }
    }
}

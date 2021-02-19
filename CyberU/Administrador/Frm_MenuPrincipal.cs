using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberU.OnlyCodes;

namespace CyberU.Administrador
{
    public partial class Frm_MenuPrincipal : Form
    {
        public static int idusuario;
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }
     
        private void buttonCursos_Click(object sender, EventArgs e)
        {//Redirije al login admin

            LoginTipo.Frm_Admin Login = new LoginTipo.Frm_Admin();
            Login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {//Redirije al login Sale del programa
            Application.Exit();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            LoginTipo.Frm_Admin Login = new LoginTipo.Frm_Admin();
            Login.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            FrmSoporteTecnico s = new FrmSoporteTecnico();
            s.Show();
            this.Hide();
        }

        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

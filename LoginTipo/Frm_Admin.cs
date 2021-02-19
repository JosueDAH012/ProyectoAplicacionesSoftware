using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberU.Administrador;
using CyberU.OnlyCodes;
namespace CyberU.LoginTipo
{
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();
        }

        private void button_Ingresar_Click(object sender, EventArgs e)
        {


            if (ValidacionDatos.AdminClaveValida(txt_ingresa_usuario.Text, txt_ingresa_contra.Text))
            {
                Administrador.Frm_MantenimientoAdmin Admin = new Administrador.Frm_MantenimientoAdmin();
                Admin.Show();
                this.Close();
                return;
            }
            MessageBox.Show("Datos Incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        private void cboxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            Administrador.Frm_MenuPrincipal menuPrincipal = new Administrador.Frm_MenuPrincipal();
            menuPrincipal.Visible = true;
            this.Hide();
        }

        private void txt_ingresa_contra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ingresa_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContra_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}

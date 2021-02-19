using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberU.Administrador
{
    public partial class Frm_MantenimientoAdmin : Form
    {
        public Frm_MantenimientoAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_GestionarAdmin Admin = new Frm_GestionarAdmin();
            Admin.Show();
            this.Hide();
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            Frm_MenuPrincipal menuPrincipal = new Frm_MenuPrincipal();
            this.Hide();
            menuPrincipal.Show();
        }

        private void btnIngresarEstudiante_Click(object sender, EventArgs e)
        {
            Frm_RegistroEstudiante frmest = new Frm_RegistroEstudiante();
            this.Hide();
            frmest.Show();   
        }

        private void Frm_MantenimientoAdmin_Load(object sender, EventArgs e)
        {
        }

        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            Administrador.Frm_MenuPrincipal menuPrincipal = new Administrador.Frm_MenuPrincipal();
            menuPrincipal.Visible = true;
            this.Hide();
        }

        private void buttonModificarCurso_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void buttonListaCursos_Click(object sender, EventArgs e)
        {
            Frm_ListaCursos frm_ListaCursos = new Frm_ListaCursos();
            frm_ListaCursos.Show();
            this.Hide();
        }

        private void buttonGestionarCursos_Click(object sender, EventArgs e)
        {
            Frm_GestionarCurso frm_gestionarCurso = new Frm_GestionarCurso();
            frm_gestionarCurso.Show();
            this.Hide();
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            Frm_GestionarAdmin Admin = new Frm_GestionarAdmin();
            Admin.Show();
            this.Hide();
        }

        private void btnIngresarCursosEstudiante_Click(object sender, EventArgs e)
        {
            IngresarCursosEstudiante ingresarCursosEstudiante = new IngresarCursosEstudiante();
            ingresarCursosEstudiante.Show();
            this.Hide();
        }
    }
}

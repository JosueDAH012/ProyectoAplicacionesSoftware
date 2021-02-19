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
    public partial class Frm_RegistroProfesor : Form
    {
        public Frm_RegistroProfesor()
        {
            InitializeComponent();
        }

        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoAdmin frm_MantenimientoAdmin = new Frm_MantenimientoAdmin();
            frm_MantenimientoAdmin.Show();
            this.Hide();
        }

        private void btnRegistarProf_Click(object sender, EventArgs e)
        {

        }
    }
}

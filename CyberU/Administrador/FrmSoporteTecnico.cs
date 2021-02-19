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
    public partial class FrmSoporteTecnico : Form
    {
        public FrmSoporteTecnico()
        {
            InitializeComponent();
        }

        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal frm_MenuPrincipal = new Frm_MenuPrincipal();
            frm_MenuPrincipal.Show();
            this.Hide();
        }
    }
}

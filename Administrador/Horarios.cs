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
    public partial class Horarios : Form
    {
        public Frm_GestionarCurso frm_Gestionar { get;}
        public Horarios(Frm_GestionarCurso _frm_Gestionar)
        {
            this.frm_Gestionar = _frm_Gestionar;
            InitializeComponent();
        }

        private void gridviewHorarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int horarioIndice = gridviewHorarios.CurrentCell.RowIndex + 1;
            this.frm_Gestionar.txtHorario.Text = horarioIndice.ToString();
            this.Hide();
        }

        private void Horarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matricula3DataSetHorarios.Horarios' Puede moverla o quitarla según sea necesario.
            this.horariosTableAdapter.Fill(this.matricula3DataSetHorarios.Horarios);

        }
    }
}

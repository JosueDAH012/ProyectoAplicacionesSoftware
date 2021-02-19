using CyberU.OnlyCodes;
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
    public partial class Frm_ListaCursos : Form
    {
        public Frm_ListaCursos()
        {
            InitializeComponent();
        }

        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoAdmin frm_MantenimientoAdmin = new Frm_MantenimientoAdmin();
            frm_MantenimientoAdmin.Show();
            this.Hide();
        }

        private void Frm_ListaCursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matricula3DataSetCursos.Cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.matricula3DataSetCursos.Cursos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewCursos.SelectedRows.Equals(null))
            {
                MessageBox.Show("Por favor, Seleccione un item de la lista", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogeliminar = MessageBox.Show("¿Desea Eliminar el curso?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogeliminar == DialogResult.Yes)
                {
                    try
                    {
                        GestionamientoCursos gestionamientoCursos = new GestionamientoCursos();
                        int indexcurso = int.Parse(dataGridViewCursos.CurrentCell.Value.ToString());
                        gestionamientoCursos.BorrarCursodeEstudiantes(indexcurso);
                        gestionamientoCursos.BorrarCURSO(indexcurso);
                        MessageBox.Show("Curso Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.cursosTableAdapter.Fill(this.matricula3DataSetCursos.Cursos);
                    }catch(Exception exe)
                    {
                        MessageBox.Show("Ocurrio un error. Por favor intentelo mas tarde" + exe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }              
                }
            }
        }
    }
}

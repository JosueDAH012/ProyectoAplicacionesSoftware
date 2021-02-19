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
    public partial class Frm_GestionarCurso : Form
    {
        public Frm_GestionarCurso()
        {
            InitializeComponent();
        }

        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoAdmin frm_MantenimientoAdmin = new Frm_MantenimientoAdmin();
            frm_MantenimientoAdmin.Show();
            this.Hide();
        }

        private void Frm_GestionarCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matricula3DataSetHorarios.Horarios' Puede moverla o quitarla según sea necesario.
            this.horariosTableAdapter.Fill(this.matricula3DataSetHorarios.Horarios);
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            Horarios horarios = new Horarios(this);
            horarios.Show();
        }

        private void btnIngresarCurso_Click(object sender, EventArgs e)
        {
            GestionamientoCursos gestionamientoCursos = new GestionamientoCursos();
            DateTime fechainicio = dateInicioCurso.Value;
            DateTime fechafin = dateFinCurso.Value;
            float precio = float.Parse(txtPrecio.Text);
            int horarioid = int.Parse(txtHorario.Text);
            try
            {
                if (checkboxnuevo.Checked)
                { /*Si es nuevo*/
                    if (CamposVacios())
                    {/*Si hay campos vacios*/
                        MessageBox.Show("Por favor Rellene todos los espacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        /*Caso contrario. Se procede a realizar el ingreso de curso al sistema*/
                        DialogResult dialogingresar = MessageBox.Show("¿Desea Ingresar Nuevo Curso?", "Ingresar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogingresar == DialogResult.Yes)
                        {
                            gestionamientoCursos.IngresaCURSO(txtnombreCurso.Text, precio, fechainicio, fechafin, horarioid);
                            MessageBox.Show("Datos Ingresados Existosamente", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        return;
                    }
                }
                else
                {
                    if (CamposVacios())
                    {
                        MessageBox.Show("Por favor Rellene todos los espacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    { /*Procede a actualizar curso*/
                        DialogResult dialogingresar = MessageBox.Show("¿Desea Actualizar el Curso?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogingresar == DialogResult.Yes)
                        {
                            int codigocurso = int.Parse(txtcodigoCurso.Text);
                            gestionamientoCursos.ActualizarCurso(codigocurso, txtnombreCurso.Text, precio, fechainicio, fechafin, horarioid);
                            MessageBox.Show("Datos Actualizados Existosamente", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    return;
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show("Ocurrio un Error. Por favor Intentelo mas tarde.\n " + exe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkboxnuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxnuevo.Checked)
            {
                txtcodigoCurso.Enabled = false;
            }
            else
            {
                txtcodigoCurso.Enabled = true;
            }
        }

        private bool CamposVacios()
        {
            return (EspacioVacio(txtHorario) || EspacioVacio(txtnombreCurso) || EspacioVacio(txtPrecio));
        }
        private bool EspacioVacio(TextBox text)
        {
            return (text.Text.Equals("") || text.Text.Equals(" "));
        }
    }
}

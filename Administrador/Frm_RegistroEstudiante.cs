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
    public partial class Frm_RegistroEstudiante : Form
    {
        /*VENTANA PARA MODIFICAR/INGRESAR UN NUEVO ESTUDIANTE*/       
        public Frm_RegistroEstudiante()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                MessageBox.Show("Por favor Rellene todos los espacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                GestionamientoUsuarios gu = new GestionamientoUsuarios();
                DateTime fechanac = dateFechaNac.Value;
                var cedula = int.Parse(txtCedula.Text);
                Int64 tel = int.Parse(txtTel.Text);
                if (ValidacionDatos.ExisteCodigo(cedula))
                {
                    /*SI EXISTE EL CODIGO, SE ACTUALIZA EL ESTUDIANTE*/
                    DialogResult dialogactualizar = MessageBox.Show("¿Desea Actualizar Datos del Estudiante?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogactualizar == DialogResult.Yes)
                    {
                        gu.ActualizarESTUDIANTE(cedula, txtNombre.Text, txtApl.Text, fechanac, txtCorreo.Text, tel);
                        MessageBox.Show("Datos Actualizados Existosamente", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    return;
                }

                /*DE LO CONTRARIO, SE INGRESA UN ESTUDIANTE NUEVO*/
                DialogResult dialogingresar = MessageBox.Show("¿Desea Ingresar Nuevo Estudiante?", "Ingresar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogingresar == DialogResult.Yes)
                {
                    gu.IngresaESTUDIANTE(cedula, txtNombre.Text, txtApl.Text, fechanac, txtCorreo.Text, tel);
                    MessageBox.Show("Datos Ingresados Existosamente", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                return;
            }
            catch (Exception exe)
            {
                MessageBox.Show("Ocurrio un Error. Por favor Intentelo mas tarde.\n " + exe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                  
        }

        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoAdmin mantenimientoAdmin = new Frm_MantenimientoAdmin();
            mantenimientoAdmin.Show();
            this.Hide();
        }

        private bool CamposVacios()
        {
            return (EspacioVacio(txtNombre) || EspacioVacio(txtApl) || EspacioVacio(txtCedula) || EspacioVacio(txtCorreo) || EspacioVacio(txtTel));
        }

        private bool EspacioVacio(TextBox textBox)
        {
            return (textBox.Text.Equals("") || textBox.Text.Equals(" "));
        }
    }
}

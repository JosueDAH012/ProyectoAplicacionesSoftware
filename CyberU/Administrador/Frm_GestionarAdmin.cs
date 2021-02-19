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
using CyberU.Administrador;
namespace CyberU.Administrador

{
    public partial class Frm_GestionarAdmin : Form
    {
        public Frm_GestionarAdmin()
        {
            InitializeComponent();
        }

        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoAdmin mantenimientoAdmin = new Frm_MantenimientoAdmin();
            mantenimientoAdmin.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            GestionamientoUsuarios gu = new GestionamientoUsuarios();
            DateTime fechanac = dateFechaNacimiento.Value;
            try
            {
                if (checkboxnuevo.Checked)
                {
                    if (CamposVacios())
                    {
                        MessageBox.Show("Por favor Rellene todos los espacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DialogResult dialogingresar = MessageBox.Show("¿Desea Ingresar Nuevo Administrador?", "Ingresar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogingresar == DialogResult.Yes)
                    {
                        gu.IngresaADMIN(txtBoxNombre.Text, fechanac, txtCorreo.Text, txtUsuario.Text, txtPassword.Text);
                        MessageBox.Show("Datos Ingresados Existosamente", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    return;
                }
                else
                {
                    if (CamposVacios())
                    {
                        MessageBox.Show("Por favor Rellene todos los espacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        var id = int.Parse(txtBoxCodigo.Text);
                        if (ValidacionDatos.ExisteCodigoAdmin(id))
                        {
                            DialogResult dialogactualizar = MessageBox.Show("¿Desea Actualizar Datos del Administrador?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialogactualizar == DialogResult.Yes)
                            {
                                gu.ActualizarAdmin(id, fechanac, txtBoxNombre.Text, txtCorreo.Text, txtUsuario.Text, txtPassword.Text);
                                MessageBox.Show("Datos Actualizados Existosamente", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            return;
                        }

                    }
                }

            }
            catch (Exception exe)
            {
                MessageBox.Show("Ocurrio un Error. Por favor Intentelo mas tarde.\n " + exe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CamposVacios()
        {
            return (EspacioVacio(txtBoxNombre) || EspacioVacio(txtCorreo) || EspacioVacio(txtPassword) || EspacioVacio(txtUsuario));
        }

        private bool EspacioVacio(TextBox textBox)
        {
            return (textBox.Text.Equals("") || textBox.Text.Equals(" "));
        }

        private void checkboxnuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxnuevo.Checked)
            {
                txtBoxCodigo.Enabled = false;
            }
            else
            {
                txtBoxCodigo.Enabled = true;
            }
        }
    }
}

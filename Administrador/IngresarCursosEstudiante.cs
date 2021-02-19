using CyberU.OnlyCodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberU.Administrador
{
    public partial class IngresarCursosEstudiante : Form
    {
        public List<int> cursosids = new List<int>();
        int precioTotal = 0;
        public IngresarCursosEstudiante()
        {
            InitializeComponent();           
        }

        private void IngresarCursosEstudiante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'matricula3DataSetEstudiantesCursos.Estudiantes_Cursos' Puede moverla o quitarla según sea necesario.
            this.estudiantes_CursosTableAdapter.Fill(this.matricula3DataSetEstudiantesCursos.Estudiantes_Cursos);
            // TODO: esta línea de código carga datos en la tabla 'matricula3DataSet.Cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.matricula3DataSet.Cursos);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cedula = int.Parse(txtCedula.Text);
            txtNombre.Text = getNombre(cedula);
            txtCorreo.Text = getCorreo(cedula);
            this.estudiantes_CursosTableAdapter.Fill(this.matricula3DataSetEstudiantesCursos.Estudiantes_Cursos);
            this.cursosTableAdapter.Fill(this.matricula3DataSet.Cursos);

        }

        private void dataGridViewDisponibles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pkcursoid = int.Parse(dataGridViewDisponibles.CurrentCell.OwningRow.Cells[0].Value.ToString());
            cursosids.Add(pkcursoid);
            precioTotal += int.Parse(dataGridViewDisponibles.CurrentCell.OwningRow.Cells[2].Value.ToString());
            lblPrecioTotal.Text = precioTotal.ToString();                  
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            GestionamientoMatricula gestionamientoMatricula = new GestionamientoMatricula();
            GestionamientoCursos gestionamientoCursos = new GestionamientoCursos();
            try
            {
                DialogResult dialogejecutar = MessageBox.Show("¿Desea Ejecutar la Transaccion?", "Ejecutar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogejecutar == DialogResult.Yes)
                {
                    Int64 cedula = Int64.Parse(txtCedula.Text);
                    foreach (int pkcurso in cursosids)
                    {
                        gestionamientoMatricula.IngresaCursosdeCliente(cedula, pkcurso);
                    }
                    gestionamientoMatricula.IngresaFactura(DateTime.Now, cedula, 1);
                    gestionamientoMatricula.IngresaFacturadeCliente(cedula, ultimafactura());
                    MessageBox.Show("Matricula Realizada de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }               
            }
            catch(Exception exe)
            {
                MessageBox.Show("Ocurrio un Error. Por favor Intentelo mas tarde.\n " + exe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                      
        }

        private int ultimafactura()
        {
            int facturaid = 0;
            string sql = "SELECT MAX(PK_ID_Factura) FROM Facturas";
            using (SqlConnection conn = new SqlConnection(ValidacionDatos.RetornaDataConfig()))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    facturaid = (int)cmd.ExecuteScalar();
                    return facturaid; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
        }
        private string getNombre(int cedula)
        {
            string sql = "SELECT Nombre_Estudiante FROM Estudiantes WHERE PK_Cedula_Estudiante = @cedula";
            using (SqlConnection conx = new SqlConnection(ValidacionDatos.RetornaDataConfig()))
            {
                SqlCommand cmd = new SqlCommand(sql, conx);
                try
                {
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    conx.Open();
                    return (string)cmd.ExecuteScalar();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
            }
        }

        private string getCorreo(int cedula)
        {
            string sql = "SELECT Correo_Estudiante FROM Estudiantes WHERE PK_Cedula_Estudiante = @cedula";
            using (SqlConnection conx = new SqlConnection(ValidacionDatos.RetornaDataConfig()))
            {
                SqlCommand cmd = new SqlCommand(sql, conx);
                try
                {
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    conx.Open();
                    return (string)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
        }

        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoAdmin frm_MantenimientoAdmin = new Frm_MantenimientoAdmin();
            this.Hide();
            frm_MantenimientoAdmin.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberU.OnlyCodes
{
    public class GestionamientoMatricula
    {
        /*CLASE ESPECIFICAMENTE PARA EL GESTIONAMIENTO DE FACTURACION Y MATRICULA DE CURSOS*/
        public void IngresaFactura(DateTime FECHA_FACTURA,Int64 Cedula, int tipoFactura)
        {
            /*INGRESA UNA FACTURA DADA*/
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Facturas " +
            "VALUES (@Fecha,@Cedula,@Tipo)"))
            {
                cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = FECHA_FACTURA.Date;
                cmd.Parameters.AddWithValue("@Cedula", Cedula);
                cmd.Parameters.AddWithValue("@Tipo", tipoFactura);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }

        }
        public void IngresaFacturadeCliente(Int64 FKCedula, int FKFacturaID)
        {
            /*INGRESA UNA FACTURA DADA a un Estudiante DADO*/
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Estudiantes_Facturas " +
            "VALUES (@Cedula, @IDFactura)"))
            {              
                cmd.Parameters.AddWithValue("@Cedula", FKCedula);
                cmd.Parameters.AddWithValue("@IDFactura", FKFacturaID);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public void IngresaCursosdeCliente(Int64 FKCedula, int FKidCurso)
        {
            /*INGRESA UN CURSO DADO a un Estudiante DADO*/
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Estudiantes_Cursos " +
            "VALUES (@Cedula, @IDCurso)"))
            {
                cmd.Parameters.AddWithValue("@Cedula", FKCedula);
                cmd.Parameters.AddWithValue("@IDCurso", FKidCurso);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public void EliminaFactura(int IDFactura) //Elimina factura de la tabla Facturas
        {  
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Facturas WHERE " +
                "PK_ID_Factura=@IDFactura"))
            {
                cmd.Parameters.AddWithValue("@IDFactura", IDFactura);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
            EliminaFacturadeCliente(IDFactura);
        }
        public void EliminaFacturadeCliente(int IDFactura) //Elimina factura de la tabla Cliente-Facturas
        {   
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Estudiantes_Facturas WHERE " +
                "FK_ID_Factura=@IDFactura"))
            {
                cmd.Parameters.AddWithValue("@IDFactura", IDFactura);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }       
    }
}

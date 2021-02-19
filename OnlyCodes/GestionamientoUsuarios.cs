using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberU.OnlyCodes
{
    public class GestionamientoUsuarios

        /*CLASE ESPECIFICAMENTE PARA CONSULTAS A LAS TABLAS ADMIN O ESTUDIANTE*/
    {
        public void ActualizarAdmin(int ID_ADMIN, DateTime FECHA_NACIMIENTO, String NOMBRE_ADMIN, String CORREO_ADMIN,String USERNAME_ADMIN, String PASSWORD_ADMIN)
        {
            /*ACTUALIZA DATOS DEL ADMINISTRADOR ACTUAL.*/
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("UPDATE Administradores SET " +
                "Fecha_Nacimiento=@FECHA_NACIMIENTO,  " +
                "Nombre_Admin=@NOMBRE_ADMIN," +
                "Nombre_Usuario_Admin=@USERNAME_ADMIN," +
                "Correo_Admin=@CORREO_ADMIN," +
                " Contra_Admin=@PASSWORD_ADMIN " +
                " WHERE PK_ID_Admin=@ID_ADMIN"))
            {
                cmd.Parameters.AddWithValue("@ID_ADMIN", ID_ADMIN);
                cmd.Parameters.Add("@FECHA_NACIMIENTO", SqlDbType.Date).Value = FECHA_NACIMIENTO.Date;
                cmd.Parameters.AddWithValue("@NOMBRE_ADMIN", NOMBRE_ADMIN);
                cmd.Parameters.AddWithValue("@USERNAME_ADMIN", USERNAME_ADMIN);
                cmd.Parameters.AddWithValue("@CORREO_ADMIN", CORREO_ADMIN);
                cmd.Parameters.AddWithValue("@PASSWORD_ADMIN", PASSWORD_ADMIN);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public void BorrarADMIN(String ID_ADMIN)
        {
            /*BORRA UN DADO ADMINISTRADOR*/
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Administradores WHERE " +
            "PK_ID_Admin=@ID_ADMIN"))
            {
                cmd.Parameters.AddWithValue("@ID_ADMIN", ID_ADMIN);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public void BorrarESTUDIANTE(String ID_ESTUDIANTE)
        {
            /*BORRA UN ESTUDIANTE DADO*/
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Estudiantes WHERE " +
            "PK_ID_Estudiante=@ID_ESTUDIANTE"))
            {
                cmd.Parameters.AddWithValue("@ID_ESTUDIANTE", ID_ESTUDIANTE);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public void IngresaESTUDIANTE(Int64 CEDULA_ESTUDIANTE, String NOMBRE_ESTUDIANTE, String APELLIDO_ESTUDIANTE,
          DateTime FECHA_NACIMIENTO, String CORREO_ESTUDIANTE, Int64 TELEFONO)
        {
            /*INGRESA UN ESTUDIANTE DADO*/
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Estudiantes " +
            " VALUES (@CEDULA_ESTUDIANTE,@NOMBRE_ESTUDIANTE,@APELLIDO_ESTUDIANTE,@FECHA_NACIMIENTO,@CORREO_ESTUDIANTE,@TELEFONO)"))
            {
                cmd.Parameters.AddWithValue("@CEDULA_ESTUDIANTE", CEDULA_ESTUDIANTE);
                cmd.Parameters.AddWithValue("@NOMBRE_ESTUDIANTE", NOMBRE_ESTUDIANTE);
                cmd.Parameters.AddWithValue("@APELLIDO_ESTUDIANTE", APELLIDO_ESTUDIANTE);
                cmd.Parameters.Add("@FECHA_NACIMIENTO", SqlDbType.Date).Value = FECHA_NACIMIENTO.Date;
                cmd.Parameters.AddWithValue("@CORREO_ESTUDIANTE", CORREO_ESTUDIANTE);
                cmd.Parameters.AddWithValue("@TELEFONO", TELEFONO);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public void IngresaADMIN(String NOMBRE_ADMIN,DateTime FECHA_NACIMIENTO, String CORREO_ADMIN, String USERNAME_ADMIN,
            String PASSWORD_ADMIN)
        {
            /*INGRESA UN ADMINISTRADOR DADO*/
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Administradores " +
            " VALUES (@FECHA_NACIMIENTO,@NOMBRE_ADMIN,@USERNAME_ADMIN,@CORREO_ADMIN,@CONTRA_ADMIN)"))
            {
                cmd.Parameters.Add("@FECHA_NACIMIENTO", SqlDbType.Date).Value = FECHA_NACIMIENTO.Date;
                cmd.Parameters.AddWithValue("@NOMBRE_ADMIN", NOMBRE_ADMIN);
                cmd.Parameters.AddWithValue("@USERNAME_ADMIN", USERNAME_ADMIN);
                cmd.Parameters.AddWithValue("@CORREO_ADMIN", CORREO_ADMIN);                
                cmd.Parameters.AddWithValue("@CONTRA_ADMIN", PASSWORD_ADMIN);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public void ActualizarESTUDIANTE(Int64 CEDULA_ESTUDIANTE, String NOMBRE_ESTUDIANTE, String APELLIDO_ESTUDIANTE,
          DateTime FECHA_NACIMIENTO, String CORREO_ESTUDIANTE, Int64 TELEFONO)
        {
            /*ACTUALIZA DATOS DEL ADMINISTRADOR ACTUAL.*/
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("UPDATE Estudiantes SET " +
            "PK_Cedula_Estudiante=@ID_ESTUDIANTE ," +
            "Nombre_Estudiante=@NOMBRE_ESTUDIANTE," +
            "Apellido_Estudiante=@APELLIDO_ESTUDIANTE," +
            "Fecha_Nacimiento=@FECHA_NACIMIENTO,  " +
            "Correo_Estudiante=@CORREO_ESTUDIANTE," +
            "Telefono_Estudiante=@TELEFONO_ESTUDIANTE," +
            "Nombre_Estudiante=@USERNAME_ESTUDIANTE" +
            "WHERE PK_Cedula_Estudiante=@ID_ESTUDIANTE"))
            {
                cmd.Parameters.AddWithValue("@ID_ESTUDIANTE", CEDULA_ESTUDIANTE);
                cmd.Parameters.Add("@FECHA_NACIMIENTO", SqlDbType.Date).Value = FECHA_NACIMIENTO.Date;
                cmd.Parameters.AddWithValue("@NOMBRE_ESTUDIANTE", NOMBRE_ESTUDIANTE);
                cmd.Parameters.AddWithValue("@APELLIDO_ESTUDIANTE", APELLIDO_ESTUDIANTE);
                cmd.Parameters.AddWithValue("@CORREO_ESTUDIANTE", CORREO_ESTUDIANTE);
                cmd.Parameters.AddWithValue("@TELEFONO_ESTUDIANTE", TELEFONO);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }
    }
}

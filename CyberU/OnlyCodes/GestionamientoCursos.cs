using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberU.OnlyCodes
{
    public class GestionamientoCursos
    {
        /*CLASE ESPECIFICAMENTE PARA CONSULTAS A LAS TABLAS Curso y Horarios Curso*/

        public void IngresaCURSO(String NOMBRE_CURSO, float PRECIO_CURSO, DateTime FECHA_INICIO, DateTime FECHA_FIN, int HorarioID)
        {
            /*INGRESA UN CURSO DADO*/
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Cursos " +
                "VALUES (@NOMBRE,@PRECIO,@FECHA_INICIO,@FECHA_FIN,@FK_HORARIO_ID)"))
            {
                cmd.Parameters.AddWithValue("@NOMBRE", NOMBRE_CURSO);
                cmd.Parameters.AddWithValue("@PRECIO", PRECIO_CURSO);
                cmd.Parameters.Add("@FECHA_INICIO", SqlDbType.Date).Value = FECHA_INICIO.Date;
                cmd.Parameters.Add("@FECHA_FIN", SqlDbType.Date).Value = FECHA_FIN.Date;
                cmd.Parameters.AddWithValue("@FK_HORARIO_ID", HorarioID);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public void ActualizarCurso(int ID_CURSO, String NOMBRE_CURSO, float PRECIO_CURSO, DateTime FECHA_INICIO, DateTime FECHA_FIN, int HorarioID)
        {
            /*ACTUALIZA DATOS DEL CURSO ACTUAL.*/
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("UPDATE Cursos SET " +
                "Nombre_Curso=@NOMBRE_CURSO,  " +
                "Precio_Curso=@PRECIO_CURSO," +
                "Inicio_Curso=@INICIO_CURSO," +
                "Final_Curso=@FIN_CURSO," +
                "FK_ID_Horario=@HORARIO_CURSO" +
                " WHERE PK_ID_Curso=@ID_CURSO"))
            {
                cmd.Parameters.AddWithValue("@ID_CURSO", ID_CURSO);
                cmd.Parameters.AddWithValue("@NOMBRE_CURSO", NOMBRE_CURSO);
                cmd.Parameters.AddWithValue("@PRECIO_CURSO", PRECIO_CURSO);
                cmd.Parameters.Add("@INICIO_CURSO", SqlDbType.Date).Value = FECHA_INICIO.Date;
                cmd.Parameters.Add("@FIN_CURSO", SqlDbType.Date).Value = FECHA_FIN.Date;
                cmd.Parameters.AddWithValue("@HORARIO_CURSO", HorarioID);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }
        public void BorrarCURSO(int ID_CURSO)
        {
            /*BORRA UN DADO CURSO*/
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Cursos WHERE " +
                "PK_ID_Curso=@ID_CURSO"))
            {
                cmd.Parameters.AddWithValue("@ID_CURSO", ID_CURSO);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }

        public void BorrarCursodeEstudiantes(int ID_CURSO)
        {
            /*BORRA UN DADO CURSO*/
            SqlConnection conx = new SqlConnection();
            conx = ValidacionDatos.RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Estudiantes_Cursos WHERE " +
                "FK_ID_Curso=@ID_CURSO"))
            {
                cmd.Parameters.AddWithValue("@ID_CURSO", ID_CURSO);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }
    }
}

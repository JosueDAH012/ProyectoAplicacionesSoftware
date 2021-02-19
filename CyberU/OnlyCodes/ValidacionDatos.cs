using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberU.Administrador;

namespace CyberU.OnlyCodes
{
    public class ValidacionDatos
    {
        public static DataSet GetData()
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Administradores", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static SqlConnection RetornaAcceso()
        {
            SqlConnection conecta = new SqlConnection();
            conecta.ConnectionString = RetornaDataConfig();
            return conecta;
        }
        public static Boolean AdminClaveValida(String UsuarioAdmin, String ContraAdmin) //Clave Valida para Administrador
        {
            String Resultado = "";
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(Nombre_Usuario_Admin) as DATA FROM Administradores WHERE Nombre_Usuario_Admin='"
            + UsuarioAdmin + "' AND Contra_Admin='" + ContraAdmin + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            ds.Dispose();
            if (Resultado == "1")
            {
                Frm_MenuPrincipal.idusuario = getCodigo(UsuarioAdmin, ContraAdmin);
                return true;
            }
            else return false;
        }

        public static Boolean ExisteCodigoEstudiante(int codigo)
        {
            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(PK_Cedula_Estudiante) as DATA FROM Estudiantes WHERE PK_Cedula_Estudiante="
            + codigo, conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            ds.Dispose();
            if (Resultado == "1") return true;
            else return false;
        }

        public static Boolean ExisteCodigoAdmin(int codigo)
        {
            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(PK_ID_Admin) as DATA FROM Administradores WHERE PK_ID_Admin="
            + codigo, conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            ds.Dispose();
            if (Resultado == "1") return true;
            else return false;
        }

        public static Boolean ExisteCodigoCurso(int codigo)
        {
            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(PK_ID_Curso) as DATA FROM Cursos WHERE PK_ID_Curso="
            + codigo, conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            ds.Dispose();
            if (Resultado == "1") return true;
            else return false;
        }

        public static Boolean ExisteCodigo(int codigo)
        {
            String Resultado;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(PK_Cedula_Estudiante) as DATA FROM Estudiantes WHERE PK_Cedula_Estudiante="
            + codigo, conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            ds.Dispose();
            if (Resultado == "1") return true;
            else return false;
        }

        public static Boolean EstudianteClaveValida(String UsuarioEstudiante, String ContraEstudiante) //Clave Valida para el Estudiante
        {
            String Resultado = "";
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(Nombre_Usuario_Estudiante) as DATA FROM Estudiantes WHERE Nombre_Usuario_Estudiante='"
            + UsuarioEstudiante + "' AND Contra_Estudiante='" + ContraEstudiante + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            ds.Dispose();
            if (Resultado == "1")
                return true;
            else return false;
        }

        public static int getCodigo(String UsuarioAdmin, String ContraAdmin)
        {
            int codigo;
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("SELECT PK_ID_Admin as DATA FROM Administradores WHERE Nombre_Usuario_Admin='"
            + UsuarioAdmin + "' AND Contra_Admin='" + ContraAdmin + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            codigo = int.Parse(ds.Tables[0].Rows[0]["DATA"].ToString());
            ds.Dispose();
            return codigo;

        }

        public static String RetornaDataConfig()
        {
            String Server = "";
            String Catalog = "";
            String Security = "";
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"CyberUDB.CONFIG");
            Server = file.ReadLine();
            Catalog = file.ReadLine();
            Security = file.ReadLine();
            return "Data Source=" + Server + "; Initial Catalog='" +
            Catalog + "';  " + Security + " ;";
        }
    }
}

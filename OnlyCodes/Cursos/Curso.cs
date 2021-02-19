using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberU.Cursos
{
    public class Curso
    {
        private int id { get; set; }
        public string nombre { get; set; }
        public float Precio { get; }
        DateTime Inicio_Curso { get; set; }
        DateTime Fin_Curso { get; set; }
        public Curso(int _id, string _nombre, float _Precio, DateTime _inicio, DateTime _fin)
        {
            this.id = _id;
            this.nombre = _nombre;
            this.Precio = _Precio;
            this.Inicio_Curso = _inicio;
            this.Fin_Curso = _fin;
        }
    }
}

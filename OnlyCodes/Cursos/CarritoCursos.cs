using CyberU.Cursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberU.OnlyCodes
{
    public class CarritoCursos
    {
        public List<Curso> listacursos { get; set; } 
        public CarritoCursos()
        {
            this.listacursos = new List<Curso>();
        }

        public float precioTotal(List<Curso> cursos)
        {
            /*Obtiene el precio total del carrito de cursos*/
            float preciototal = 0;
            cursos.ForEach(curso => preciototal += curso.Precio);
            return preciototal;          
        }
    }
}

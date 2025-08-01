using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DocenteCursoInMemory 
    {
        public static List<DocenteCurso> DocenteCursos;

        static DocenteCursoInMemory()
        {
            DocenteCursos = new List<DocenteCurso>
            {
                new DocenteCurso(0, "Profesor Titular", 1, 1),   
                new DocenteCurso(1, "Profesor Asociado", 2, 2),
                new DocenteCurso(2, "Profesor Asistente", 3, 3),
                new DocenteCurso(3, "Profesor Invitado", 4, 4),
                new DocenteCurso(4, "Profesor Titular", 5, 5),
                new DocenteCurso(5, "Profesor Asociado", 6, 6),
                new DocenteCurso(6, "Profesor Asistente", 7, 7),
                new DocenteCurso(7, "Profesor Invitado", 8, 8),

            };
        }
    }
}

using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Service
{
    public class AlumnoInscripcionService
    {
        public void Add(Alumno_Inscripcion insc)
        {
            AlumnoInscInMemory.Inscripciones.Add(insc);
        }

        public bool Delete(int id)
        {
            Alumno_Inscripcion? inscToDelete = AlumnoInscInMemory.Inscripciones.Find(x => x.Id == id);
            if (inscToDelete != null)
            {
                AlumnoInscInMemory.Inscripciones.Remove(inscToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Alumno_Inscripcion Get(int id)
        {
            return AlumnoInscInMemory.Inscripciones.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Alumno_Inscripcion> GetAll()
        {
            return AlumnoInscInMemory.Inscripciones.ToList();
        }

        public bool Update(Alumno_Inscripcion insc)
        {
            var inscToUpdate = AlumnoInscInMemory.Inscripciones.FirstOrDefault(x => x.Id == insc.Id);
            if (inscToUpdate != null)
            {
                inscToUpdate.SetIdAlumno(insc.IdAlumno);
                inscToUpdate.SetIdCurso(insc.IdCurso);
                inscToUpdate.SetNota(insc.Nota);
                inscToUpdate.SetCondicion(insc.Condicion);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
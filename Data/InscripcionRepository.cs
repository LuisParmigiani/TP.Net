using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;    

namespace Data
{
    public class InscripcionRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Inscripcion insc)
        {
            using var context = CreateContext();
            if (context.Personas.Any(alu => alu.Id == insc.IdAlumno && alu.TipoPersona == 2) != true)
            {
                throw new Exception("No se encontró un Alumno con el ID ingresado");
            }
            if (context.Cursos.Any(c => c.Id == insc.IdCurso) != true)
            {
                throw new Exception("No se encontró un curso con el ID ingresado");
            }
            context.Inscripciones.Add(insc);
            context.SaveChanges();
        }
        
        public bool Delete(int id)
        {
            using var context = CreateContext();
            var insc = context.Inscripciones.Find(id);
            if (insc != null)
            {
                context.Inscripciones.Remove(insc);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public Inscripcion? Get(int id)
        {
            using var context = CreateContext();
            var insc = context.Inscripciones.Find(id);
            return insc;
        }
        public IEnumerable<Inscripcion> GetAll()
        {
            using var context = CreateContext();
            return context.Inscripciones.ToList();
        }
        public bool Update(Inscripcion insc)
        {
            using var context = CreateContext();
            var inscExists = context.Inscripciones.Find(insc.Id);
            if (inscExists != null)
            {
                try
                {
                    inscExists.SetCondicion(insc.Condicion);
                    inscExists.SetNota(insc.Nota);
                    if (context.Personas.Any(alu => alu.Id == insc.IdAlumno && alu.TipoPersona == 2) != true)
                    {
                        throw new Exception("No se encontró un Alumno con el ID ingresado");
                    }
                    inscExists.SetIdAlumno(insc.IdAlumno);
                    if (context.Cursos.Any(c => c.Id == insc.IdCurso) != true)
                    {
                        throw new Exception("No se encontró un curso con el ID ingresado");
                    }
                    inscExists.SetIdCurso(insc.IdCurso);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return false;
        }
        //Puede que en un futuro tengamos más 
    }
}
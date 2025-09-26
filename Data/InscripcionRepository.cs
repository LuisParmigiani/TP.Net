using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using DTOs;

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

        public IEnumerable<EstadoAcedemico> GetEstadoAcademicoOfAlumno(int idAlumno)
        {
            using var context = CreateContext();
            var alumnExists = context.Personas.Any(a => a.Id == idAlumno && a.TipoPersona == 2);
            if (alumnExists)
            {
                try
                {
                    var listado = (from insc in context.Inscripciones
                        join curso in context.Cursos
                            on insc.IdCurso equals curso.Id
                        join materia in context.Materias
                            on curso.IdMateria equals materia.Id
                        join comision in context.Comisiones
                            on curso.IdComision equals comision.Id
                        select new EstadoAcedemico
                        {
                            Id_Inscripcion = insc.Id,
                            Id_Alumno = insc.IdAlumno,
                            Condicion = insc.Condicion,
                            Nota = insc.Nota,
                            Id_Curso = curso.Id,
                            AnioCalendario = curso.AnioCalendario,
                            Id_Comision = comision.Id,
                            Descripcion_Comision = comision.Descripcion,
                            Id_Materia = materia.Id,
                            Descripcion_Materia = materia.Descripcion
                        }).ToList();
                    return listado;


                }
                catch (Exception e)
                {
                    throw new Exception($"Hubo un error: {e.Message}");
                }
            }
            else
            {
                throw new Exception($"No se encontró un Alumno con el ID ingresado");
            }
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

    }
}
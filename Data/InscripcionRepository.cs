using System;
using System.Collections.Generic;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Linq;
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
            Curso cur = context.Cursos.Find(insc.IdCurso);
            int cantInscripciones = context.Inscripciones.Where(i => i.IdCurso == insc.IdCurso).ToList().Count();
            if (cantInscripciones == cur.Cupo)
            {
                throw new Exception("No hay más cupos para el curso al que se trata de ingresar");
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

        public IEnumerable<EstadoAcademico> GetEstadoAcademicoOfAlumno(int idAlumno)
        {
            using var context = CreateContext();
            var alumnExists = context.Personas.Any(a => a.Id == idAlumno && a.TipoPersona == 2);
            if (alumnExists)
            {
                try
                {   
                    var listado = context.Database
                        .SqlQuery<EstadoAcademico>($@"
                WITH mat_cursadas AS (
                    SELECT 
                        per.nombre AS nombre,
                        per.apellido AS apellido,
                        mat.Id AS Id_mat_cursada, 
                        mat.descripcion AS materia, 
                        insc.condicion AS condicion, 
                        insc.Nota AS nota,
                        cur.AnioCalendario, 
                        com.id AS comId, 
                        com.descripcion AS comDesc, 
                        com.AnioEspecialidad AS AnioEsp,
                        per.IdPlan 
                    FROM Inscripciones insc
                    INNER JOIN cursos cur ON insc.IdCurso = cur.Id 
                    INNER JOIN Comisiones com ON cur.IdComision = com.Id
                    INNER JOIN Materias mat ON cur.IdMateria = mat.Id
                    INNER JOIN Personas per ON per.Id = insc.IdAlumno
                    WHERE per.Id = {idAlumno}
                ) 
                SELECT 
                    mat.Id as IdMateria,
                    mat.Descripcion as DescMateria,
                    mat_cursadas.condicion AS Condicion,
                    mat_cursadas.nota AS Nota,
                    mat_cursadas.AnioCalendario as AnioCalendarioCursado,

                    mat_cursadas.comId as IdComCursada, 
                    mat_cursadas.comDesc as DescComisionCursada, 
                    mat_cursadas.AnioEsp as AnioEspecialidadCursada
                FROM Materias mat
                LEFT JOIN mat_cursadas ON mat.Id = mat_cursadas.Id_mat_cursada")
                        .ToList();
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
        //Puede que en un futuro tengamos más 
    }
}
using System;
using System.Collections.Generic;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Linq;

namespace Data
{
    public class CursoRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Curso cur)
        {
            using var context = CreateContext();
            if (context.Comisiones.Any(c => c.Id == cur.IdComision) != true)
            {
                throw new Exception("No se encontró la comisión con el ID ingresado");
            }
            if (context.Materias.Any(m => m.Id == cur.IdMateria) != true)
            {
                throw new Exception("No se encontró la materia con el ID ingresado");
            }
            context.Cursos.Add(cur);
            context.SaveChanges();
        }
        
        public bool Delete(int id)
        {
            using var context = CreateContext();
            var cur = context.Cursos.Find(id);
            if (cur != null)
            {
                context.Cursos.Remove(cur);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public Curso? Get(int id)
        {
            using var context = CreateContext();
            var cur = context.Cursos.Find(id);
            return cur;
        }
        public IEnumerable<Curso> GetAll()
        {
            using var context = CreateContext();
            return context.Cursos.ToList();
        }
        public bool Update(Curso curso)
        {
            using var context = CreateContext();
            var curExists = context.Cursos.Find(curso.Id);
            if (curExists != null)
            {
                try
                {
                    curExists.SetId(curso.Id);
                    curExists.SetAnioCalendario(curso.AnioCalendario);
                    curExists.SetCupo(curso.Cupo);
                    curExists.SetDescripcion(curso.Descripcion);
                    if (context.Comisiones.Any(c => c.Id == curso.IdComision) != true)
                    {
                        throw new Exception("No se encontró la comisión con el ID ingresado");
                    }
                    curExists.SetIdComision(curso.IdComision);
                    if (context.Materias.Any(m => m.Id == curso.IdMateria) != true)
                    {
                        throw new Exception("No se encontró la materia con el ID ingresado");
                    }
                    curExists.SetIdMateria(curso.IdMateria);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Uno de los argumentos ingresados no es correcto: {ex.Message}");
                }
            }

            return false;
        }
        //Puede que en un futuro tengamos más 
        public IEnumerable<Curso> GetCursosByProfId(int idProfesor)
        {
            using var context = CreateContext();
            try
            {
                var docExists = context.Dictados.Any(d => d.IDDocente == idProfesor);
                if (!docExists) {
                    throw new ArgumentException("El docente ingresado no esta dictando ningún curso");
                }

                int yearNow = DateTime.Now.Year;
                var cursos = context.Cursos
                    .Join(
                        context.Dictados,
                        curso => curso.Id,
                        dictado => dictado.IDCurso,
                        (curso, dictado) => curso)
                    .Where(c => context.Dictados
                        .Any(d => d.IDCurso == c.Id && d.IDDocente == idProfesor && c.AnioCalendario == yearNow))
                    .ToList();
                return cursos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Hubo un error: {ex.Message}");
            }
        }
    }
}
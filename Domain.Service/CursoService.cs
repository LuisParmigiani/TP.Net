
using Data;
using Domain.Model;
namespace Domain.Service

{


    public class CursoService
    {
        public void Add(Curso curso)
        {
            CursoInMemory.Cursos.Add(curso);
        }

        public bool Delete(int id)
        {
            Curso? cursoToDelete = CursoInMemory.Cursos.Find(c => c.Id == id);
            if (cursoToDelete != null)
            {
                CursoInMemory.Cursos.Remove(cursoToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Curso Get(int id)
        {
            Curso cur = CursoInMemory.Cursos.Find(c => c.Id == id);
            if (cur != null)
            {
                return cur;
            }
            else
            {
                return null;
            }

        }

        public IEnumerable<Curso> GetAll()
        {
            return CursoInMemory.Cursos.ToList();
        }

        public IEnumerable<Curso> GetCursosPorDescripcion(string descripcion)
        {
            return CursoInMemory.Cursos.Where(c => c.Descripcion.Contains(descripcion));
        }

        public bool Update(Curso curso)
        {
            Curso? cursoToUpdate = CursoInMemory.Cursos.Find(c => c.Id == curso.Id);

            if (cursoToUpdate != null)
            {
                cursoToUpdate.SetAnioCalendario(curso.AnioCalendario);
                cursoToUpdate.SetCupo(curso.Cupo);
                cursoToUpdate.SetDescripcion(curso.Descripcion);
                cursoToUpdate.SetIdComision(curso.IdComision);
                cursoToUpdate.SetIdMateria(curso.IdMateria);

                return true;
            }
            else
            {
                return false;
            }
        }

        private static int GetNextId()
        {
            int nextId;

            if (CursoInMemory.Cursos.Count > 0)
            {
                nextId = CursoInMemory.Cursos.Max(x => x.Id) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }



    }
}
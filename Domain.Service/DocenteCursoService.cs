using Data;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class DocenteCursoService
    {
        public void Add(DocenteCurso docenteCurso)
        {
            DocenteCursoInMemory.DocenteCursos.Add(docenteCurso);
        }

        public bool Delete(int id)
        {
            DocenteCurso? docenteCursoToDelete = DocenteCursoInMemory.DocenteCursos.Find(x => x.Id == id);
            if (docenteCursoToDelete != null)
            {
                DocenteCursoInMemory.DocenteCursos.Remove(docenteCursoToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public DocenteCurso Get(int id)
        {
            return DocenteCursoInMemory.DocenteCursos.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<DocenteCurso> GetAll()
        {
            return DocenteCursoInMemory.DocenteCursos.ToList();
        }

        public bool Update(DocenteCurso docenteCurso)
        {
            var docenteCursoToUpdate = DocenteCursoInMemory.DocenteCursos.FirstOrDefault(x => x.Id == docenteCurso.Id);
            if (docenteCursoToUpdate != null)
            {
                docenteCursoToUpdate.SetCargo(docenteCurso.Cargo);
                docenteCursoToUpdate.SetIDCurso(docenteCurso.IDCurso);
                docenteCursoToUpdate.SetIDDocente(docenteCurso.IDDocente);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

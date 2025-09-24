using Domain.Model;
using Data;
using DTOs;

namespace Domain.Service
{
    
    public class CursoService
    {

        public CursoDTO Add(CursoDTO cur)
        {
            var curRepo = new CursoRepository();
            Curso curso = new Curso(cur.AnioCalendario, cur.Cupo, cur.Descripcion, cur.IdComision, cur.IdMateria, 0);
            try
            {
                curRepo.Add(curso);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            cur.Id = curso.Id;

            return cur;
        }


        public bool Delete(int id)
        {
            var curRepo = new CursoRepository();
            return curRepo.Delete(id);
        }

        public CursoDTO Get(int id)
        {
            var curRepo = new CursoRepository();
            Curso? curso = curRepo.Get(id);
            if (curso == null)
                return null;
            return new CursoDTO(
                curso.Id,
                curso.AnioCalendario,
                curso.Cupo,
                curso.Descripcion,
                curso.IdComision,
                curso.IdMateria
            );
        }

        public IEnumerable<CursoDTO> GetAll()
        {
            var curRepo = new CursoRepository();
            return curRepo.GetAll().Select(curso => new CursoDTO(
                curso.Id,
                curso.AnioCalendario,
                curso.Cupo,
                curso.Descripcion,
                curso.IdComision,
                curso.IdMateria
            )).ToList();
        }

        public bool Update(CursoDTO cur)
        {
            var curRepo = new CursoRepository();
            try{
            
                Curso curso = new Curso(cur.AnioCalendario, cur.Cupo, cur.Descripcion, cur.IdComision, cur.IdMateria, 0);
                return curRepo.Update(curso);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
};
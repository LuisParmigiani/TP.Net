using Domain.Model;
using Data;
using DTOs;

namespace Domain.Service
{
    
    public class InscripcionService
    {

        public InscripcionDTO Add(InscripcionDTO insc)
        {
            var inscRepo = new InscripcionRepository();
            Inscripcion inscripcion = new Inscripcion(0,insc.IdAlumno,insc.IdCurso,insc.Nota,insc.Condicion);
            try
            {
                inscRepo.Add(inscripcion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            insc.Id = inscripcion.Id;

            return insc;
        }


        public bool Delete(int id)
        {
            var inscRepo = new InscripcionRepository();
            return inscRepo.Delete(id);
        }

        public InscripcionDTO Get(int id)
        {
            var inscRepo = new InscripcionRepository();
            Inscripcion? insc = inscRepo.Get(id);
            if (insc == null)
                return null;
            return new InscripcionDTO(
                insc.Id,
                insc.IdAlumno,
                insc.IdCurso,
                insc.Nota,
                insc.Condicion
            );
        }

        public IEnumerable<InscripcionDTO> GetAll()
        {
            var inscRepo = new InscripcionRepository();
            return inscRepo.GetAll().Select(insc => new InscripcionDTO(
                insc.Id,
                insc.IdAlumno,
                insc.IdCurso,
                insc.Nota,
                insc.Condicion
            )).ToList();
        }

        public bool Update(InscripcionDTO insc)
        {
            var inscRepo = new InscripcionRepository();
            try{
                Inscripcion inscripcion = new Inscripcion(0,insc.IdAlumno,insc.IdCurso,insc.Nota,insc.Condicion);
                return inscRepo.Update(inscripcion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
};
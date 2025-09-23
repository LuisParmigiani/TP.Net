using Domain.Model;
using Data;
using DTOs;

namespace Domain.Service
{
    public class EspecialidadService
    {

        public EspecialidadDTO Add(EspecialidadDTO esp)
        {
            EspecialidadRepository espRepo = new EspecialidadRepository();
            Especialidad especialidad = new Especialidad(0, esp.Descripcion);
            espRepo.Add(especialidad);
            especialidad.Id = esp.Id;
            return esp;
        }


        public bool Delete(int id)
        {
            EspecialidadRepository espRepo = new EspecialidadRepository();
            return espRepo.Delete(id);
        }

        public EspecialidadDTO Get(int id)
        {
            EspecialidadRepository espRepo = new EspecialidadRepository();
            Especialidad? especialidad = espRepo.Get(id);
            if (especialidad == null)
                return null;
            return new EspecialidadDTO(especialidad.Id,especialidad.Descripcion);
        }

        public IEnumerable<EspecialidadDTO> GetAll()
        {
            var espRepo = new EspecialidadRepository();
            return espRepo.GetAll().Select(e => new EspecialidadDTO(e.Id, e.Descripcion)).ToList();
        }

        public bool Update(Especialidad esp)
        {
            var espRepo = new EspecialidadRepository();
            Especialidad especiali = new Especialidad(esp.Id,esp.Descripcion);
            return espRepo.Update(especiali);
            
        }
    }

 
}
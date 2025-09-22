using Domain.Model;
using Data;

namespace Domain.Service
{
    public class EspecialidadService
    {

        public void Add(Especialidad esp)
        {
            EspInMemory.Especialidades.Add(esp);
        }


        public bool Delete(int id)
        {
            Especialidad? espToDelete = EspInMemory.Especialidades.Find(x => x.Id == id);
            if (espToDelete != null)
            {
                EspInMemory.Especialidades.Remove(espToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Especialidad Get(int id)
        {
            return EspInMemory.Especialidades.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Especialidad> GetAll()
        {
            return EspInMemory.Especialidades.ToList();
        }

        public bool Update(Especialidad esp)
        {
            var espToUpdate = EspInMemory.Especialidades.FirstOrDefault(x => x.Id == esp.Id);
            if (espToUpdate != null)
            {
                espToUpdate.SetDescripcion(esp.Descripcion);
            
                return true;
            }
            else
            {
                return false;
            }
        }
    }

 
}
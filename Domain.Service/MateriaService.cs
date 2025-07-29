using Domain.Model;
using Data;

namespace Domain.Service {
    public class MateriasService
    {
        public void Add(Materia materia)
        {
            MateriaInMemory.Materias.Add(materia);
        }


        public bool Delete(int id)
        {
            Materia? materiaToDelete = MateriaInMemory.Materias.Find(x => x.Id == id);
            if (materiaToDelete != null)
            {
                MateriaInMemory.Materias.Remove(materiaToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Materia Get(int id)
        {
            return MateriaInMemory.Materias.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Materia> GetAll()
        {
            return MateriaInMemory.Materias.ToList();
        }

        public bool Update(Materia materia)
        {
            var materiaToUpdate = MateriaInMemory.Materias.FirstOrDefault(x => x.Id == materia.Id);
            if (materiaToUpdate != null)
            {
                materiaToUpdate.SetDescripcion(materia.Descripcion);
                materiaToUpdate.SetHSSemanales(materia.HSSemanales);
                materiaToUpdate.SetHSTotales(materia.HSTotales);
                materiaToUpdate.SetIDPlan(materia.IDPlan);
                return true;
            }
            else
            {
                return false;
            }
        }
    } }
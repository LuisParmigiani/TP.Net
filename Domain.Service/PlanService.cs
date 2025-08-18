using Domain.Model;
using Data;

namespace Domain.Service
{
    public class PlanService
    {

        public void Add(Plan plan)
        {
            PlanInMemory.Planes.Add(plan);
        }


        public bool Delete(int id)
        {
            Plan? planToDelete = PlanInMemory.Planes.Find(x => x.Id == id);
            if (planToDelete != null)
            {
                PlanInMemory.Planes.Remove(planToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Plan Get(int id)
        {
            return PlanInMemory.Planes.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Plan> GetAll()
        {
            return PlanInMemory.Planes.ToList();
        }

        public bool Update(Plan plan)
        {
            var planToUpdate = PlanInMemory.Planes.FirstOrDefault(x => x.Id == plan.Id);
            if (planToUpdate != null)
            {
                planToUpdate.SetDescripcion(plan.Descripcion);
                planToUpdate.SetIdEspecialidad(plan.IdEspecialidad);
            
                return true;
            }
            else
            {
                return false;
            }
        }
    }

 
}

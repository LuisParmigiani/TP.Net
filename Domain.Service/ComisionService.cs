using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Service
{
    public class ComisionService
    {
        public void Add(Comision comision)
        {
            ComisionInMemory.Comisiones.Add(comision);
        }

        public bool Delete(int id)
        {
            Comision? comisionToDelete = ComisionInMemory.Comisiones.Find(x => x.Id == id);
            if (comisionToDelete != null)
            {
                ComisionInMemory.Comisiones.Remove(comisionToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Comision Get(int id)
        {
            return ComisionInMemory.Comisiones.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Comision> GetAll()
        {
            return ComisionInMemory.Comisiones.ToList();
        }

        public bool Update(Comision comision)
        {
            var comisionToUpdate = ComisionInMemory.Comisiones.FirstOrDefault(x => x.Id == comision.Id);
            if (comisionToUpdate != null)
            {
                comisionToUpdate.SetDescripcion(comision.Descripcion);
                comisionToUpdate.SetAnioEspecialidad(comision.AnioEspecialidad);
                comisionToUpdate.SetIDPlan(comision.IDPlan);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}





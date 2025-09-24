using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Data
{
    public class ComisionRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Comision com)
        {
            using var context = CreateContext();
            if (context.Planes.Any(p => p.Id == com.IDPlan) != true)
            {
                throw new Exception("No se encontró un plan con el ID ingresado");
            }

            context.Comisiones.Add(com);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var com = context.Comisiones.Find(id);
            if (com != null)
            {
                context.Comisiones.Remove(com);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        public Comision? Get(int id)
        {
            using var context = CreateContext();
            var com = context.Comisiones.Find(id);
            return com;
        }

        public IEnumerable<Comision> GetAll()
        {
            using var context = CreateContext();
            return context.Comisiones.ToList();
        }

        public bool Update(Comision comision)
        {
            using var context = CreateContext();
            var comExists = context.Comisiones.Find(comision.Id);
            if (comExists != null)
            {
                try
                {
                    comExists.SetDescripcion(comision.Descripcion);
                    comExists.SetAnioEspecialidad(comision.AnioEspecialidad);
                    if (context.Planes.Any(p => p.Id == comision.IDPlan) == true)
                    {
                        comExists.SetIDPlan(comision.IDPlan);
                    }
                    else
                    {
                        throw new Exception("No se encontró un plan con ese ID");
                    }

                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return false;
        }
        //Puede que en un futuro tengamos más 

    }
}
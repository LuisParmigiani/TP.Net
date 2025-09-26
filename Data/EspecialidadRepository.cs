using System.Collections.Generic;
using System.Linq;
using Domain.Model;

namespace Data;
public class EspecialidadRepository
{
    private TPIContext CreateContext()
    {
        return new TPIContext();
    }

    public void Add(Especialidad esp)
    {
        using var context = CreateContext();
        context.Especialidades.Add(esp);
        context.SaveChanges();
    }

    public bool Delete(int id)
    {
        using var context = CreateContext();
        var esp = context.Especialidades.Find(id);
        if (esp != null)
        {
            context.Especialidades.Remove(esp);
            context.SaveChanges();
            return true;
        }
        return false;
    }

    public Especialidad? Get(int id)
    {
        using var context = CreateContext();
        var esp = context.Especialidades.Find(id);
        return esp;
    }

    public IEnumerable<Especialidad> GetAll()
    {
        using var context = CreateContext();
        return context.Especialidades.ToList();
    }

    public bool Update(Especialidad esp)
    {
        using var context = CreateContext();
        var espExistente = context.Especialidades.Find(esp.Id);
        if (espExistente != null)
        {
            //El id no se toca
            espExistente.SetDescripcion(esp.Descripcion);
            context.SaveChanges();
            return true;
        }

        return false;
    }
   //Aca se van a seguir agregando todos los métodos que creamos necesarios
   

}

using Domain.Model;


namespace Data;
public class PlanRepository
{
    private TPIContext CreateContext()
    {
        return new TPIContext();
    }

    public void Add(Plan p)
    {
        using var context = CreateContext();
        //Checkeamos si existe la especialidad con el Id que me pasan 
        var espExists =context.Especialidades.Any(e => e.Id == p.IdEspecialidad);
        if (!espExists)
        {
            throw new InvalidOperationException($"No existe una especialidad con el id: {p.IdEspecialidad}");
        }
        context.Planes.Add(p);
        context.SaveChanges();
        
    }

    public bool Delete(int id)
    {
        using var context = CreateContext();
        var p = context.Planes.Find(id);
        if (p != null)
        {
            context.Planes.Remove(p);
            context.SaveChanges();
            return true;
        }
        return false;
    }

    public Plan? Get(int id)
    {
        using var context = CreateContext();
        var p = context.Planes.Find(id);
        return p;
    }

    public IEnumerable<Plan> GetAll()
    {
        using var context = CreateContext();
        return context.Planes.ToList();
    }

    public bool Update(Plan p)
    {
        using var context = CreateContext();
        var pExistente = context.Planes.Find(p.Id);
        if (pExistente != null)
        {
            //El id no se toca
            pExistente.SetDescripcion(p.Descripcion);
            pExistente.SetIdEspecialidad(p.IdEspecialidad);
            context.SaveChanges();
            return true;
        }

        return false;
    }
    //Aca se van a seguir agregando todos los métodos que creamos necesarios
   

}
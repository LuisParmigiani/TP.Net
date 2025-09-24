using Domain.Model;


namespace Data;
public class MateriaRepository
{
    private TPIContext CreateContext()
    {
        return new TPIContext();
    }

    public void Add(Materia mat)
    {
        using var context = CreateContext();
        //Checkeamos si existe la especialidad con el Id que me pasan 
        var planExists =context.Planes.Any(p => p.Id == mat.IDPlan);
        if (!planExists)
        {
            throw new InvalidOperationException($"No existe un plan con el id: {mat.IDPlan}");
        }
        context.Materias.Add(mat);
        context.SaveChanges();
    }

    public bool Delete(int id)
    {
        using var context = CreateContext();
        var m = context.Materias.Find(id);
        if (m != null)
        {
            context.Materias.Remove(m);
            context.SaveChanges();
            return true;
        }
        return false;
    }

    public Materia? Get(int id)
    {
        using var context = CreateContext();
        var m = context.Materias.Find(id);
        return m;
    }

    public IEnumerable<Materia> GetAll()
    {
        using var context = CreateContext();
        return context.Materias.ToList();
    }

    public bool Update(Materia m)
    {
        using var context = CreateContext();
        var mExistente = context.Materias.Find(m.Id);
        if (mExistente != null)
        {
            //El id no se toca
            mExistente.SetDescripcion(m.Descripcion);
            mExistente.SetIDPlan(m.IDPlan);
            context.SaveChanges();
            return true;
        }

        return false;
    }
    //Aca se van a seguir agregando todos los métodos que creamos necesarios
   

}
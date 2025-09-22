namespace Data;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;    

public class ModuloRepository
{
    private TPIContext CreateContext()
    {
        return new TPIContext();
    }

    public void Add(Modulo modulo)
    {
        using var context = CreateContext();
        context.Modulos.Add(modulo);
        context.SaveChanges();
    }

    public bool Delete(int id)
    {
        using var context = CreateContext();
        var modulo = context.Modulos.Find(id);
        if (modulo != null)
        {
            context.Modulos.Remove(modulo);
            context.SaveChanges();
            return true;
        }
        return false;
    }

    public Modulo? Get(int id)
    {
        using var context = CreateContext();
        var modulo = context.Modulos.Find(id);
        return modulo;
    }

    public IEnumerable<Modulo> GetAll()
    {
        using var context = CreateContext();
        return context.Modulos.ToList();
    }

    public bool Update(Modulo modulo)
    {
        using var context = CreateContext();
        var moduloExistente = context.Modulos.Find(modulo.Id);
        if (moduloExistente != null)
        {
            moduloExistente.SetDescripcion(modulo.Descripcion);
            moduloExistente.SetEjecuta(modulo.Ejecuta);

            context.SaveChanges();
            return true;
        }

        return false;
    }
   //Aca se van a seguir agregando todos los métodos que creamos necesarios

}
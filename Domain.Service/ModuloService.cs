
using Domain.Model;
using Data;
namespace Domain.Service;

public class ModuloService
{
    public void Add(Modulo modulo)
    {
        ModuloInMemory.Modulos.Add(modulo);
    }


    public bool Delete(int id)
    {
        Modulo? modToDelete = ModuloInMemory.Modulos.Find(x => x.Id == id);
        if (modToDelete != null)
        {
            ModuloInMemory.Modulos.Remove(modToDelete);
            return true;
        }
        else
        {
            return false;
        }
    }

    public Modulo Get(int id)
    {
        return ModuloInMemory.Modulos.FirstOrDefault(x => x.Id == id);
    }

    public IEnumerable<Modulo> GetAll()
    {
        return ModuloInMemory.Modulos.ToList();
    }

    public bool Update(Modulo modulo)
    {
        var modToUpdate = ModuloInMemory.Modulos.FirstOrDefault(x => x.Id == modulo.Id);
        if (modToUpdate != null)
        {
            modToUpdate.SetId(modulo.Id);
            modToUpdate.SetDescripcion(modulo.Descripcion);
            modToUpdate.SetEjecuta(modulo.Ejecuta);
            
            return true;
        }
        else
        {
            return false;
        }
    }
}
 
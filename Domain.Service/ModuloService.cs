
using Domain.Model;
using Data;
using DTOs;

namespace Domain.Service;

public class ModuloService
{
    
    public ModuloDTO Add(ModuloDTO modulo)
    {
        var moduloRepository = new ModuloRepository();
        Modulo mod = new Modulo(0,modulo.Descripcion,modulo.Ejecuta);
        moduloRepository.Add(mod);

        modulo.Id = mod.Id;

        return modulo;
    }


    public bool Delete(int id)
    {
        var moduloRepository = new ModuloRepository();
        return moduloRepository.Delete(id);
    }

    public ModuloDTO Get(int id)
    {
        var moduloRepository = new ModuloRepository();
        Modulo? modulo = moduloRepository.Get(id);
        if (modulo == null)
            return null;
        return new ModuloDTO(
            modulo.Id,
            modulo.Descripcion,
            modulo.Ejecuta);
        
    }

    public IEnumerable<ModuloDTO> GetAll()
    {
        var moduloRepository = new ModuloRepository();
        return moduloRepository.GetAll().Select(mod => new ModuloDTO(
            mod.Id,
            mod.Descripcion,
            mod.Ejecuta)).ToList();

    }

    public bool Update(ModuloDTO dto)
    {
        var moduloRepository = new ModuloRepository();
        Modulo modulo = new Modulo(dto.Id,dto.Descripcion,dto.Ejecuta);
        return moduloRepository.Update(modulo);
    }
}
 
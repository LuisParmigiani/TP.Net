namespace DTOs;

public class ModuloDTO
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public string Ejecuta { get; set; }

    public ModuloDTO()
    {
    }

    public ModuloDTO(int id, string descripcion, string ejecuta)
    {
        Id = id;
        Descripcion = descripcion;
        Ejecuta = ejecuta;
    }
    
}
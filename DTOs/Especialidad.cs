namespace DTOs;

public class EspecialidadDTO
{
    public int Id { get; set; }
    public string Descripcion { get; set; }

    public EspecialidadDTO()
    {
        
    }
    public EspecialidadDTO(int id, string desc)
    {
        Id = id;
        Descripcion = desc;
    }
}
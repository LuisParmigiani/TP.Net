namespace DTOs;

public class Especialidad
{
    public int Id { get; set; }
    public string Descripcion { get; set; }

    public Especialidad()
    {
        
    }
    public Especialidad(int id, string desc)
    {
        Id = id;
        Descripcion = desc;
    }
}
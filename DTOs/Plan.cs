namespace DTOs;

public class Plan
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public int IdEspecialidad { get; set; }
    public Plan (){ }

    public Plan(int id, string desc, int idEsp)
    {
        Id = id;
        Descripcion = desc;
        IdEspecialidad = idEsp;
    }
}

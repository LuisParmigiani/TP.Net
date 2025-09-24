namespace DTOs;

public class PlanDTO
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public int IdEspecialidad { get; set; }
    public PlanDTO (){ }

    public PlanDTO(int id, string desc, int idEsp)
    {
        Id = id;
        Descripcion = desc;
        IdEspecialidad = idEsp;
    }
}

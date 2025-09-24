namespace DTOs;

public class CursoDTO
{
    public int Id { get; set; }
    public int AnioCalendario { get;  set; }
    public int Cupo { get;  set; }
    public string Descripcion { get;  set; }
    public int IdComision { get;  set; }
    public int IdMateria { get; set; }

    public CursoDTO()
    {
        
    }

    public CursoDTO(int id, int anio, int cupo, string desc, int idC, int idM)
    {
        Id = id;
        AnioCalendario = anio;
        Cupo = cupo;
        Descripcion = desc;
        IdComision = idC;
        IdMateria = idM;
    }
}

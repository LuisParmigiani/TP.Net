namespace DTOs;

public class Curso
{
    public int Id { get; set; }
    public int AnioCalendario { get;  set; }
    public int Cupo { get;  set; }
    public string Descripcion { get;  set; }
    public int IdComision { get;  set; }
    public int IdMateria { get; set; }

    public Curso()
    {
        
    }

    public Curso(int id, int anio, int cupo, string desc, int idC, int idM)
    {
        Id = id;
        AnioCalendario = anio;
        Cupo = cupo;
        Descripcion = desc;
        IdComision = idC;
        IdMateria = idM;
    }
}

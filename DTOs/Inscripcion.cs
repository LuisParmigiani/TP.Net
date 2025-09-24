namespace DTOs;

public class InscripcionDTO
{
    public int Id{get;set;}
    public int IdCurso{get;set;}
    public int IdAlumno{get;set;}
    public int Nota{get;set;}
    public string Condicion{get;set;}

    public InscripcionDTO()
    {
        
    }
    public InscripcionDTO(int id, int idAlumno, int idCurso, int nota, string cond)
    {
        Id = id;
        IdAlumno = idAlumno;
        IdCurso = idCurso;
        Nota = nota;
        Condicion = cond;
    }
}
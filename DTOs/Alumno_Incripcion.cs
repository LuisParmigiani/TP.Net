namespace DTOs;

public class Alumno_Inscripcion
{
    public int Id{get;set;}
    public int IdCurso{get;set;}
    public int IdAlumno{get;set;}
    public int Nota{get;set;}
    public string Condicion{get;set;}

    public Alumno_Inscripcion()
    {
        
    }
    public Alumno_Inscripcion(int id, int idAlumno, int idCurso, int nota, string cond)
    {
        Id = id;
        IdAlumno = idAlumno;
        IdCurso = idCurso;
        Nota = nota;
        Condicion = cond;
    }
}
namespace DTOs;

public class EstadoAcedemico
{
    public int Id_Inscripcion { get; set; }
    public int Id_Alumno { get; set; }
    public string Condicion { get; set; }
    public int Nota { get; set; }
    //Curso
    public int Id_Curso { get; set; }
    public int AnioCalendario { get; set; }
    //COmision
    public int Id_Comision { get; set; }
    public string Descripcion_Comision { get; set; }
    //Materia
    public int Id_Materia { get; set; }
    public string Descripcion_Materia { get; set; }

    public EstadoAcedemico()
    {
        
    }

    public EstadoAcedemico(int idInsc, int idAlumno, string cond, int nota, int IdCurso, int nioCalendario, int id_Comision, string descripcionComision, int IdMateria, string descripcionMateria)
    {
        Id_Inscripcion = idInsc;
        Id_Alumno = idAlumno;
        Condicion = cond;
        Nota = nota;
        Id_Curso = IdCurso;
        AnioCalendario = nioCalendario;
        Id_Comision = id_Comision;  
        Descripcion_Comision = descripcionComision;
        Id_Materia = IdMateria;
        Descripcion_Materia = descripcionMateria;
    }
    
    
    
    
}
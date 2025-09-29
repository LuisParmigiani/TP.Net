namespace DTOs;
using DTOs;

public class AlumnoInscripcion
{
    public int IdALumno { get; set; }
    public int LegajoAlumno { get; set; }
    public string NombreAlumno { get; set; }
    public string ApellidoAlumno { get; set; }
    public int IdInscripcion { get; set; }
    public int Nota { get; set; }
    public AlumnoInscripcion()
    {
        
    }

    public AlumnoInscripcion(int idAlumno, int leg, string nom, string ape, int idInsc, int nota)
    {
        IdALumno = idAlumno;
        LegajoAlumno = leg;
        NombreAlumno = nom;
        ApellidoAlumno = ape;
        IdInscripcion = idInsc;
        Nota = nota;
    }
}
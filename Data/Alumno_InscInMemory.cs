namespace Data;
using Domain.Model;
public class AlumnoInscInMemory
{
    public static List<Alumno_Inscripcion> Inscripciones;

    static AlumnoInscInMemory()
    {
        Inscripciones = new List<Alumno_Inscripcion>
        {
            new Alumno_Inscripcion(1,1,1,80,"aprobado"),
            new Alumno_Inscripcion(2,2,1,85,"aprobado"),
            new Alumno_Inscripcion(3,3,1,30,"regular"),
                
        };
    }

}
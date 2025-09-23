using Domain.Model;

using System.Text.RegularExpressions;
namespace Domain.Model 
{
    
public class Curso : BusinessEntity
{
    public int AnioCalendario { get; private set; } public int Cupo { get; private set; }
    public string Descripcion { get; private set; }
    public int IdComision { get; private set; }
    public int IdMateria { get; private set; }
    
    public ICollection<Alumno_Inscripcion> Alumnos { get; private set; }
    
    public ICollection<DocenteCurso> DocentesCursos { get;  set; }

    public Curso()
    {
        
    }

    public Curso(int anio, int cupo, string descripcion, int idComision, int idMateria,int id):base(id)
    {
        SetAnioCalendario(anio);
        SetCupo(cupo);
        SetDescripcion(descripcion);
        SetIdComision(idComision);
        SetIdMateria(idMateria);
        
    }

    public Curso(int anio, string descripcion, int cupo, int idComision, int idMateria, int id)
    {
        AnioCalendario = anio;
        Cupo = cupo;
        Descripcion = descripcion;
        IdComision = idComision;
        IdMateria = idMateria;
        Id = id;
    }

    public void SetAnioCalendario(int anio)
    {
        if (anio >= 2025 & anio < 2500)
        {
            AnioCalendario = anio;
        }
        else
        {
            throw new ArgumentException("El año debe estar en rangos coherentes", nameof(anio));
        }
        
    }
    
    public void SetCupo(int cupo)
    {
        if (cupo <= 0)
        {
            throw new ArgumentException("El cupo debe ser mayor a 0", nameof(cupo));
        }
        else
        {
            Cupo = cupo;
        }
    }
    public void SetDescripcion(string desc)
    {
        if (string.IsNullOrEmpty(desc))
        {
            throw new ArgumentException("La descripción no puede ser nula o vacía", nameof(desc));
        }
        else
        {
            Descripcion = desc;
        }
    }
    public void SetIdComision(int idComision)
    {
        if (idComision <= 0)
        {
            throw new ArgumentException("El idComision debe ser mayor a 0", nameof(idComision));
        }
        else
        {
            IdComision = idComision;
        }
    }
    public void SetIdMateria(int idMateria)
    {
        if (idMateria <= 0)
        {
            throw new ArgumentException("El idMateria debe ser mayor a 0", nameof(idMateria));
        }
        else
        {
            IdMateria = idMateria;
        }
        
    }
}
}
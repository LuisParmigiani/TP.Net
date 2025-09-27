using System;
using System.Linq;

namespace Domain.Model;

public class Inscripcion : BusinessEntity
{
    public int IdAlumno { get; private set; }
    public int IdCurso { get; private set; }
    public int Nota { get; private set; }
    public string Condicion { get; private set; }

    public Inscripcion()
    {
        
    }
    public Inscripcion(int idInsc, int idAlumno, int idCurso, int nota, string condicion)
    {
        SetId(idInsc);
        SetIdAlumno(idAlumno);
        SetIdCurso(idCurso);
        SetNota(nota);
        SetCondicion(condicion);
    }

    public void SetIdAlumno(int idAlumno)
    {
        if (idAlumno > 0)
        {
            IdAlumno = idAlumno;
        }
        else
        {
            throw new ArgumentException("El ID de Alumno debe ser positivo");
        }
    }
    public void SetIdCurso(int idCurso)
    {
        if (idCurso > 0)
        {
            IdCurso = idCurso;
        }

        else
        {
            throw new ArgumentException("El ID de Curso debe ser positivo");
        }
    }
    
    public void SetNota(int nota)
    {
        if (nota < 0 || nota >100)
        {
            throw new ArgumentException("La nota debe estar entre 0 y 100");
        }
        else
        {
            Nota = nota;
        }
    }

    public void SetCondicion(string condicion)
    {
        string[] condiciones = ["aprobado", "regular", "libre", "cursando"];
        //La condición puede ser aprobada, regular o libre
        if (string.IsNullOrEmpty(condicion))
        {
            throw new ArgumentException("La condición no puede ser nula");
        }

        if (condiciones.Contains(condicion))
        {
            Condicion = condicion;       
        }
        else
        {
            
            throw new ArgumentException("La condición ingresada no es válida");
        }

    }
}
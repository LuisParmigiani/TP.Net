using System.Text.RegularExpressions;

namespace Domain.Model;

public class Persona : BusinessEntity
{
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public string Direccion { get; private set; }
    public string Email { get; private set; }
    public string Telefono { get; private set; }
    public DateTime FechaNacimiento { get; private set; }
    public int Legajo { get; private set; }
    public int TipoPersona { get; private set; } // Puede ser alumno(2) o docente(1)
    public int IdPlan { get; private set; }
    public ICollection<Usuario> Usuarios { get; set; }
    //Cursos que dicta la persona. Solo para los profesores
    public ICollection<DocenteCurso> Dictados { get; set; }
    //Cursos a los que va la persona. Solo para los alumnos
    public ICollection<Alumno_Inscripcion> Incripciones { get; set; }

    public Persona()
    {
        
    }

    public Persona(int id, string nombre, string apellido, string direccion, string email, string telefono,
        DateTime fechaNacimiento, int legajo, int tipoPersona, int idPlan) : base(id)
    {
        SetId(id);
        SetNombre(nombre);
        SetApellido(apellido);
        SetDireccion(direccion);
        SetEmail(email);
        SetTelefono(telefono);
        SetFechaNacimiento(fechaNacimiento);
        SetLegajo(legajo);
        SetTipoPersona(tipoPersona);
        SetIdPlan(idPlan);
        
    }
    private static bool EsValidoElMail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("El email no puede estar vacio"); 
        }
            
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    private static int CalcularEdad(DateTime fechaNacimiento)
    {
        DateTime fechaHoy = DateTime.Today;
        if (fechaNacimiento > fechaHoy)
        {
            throw new ArgumentException("La fecha de nacimiento no puede ser mayor a hoy");
        }
        int edad = fechaHoy.Year - fechaNacimiento.Year;
        if (fechaHoy.Month < fechaNacimiento.Month ||
            (fechaHoy.Month == fechaNacimiento.Month && fechaHoy.Day < fechaNacimiento.Day))
        {
            //Le resto 1 a la edad si todavía no cumplió
            edad--;
        }
        return edad;
        

    }


    public void SetNombre(string nombre)
    {
        if (string.IsNullOrEmpty(nombre))
        {
            throw new ArgumentException("El nombre no puede estar vacio");
        }
        else
        {
            Nombre = nombre;
        }
    }

    public void SetApellido(string apellido)
    {
        if (string.IsNullOrEmpty(apellido))
        {
            throw new ArgumentException("El apellido no puede estar vacio");
        }
        else
        {
            Apellido = apellido;
        }
        
        
    }
    public void SetDireccion(string direccion)
    {
        if (string.IsNullOrEmpty(direccion))
        {
            throw new ArgumentException("El direccion no puede estar vacio");
        }
        else
        {
            Direccion = direccion;
        }
    }
    public void SetEmail(string email)
    { 
        if (EsValidoElMail(email))
        {
            Email = email;
        }
        else
        {
            throw new ArgumentException("El mail debe tener un formato válido");
        }
        
    }
    public void SetTelefono(string telefono)
    {
        try
        {
            double tel = Double.Parse(telefono);
            if (tel >= 1000000000 && tel <= 9999999999)
            {
                Telefono = telefono;
            }
            else
            {
                throw new ArgumentException("El telefono debe estar entre 1000000000 y 9999999999");
            }
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    public void SetFechaNacimiento(DateTime fechaNacimiento)
    {
        int edad = CalcularEdad(fechaNacimiento);
        if (edad < 17)
        {
            throw new ArgumentException("Debe ser mayor de 17 para poder registrarse");
        }
        else
        {
            FechaNacimiento = fechaNacimiento;
        }
        
    }

    public void SetLegajo(int legajo)
    {
        //También vamos a tener que checkear si esta en la base
        if (legajo < 0)
        {
            
            throw new ArgumentException("El legajo debe ser mayor a 0");
        }
        else
        {
            Legajo = legajo;
        }
        
    }

    public void SetTipoPersona(int tipoPersona)
    {
        //si es 1, es docente
        //si es 2, es alumnno
        if (tipoPersona < 1 || tipoPersona > 2)
        {
            throw new ArgumentException("El id no es válido");
        }
        else
        {
            TipoPersona = tipoPersona;
        }
        
    }

    public void SetIdPlan(int idPlan)
    {
        // Se va a tener que checkear si estan en la base
        if (idPlan < 0)
        {
            
            throw new ArgumentException("El id de plan no es válido");
        }
        else
        {
            IdPlan = idPlan;
        }
        
    }
    
}

using System;
using System.Linq;

namespace Domain.Model;

public class Usuario : BusinessEntity
{
    public string NombreUsuario { get; private set; }
    public string Clave { get; private set; }
    public bool Habilitado { get; private set; }
    public bool CambiaClave { get; private set; }
    public int IdPersona { get; private set; }
    //Defino la colección de Modulos que va a tener un usuario
    
    public Usuario()
    {
        
    }
    public Usuario(int id, string nombre, string clave, bool habilitado, bool cambiaClave, int idPersona)
    {
        SetId(id);
        SetNombre(nombre);
        SetClave(clave);
        SetHabilitado(habilitado);
        SetCambiaClave(cambiaClave);
        SetIdPersona(idPersona);
    }
    public void SetNombre(string nombre)
    {
        if (string.IsNullOrEmpty(nombre))
        {
            throw new ArgumentException("El nombre no puede estar vacio");
        }
        else
        {
            
            NombreUsuario = nombre;
        }
    }

    public void SetClave(string clave)
    {
        if (string.IsNullOrEmpty(clave))
        {
            throw new ArgumentException("La clave no puede ser nula");
        }

        if (clave.Length < 5 || !clave.Any(char.IsUpper) || !clave.Any(char.IsDigit))
        {
            throw new ArgumentException("La clave debe tener más de 5 caracteres, una mayúscula y un dígito");
        }
        else
        {
            Clave = clave;
        }
    }

    public void SetHabilitado(bool habilitado)
    {
        Habilitado = habilitado;
    }

    public void SetCambiaClave(bool cambiaClave)
    {
        CambiaClave = cambiaClave;
    }

    public void SetIdPersona(int idPersona)
    {
        if (idPersona < 0)
        {
            throw new ArgumentException("El idPersona no puede ser negativo");
            
        }
        else
        {
            IdPersona = idPersona;
        }
    }
}
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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

    public string HashPassword(string password)
    {
        using (var sha256 = SHA256.Create())
        {
            var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashedBytes);
        }
    }

    public bool VerifyPassword(string password)
    {
        return Clave == HashPassword(password);
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
            Clave = HashPassword(clave);
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
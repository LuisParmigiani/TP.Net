namespace Domain.Model;

public class ModuloUsuario : BusinessEntity
{
    public int IdModulo { get; private set; }
    public int IdUsuario { get; private set; }
    public bool Alta { get; private set; }
    public bool Baja { get; private set; }
    public bool Modificacion { get; private set; }
    public bool Consulta { get; private set; }
    
    public ModuloUsuario() { }

    public ModuloUsuario(int id, int idMod, int idUs, bool alta, bool baja, bool mod, bool cons)
    {
        SetId(id);
        SetIdModulo(idMod);
        SetIdUsuario(idUs);
        SetAlta(alta);
        SetBaja(baja);
        SetModificacion(mod);
        SetConsulta(cons);
    }

    public void SetIdModulo(int idMod)
    {
        if (idMod > 0)
        {
            IdModulo = idMod;
        }else
        {
         throw new ArgumentException("El id del modulod debe ser mayor a 0");   
        }
    }

    public void SetIdUsuario(int idUsuario)
    {
        if (idUsuario > 0)
        {
            IdUsuario = idUsuario;
        }
        else
        {
            throw new ArgumentException("El id del usuario debe ser mayor a 0");
        }
    }
    public void SetAlta(bool alta)
        {
        Alta = alta;
        }

    public void SetBaja(bool baja)
    {
        Baja = baja;
    }

    public void SetModificacion(bool modificacion)
    {
        Modificacion = modificacion;
    }

    public void SetConsulta(bool consulta)
    {
        Consulta = consulta;
    }
    
}
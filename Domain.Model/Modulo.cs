namespace Domain.Model;

public class Modulo : BusinessEntity
{
    public string Descripcion { get; private set; }
    public string Ejecuta { get; private set; }
    //Defino la colección de Usuarios que tiene modulo
    public ICollection<Usuario> Usuarios { get;  set; } = new List<Usuario>();

    public Modulo()
    {
        
    }

    public Modulo(int id, string desc, string ejec)
    {
        SetId(id);
        SetDescripcion(desc);
        SetEjecuta(ejec);
        
    }

    public void SetDescripcion(string desc)
    {
        if (string.IsNullOrEmpty(desc))
        {
            throw new ArgumentException("La descripción no puede ser nula");
        }
        else
        {
            Descripcion = desc;
        }
    }
    public void SetEjecuta(string ejec)
    {
        if (string.IsNullOrEmpty(ejec))
        {
            throw new ArgumentException("La ejecución no puede ser nula");
        }
        else
        {
            Ejecuta = ejec;
        }
    }
}
namespace Domain.Model;

public class Especialidad : BusinessEntity
{
    public string Descripcion { get; private set; }

    public void SetDescripcion(string desc)
    {
        if (string.IsNullOrEmpty(desc))
        {
            throw new ArgumentException("La descripción no puede estar vacía");
        }
        else
        {
            Descripcion = desc;
        }
    }

    public Especialidad(int idEsp, string descripcion)
    {
        Id = idEsp;
        SetDescripcion(descripcion);
    }
}
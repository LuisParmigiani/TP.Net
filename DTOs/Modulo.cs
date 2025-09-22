namespace DTOs;

public class Modulo
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public string Ejecuta { get; set; }

    public Modulo()
    {
    }

    public Modulo(int id, string descripcion, string ejecuta)
    {
        Id = id;
        Descripcion = descripcion;
        Ejecuta = ejecuta;
    }
    
}
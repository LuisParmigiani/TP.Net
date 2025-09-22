namespace DTOs;

public class ModuloUsuario
{
    public int Id { get; set; }
    public int IdModulo { get; set; }
    public int IdUsuario { get; set; }
    public bool Alta { get; set; }
    public bool Baja { get; set; }
    public bool Modificacion { get; set; }
    public bool Consulta { get; set; }

    public ModuloUsuario()
    {
    }

    public ModuloUsuario(int id, int idMod, int idUs, bool alta, bool baja, bool mod, bool cons)
    {
        Id = id;
        IdModulo = idMod;
        IdUsuario = idUs;
        Alta = alta;
        Baja = baja;
        Modificacion = mod;
        Consulta = cons;
    }
}
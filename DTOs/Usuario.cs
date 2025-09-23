namespace DTOs;

public class UsuarioDTO
{
    public int Id { get; set; }
    public string NombreUsuario { get; set; }
    public string Clave { get; set; }
    public bool Habilitado { get; set; }
    public bool CambiaClave { get; set; }
    public int IdPersona { get; set; }
    public UsuarioDTO(){ }
    public UsuarioDTO(int id, string nombre, string clave, bool habilitado,int idPersona,bool cambia)
    {
        Id = id;
        NombreUsuario = nombre;
        Clave = clave;
        Habilitado = habilitado;
        IdPersona = idPersona;
        CambiaClave = cambia;
    }
}
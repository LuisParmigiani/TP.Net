namespace DTOs;



public class Persona
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public int Legajo { get; set; }
    public int TipoPersona { get; set; } // Puede ser usuario,alumno o docente
    public int IdPlan { get; set; }
    public Persona() { }

    public Persona(int id_per, string nombre, string apellido, string direccion, string email, string telefono,
        DateTime fechaNacimiento, int legajo, int tipoPersona, int idPlan){
        Id = id_per;
        Nombre = nombre;
        Apellido = apellido;
        Direccion = direccion;
        Email = email;
        Telefono = telefono;
        FechaNacimiento = fechaNacimiento;
        Legajo = legajo;
        TipoPersona = tipoPersona;
        IdPlan = idPlan;

    }

}
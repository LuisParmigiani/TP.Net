using Domain.Model;

namespace Data;

public class EspInMemory
{
    public static List<Especialidad> Especialidades;

    static EspInMemory()
    {
        Especialidades = new List<Especialidad>
        {
            new Especialidad(1,"Ingeniería en sistemas")
            
        };
    }

}
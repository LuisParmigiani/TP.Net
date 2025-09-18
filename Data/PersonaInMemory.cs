using Domain.Model;

namespace Data;

public class PersonaInMemory
{
    
    public static List<Persona> Personas;

    static PersonaInMemory()
    {
        Personas = new List<Persona>
        {
            new Persona(1,"Agustin","Dana","Pedro A Rios 750","agusidana04@gmail.com","3413946996"
                ,DateTime.Parse("23/08/2004"),52935,2,3)
            
        };
    }
}
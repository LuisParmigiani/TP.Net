namespace Data;
using Domain.Model;

public static class ModuloInMemory
{
    public static List<Modulo> Modulos;

    static ModuloInMemory()
    {
        Modulos = new List<Modulo>
        {
                new Modulo(1,"Modulo número 1","No se que iría acá"),
                new Modulo(2,"Módulo número 2","Tampoco sé")
        };
    }
 
}
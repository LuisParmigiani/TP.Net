using Domain.Model;
public class CursoInMemory
{
    public static List<Curso> Cursos;

    static CursoInMemory()
    {
        Cursos = new List<Curso>
        {
            //Lleno la colección
            new Curso(2024, "Curso de Programación Web",40, 1, 1,1),
            new Curso(2024, "Curso de Base de Datos", 50,2, 2,2),
            new Curso(2024,  "Curso de Algoritmos",30, 3, 3,3),
            new Curso(2024,  "Curso de Sistemas Operativos",20, 4, 4,4),
            new Curso(2024,  "Curso de Redes",10, 5, 5,5)

        };
    }

}
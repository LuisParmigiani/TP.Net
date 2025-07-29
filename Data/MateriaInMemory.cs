using Domain.Model;

namespace Data
{ 
    public static class MateriaInMemory
    {
        public static List<Materia> Materias;

        static MateriaInMemory()
        {
            Materias = new List<Materia>
            {
                new Materia(1,"Matemáticas", 4, 64, 1),
                new Materia(2,"Programación", 6, 96, 2),
                new Materia(3, "Bases de Datos", 3, 48, 3),
                new Materia(4, "Redes", 2, 32, 4),
                new Materia(5, "Sistemas Operativos", 3, 48, 5)
            };
        }
    }
}
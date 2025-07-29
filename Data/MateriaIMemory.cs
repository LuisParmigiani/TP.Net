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
                new Materia("Matemáticas", 4, 64, 1),
                new Materia("Programación", 6, 96, 2),
                new Materia("Bases de Datos", 3, 48, 3),
                new Materia("Redes", 2, 32, 4),
                new Materia("Sistemas Operativos", 3, 48, 5)
            };
        }
    }
}
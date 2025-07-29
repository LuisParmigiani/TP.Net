using System.Text.RegularExpressions;

namespace DTOs
{
    public class Materia
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int HSSemanales { get; set; }
        public int HSTotales { get; set; }
        public int IdPlan { get; set; }
    }
}
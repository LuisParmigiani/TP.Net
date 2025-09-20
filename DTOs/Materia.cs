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
        public Materia(){}
        public Materia(int id, string desc, int hsSem, int HsTot, int idP)
        {
            Id = id;
            Descripcion = desc;
            HSSemanales = hsSem;
            HSTotales = HsTot;
            IdPlan = idP;
        }
    }
}
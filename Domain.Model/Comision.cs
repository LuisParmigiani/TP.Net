namespace Domain.Model
{
    public class Comision : BusinessEntity
    {
        public int AnioEspecialidad { get; private set; }
        public string Descripcion { get; private set; }
        public int IDPlan { get; private set; }
        
        public ICollection<Curso> Cursos { get; set; }

        public Comision()
        {
            
        }

        public Comision(int id, int anioEspecialidad, string descripcion, int idPlan) : base(id)
        {
            SetId(id);
            SetAnioEspecialidad(anioEspecialidad);
            SetDescripcion(descripcion);
            SetIDPlan(idPlan);
        }
        public void SetAnioEspecialidad(int anioEspecialidad)
        {
            if (anioEspecialidad >= 1 && anioEspecialidad <= 5)
            {
                AnioEspecialidad = anioEspecialidad;
            }
            else
            {
                throw new ArgumentException("AnioEspecialidad especialidad no valido");
            }
        }
        public void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion) || descripcion.Length < 3 || descripcion.Length > 50)
            {
                throw new ArgumentException("La descripción debe tener entre 3 y 50 caracteres.");
            }
            Descripcion = descripcion;
        }
        public void SetIDPlan(int idPlan)
        {
            if (idPlan <= 0)
            {
                throw new ArgumentException("El ID del plan debe ser un número positivo.");
            }
            IDPlan = idPlan;
        }
    }
}

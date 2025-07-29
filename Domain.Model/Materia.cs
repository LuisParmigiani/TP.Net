namespace Domain.Model
{
    public class Materia : BusninessEntity
    {
        public string Descripcion { get; private set; }
        public int HSSemanales { get; private set; }
        public int HSTotales { get; private set; }
        public int IDPlan { get; private set; }
        public Materia(int id, string descripcion, int hsSemanales, int hsTotales, int idPlan) : base(id)
        {
            SetDescripcion(descripcion);
            SetHSSemanales(hsSemanales);
            SetHSTotales(hsTotales);
            SetIDPlan(idPlan);
        }
        public void SetDescripcion(string descripcion)
        {
            if (descripcion == null || descripcion.Length < 3 || descripcion.Length > 50)
            {
                throw new ArgumentException("La descripción debe tener entre 3 y 50 caracteres.");
            }
            Descripcion = descripcion;
        }
        public void SetHSSemanales(int hsSemanales)
        {
            if (hsSemanales < 0 || hsSemanales > 20)
            {
                throw new ArgumentException("Las horas semanales deben estar entre 0 y 20.");
            }
            HSSemanales = hsSemanales;
        }
        public void SetHSTotales(int hsTotales)
        {
            if (hsTotales < 0 || hsTotales > 200)
            {
                throw new ArgumentException("Las horas totales deben estar entre 0 y 200.");
            }
            HSTotales = hsTotales;
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
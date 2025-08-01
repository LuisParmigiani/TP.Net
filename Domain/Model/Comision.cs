public class Comision : BusninessEntity
{
    public int AnioEspecialidad { get; private set; }
    public string Descripcion { get; private set; }
    public int IDPlan { get; private set; }
    public void SetAnioEspecialidad(int anioEspecialidad);
    public void SetDescripcion(string descripcion);
    public void SetIDPlan(int idPlan);
}
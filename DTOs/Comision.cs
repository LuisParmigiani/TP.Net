using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class Comision
    {
        public int Id { get; set; }
        public int AnioEspecialidad { get; set; }
        public string Descripcion { get; set; }
        public int IDPlan { get; set; }

        public Comision()
        {
            
        }

        public Comision(int id, int anioEsp, string desc, int idPlan)
        {
            Id = id;
            AnioEspecialidad = anioEsp;
            Descripcion = desc;
            IDPlan = idPlan;
        }
    }
    
}

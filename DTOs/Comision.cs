using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ComisionDTO
    {
        public int Id { get; set; }
        public int AnioEspecialidad { get; set; }
        public string Descripcion { get; set; }
        public int IDPlan { get; set; }

        public ComisionDTO()
        {
            
        }

        public ComisionDTO(int id, int anioEsp, string desc, int idPlan)
        {
            Id = id;
            AnioEspecialidad = anioEsp;
            Descripcion = desc;
            IDPlan = idPlan;
        }
    }
    
}

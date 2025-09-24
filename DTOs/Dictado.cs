using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class DictadoDTO
    {
        public int Id { get; set; }
        public string Cargo { get; set; }
        public int IDCurso { get; set; }
        public int IDDocente { get; set; }

        public DictadoDTO()
        {
            
        }

        public DictadoDTO(int id, string car, int idC, int idD)
        {
            Id = id;
            Cargo = car;
            IDCurso = idC;
            IDDocente = idD;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class DocenteCurso : BusinessEntity
    {
        public string Cargo { get; private set; }
        public int IDCurso { get; private set; }
        public int IDDocente { get; private set; }
    

    public DocenteCurso(int id, string cargo, int idCurso, int idDocente) : base(id)
    {
        SetId(id);
        SetCargo(cargo);
        SetIDCurso(idCurso);
        SetIDDocente(idDocente);
        }

        public void SetCargo(string cargo)
            {
            Cargo = cargo;
        }
        public void SetIDCurso(int idCurso)
        {
            IDCurso = idCurso;
        }
        public void SetIDDocente(int idDocente)
        {
            IDDocente = idDocente;
        }
    }
}

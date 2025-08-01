using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Data
{
    public class ComisionInMemory
    {
        public static List<Comision> Comisiones;

        static ComisionInMemory()
        {
            Comisiones = new List<Comision>
            {
                new Comision(1, 2024, "Desc1", 1),
                new Comision(2, 2024, "Desc2", 2),
                new Comision(3, 2024, "Desc3", 3),
                new Comision(4, 2024, "desc4", 4),
            };
        }
    }
}
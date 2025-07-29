using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public abstract class BusninessEntity
    {
        public int Id { get; set; }

        protected BusninessEntity(int id)
        {
            SetId(id);
        }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}

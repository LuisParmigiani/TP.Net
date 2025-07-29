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
        private static int _nextId = 1;
        public int Id { get; set; }

        protected BusninessEntity()
        {
            SetId();
        }

        public void SetId()
        {
            Id = _nextId++;
        }
    }
}

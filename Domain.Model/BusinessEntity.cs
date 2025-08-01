using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public abstract class BusinessEntity
    {
        public int Id { get; set; }

        protected BusinessEntity(int id)
        {
            SetId(id);
        }

        protected BusinessEntity()
        {
            
        }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}

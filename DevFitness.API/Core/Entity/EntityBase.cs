using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Core.Entity
{
    public class EntityBase
    {
        public int Id { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreateAt { get; private set; }

        public EntityBase()
        {
            Active = true;
            CreateAt = DateTime.Now;
        }


        protected void Deactivate()
        {
            Active = false;
        }
    }
}

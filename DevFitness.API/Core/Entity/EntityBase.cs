using System;

namespace DevFitness.API.Core.Entity
{
    public class EntityBase
    {
        public int Id { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreateAt { get; private set; }

        protected EntityBase()
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

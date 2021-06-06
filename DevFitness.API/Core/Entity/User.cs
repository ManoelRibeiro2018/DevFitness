using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Core.Entity
{
    public class User: EntityBase
    {
        public string FullName { get; private set; }
        public decimal Height { get; private set; }
        public decimal Weight { get; private set; }
        public DateTime BirthDate { get; private set; }

        public User(string fullName, decimal height, decimal weight, DateTime birthDate) : base()
        {
            FullName = fullName;
            Height = height;
            Weight = weight;
            BirthDate = birthDate;
            Meals = new List<Meal>();
        }

        public IEnumerable<Meal> Meals { get; set; }
    }
}

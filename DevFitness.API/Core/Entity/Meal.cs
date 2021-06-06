using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Core.Entity
{
    public class Meal: EntityBase
    {
        public string Description { get; private set; }
        public int Calories { get; private set; }
        public DateTime Date { get; private set; }
        public int IdUser { get; private set; }

        public Meal(string description, int calories, DateTime date, int idUser) : base()
        {
            Description = description;
            Calories = calories;
            Date = date;  
            IdUser = idUser;
        }
    }
}

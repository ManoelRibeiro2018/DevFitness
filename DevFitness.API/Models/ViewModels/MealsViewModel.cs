using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Models.ViewModels
{
    public class MealsViewModel
    {
        public int Id { get; private set; }
        public string Description { get; private set; }
        public int Calories { get; private set; }
        public DateTime Date { get; private set; }

        public MealsViewModel(int id, string description, int calories, DateTime date)
        {
            Id = id;
            Description = description;
            Calories = calories;
            Date = date;
        }
    }
}

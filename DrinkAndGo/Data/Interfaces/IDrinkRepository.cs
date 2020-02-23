using DrinkAndGo.Data.Models;
using DrinkAndGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Interfaces
{
    public interface IDrinkRepository
    {
        public IEnumerable<Drink> Drinks { get;  }
        public IEnumerable<Drink> PreferredDrinks { get; }
        public Drink GetDrinkById(int drinkId);
    }
}

using Rapsody.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rapsody.Interfaces
{
    public interface IAllFoods
    {
        IEnumerable<Food> Foods { get; }
        IEnumerable<Food> getFavFoods { get; }
        Food getObjectFood(int foodId);
    }
}

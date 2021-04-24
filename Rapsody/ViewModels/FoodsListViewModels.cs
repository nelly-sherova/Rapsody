using Rapsody.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rapsody.ViewModels
{
    public class FoodsListViewModels
    {
        public IEnumerable<Food> allFoods { get; set; }
        public string foodCategory;
    }
}

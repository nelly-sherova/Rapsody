using Rapsody.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rapsody.Interfaces
{
    public interface IFoodsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

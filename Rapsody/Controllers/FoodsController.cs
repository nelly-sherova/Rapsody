using Microsoft.AspNetCore.Mvc;
using Rapsody.Interfaces;
using Rapsody.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rapsody.Controllers
{
    public class FoodsController : Controller
    {
        private readonly IAllFoods _allFoods;
        private readonly IFoodsCategory _allCategories;

        public FoodsController (IAllFoods iAllFoods, IFoodsCategory iFoodsCat)
        {
            _allFoods = iAllFoods;
            _allCategories = iFoodsCat;
        }

        public IActionResult List()
        {
            FoodsListViewModels obj = new FoodsListViewModels();
            obj.allFoods = _allFoods.Foods;
            obj.foodCategory = "Еда";
            return View(obj);
        }
    }
}

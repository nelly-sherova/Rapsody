using Microsoft.AspNetCore.Mvc;
using Rapsody.Interfaces;
using Rapsody.Models;
using Rapsody.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rapsody.Controllers
{
    public class RapsodyCartController : Controller
    {
        private readonly IAllFoods _foodRep;
        private readonly RapsodyCart _rapCart;

        public RapsodyCartController(IAllFoods foodRep, RapsodyCart rapsodyCart)
        {
            _foodRep = foodRep;
            _rapCart = rapsodyCart;
        }

        public IActionResult Index()
        {
            var items = _rapCart.getRapsodyItems();
            _rapCart.listRapsodyItem = items;

            var obj = new RapsodyCartViewModel
            {
                rapsodyCart = _rapCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int Id)
        {
            var item = _foodRep.Foods.FirstOrDefault(i => i.Id == Id);
            if (item != null)
            {
                _rapCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}

using Rapsody.Interfaces;
using Rapsody.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rapsody.Mocks
{
    public class MoscFoods : IAllFoods
    {
        private readonly IFoodsCategory _foodsCategory = new MockCategory();
        public IEnumerable<Food> Foods
        {
            get
            {
                return new List<Food>
                {
                    new Food
                    {
                        Name = "Капрезе",
                        ShortDesc = "210 г",
                        LongDesc = "Моцарелла, \n" +
                        "Томаты, \n " +
                        "Базилик, \n" +
                        "Соль,\n" +
                        "Молотый черный перец, \n" +
                        "Оливковое масло, \n" +
                        "Бальзамеческий уксус,\n" +
                        "Чеснок",
                        Img = "https://www.eat-me.ru/wp-content/uploads/2019/03/salat-kapreze-768x427.jpg",
                        Price = 290,
                        IsFavorite = true,
                        Category = _foodsCategory.AllCategories.First()
                    },
                    new Food
                    {
                        Name = "Лимон",
                        ShortDesc = "40 г",
                        LongDesc = "",
                        Img = "https://www.syl.ru/misc/i/ni/5/8/2/2/0/3/i/582203.jpg",
                        Price = 40,
                        IsFavorite = true,
                        Category = _foodsCategory.AllCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<Food> getFavFoods { get; set; }

        public Food getObjectFood(int foodId)
        {
            throw new NotImplementedException();
        }
    }
}

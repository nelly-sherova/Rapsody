using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Rapsody.Models;

namespace Rapsody.Data
{
    public class DBObjects
    {
        public static void Initial(AppDbContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Food.Any())
                content.AddRange(
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
                        Img = "/img/Kaprese.jpg",
                        Price = 290,
                        IsFavorite = true,
                        Category = Categories["Салаты"]
                    },
                    new Food
                    {
                        Name = "Лимон",
                        ShortDesc = "40 г",
                        LongDesc = "",
                        Img = "/img/Lemon.jpg",
                        Price = 40,
                        IsFavorite = true,
                        Category = Categories["Добавки к чаю"]
                    },
                    new Food
                    {
                        Name = "Суп - шурпа из баранины",
                        ShortDesc = "250 г",
                        LongDesc = "Баранина, \n" +
                        "Лук, \n" +
                        "Морковь \n " +
                        "Картошка \n " +
                        "Горох \n " +
                        "Специи\n ",
                        Img = "/img/IMG_20210427_103225_100.jpg",
                        Price = 180,
                        IsFavorite = false,
                        Category = Categories["Супы"]

                    },
                    new Food
                    {
                        Name = "Стейк <<Миньон>>",
                        ShortDesc = "470 г",
                        LongDesc = "Говядина",
                        Img = "/img/IMG_20210427_103342_389.jpg",
                        Price = 480,
                        IsFavorite = true,
                        Category = Categories["Стейки"]
                    }
                    );
            content.SaveChanges();
        }
        public static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                         new Category
                    {
                        CategoryName = "Салаты",
                        Desc = "Салаты из овощей и фруктов"
                    },
                    new Category
                    {
                        CategoryName = "Холодные закуски",
                        Desc = "Еда, подаваемая самостоятельно или перед основными блюдами и не нагреваемая перед подачей"
                    },
                    new Category
                    {
                        CategoryName = "Горячие закуски",
                        Desc = "Отварные, жареные, запеченные овощи, горячие бутерброды, сэндвичи, тосты, приготовленные в кляре рыба или птица, гренки."
                    },
                    new Category
                    {
                        CategoryName = "Паста",
                        Desc = "Макаронные изделия"
                    },
                    new Category
                    {
                        CategoryName = "Гарнир",
                        Desc = "Дополнительные компоненты к основной части блюда, предназначенные для его украшения, увеличения питательной и вкусовой ценности."
                    },
                    new Category
                    {
                        CategoryName = "Супы",
                        Desc = "Блюдо, в составе которого содержится не менее 50% жидкости"
                    },
                    new Category
                    {
                        CategoryName = "Блюда из курицы",
                        Desc = "Блюда с куриным мясом"
                    },
                    new Category
                    {
                        CategoryName = "Блюда из телятины (говядины)",
                        Desc = "Блюда с говяжим мясом"
                    },
                    new Category
                    {
                        CategoryName = "Блюда из баранины",
                        Desc = "Блюда с бараниной"
                    },
                    new Category
                    {
                        CategoryName = "Блюда из рыбы",
                        Desc = "Блюда с рыбой"
                    },
                    new Category
                    {
                        CategoryName = "Мангальное меню",
                        Desc = "Ароматные, сочные шашлыки, барбекю и поджаренных на гриле овощей"
                    },
                    new Category
                    {
                        CategoryName = "Стейки",
                        Desc = "Толстый, сочный из лучших частей говядины или рыбы обжаренного мяса"
                    },
                    new Category
                    {
                        CategoryName = "Хлеб",
                        Desc = "Хлебобулочные изделия"
                    },
                    new Category
                    {
                        CategoryName = "Соусы",
                        Desc = "Жидкая приправа, подливка к кушанью"
                    },
                    new Category
                    {
                        CategoryName = "Десерты",
                        Desc = "Фрукты, конфеты и сладкие блюда"
                    },
                    new Category
                    {
                        CategoryName = "Хачапури",
                        Desc = "Блюдо грузинской кухни, пирожок с начинкой из сыра и яйца"
                    },
                    new Category
                    {
                        CategoryName = "Горячая выпечка",
                        Desc = "Хлебобулочные изделия с мясом, сыром и т.д. "
                    },
                    new Category
                    {
                        CategoryName = "Блюда на заказ",
                        Desc = "Блюдо которое вы можете заказать у нас в большой количестве, для проведения каких либо мероприятий за пределами нашего кафе "
                    },
                    new Category
                    {
                        CategoryName = "Напитки",
                        Desc = "Жидкость для питья, без газа"
                    },
                    new Category
                    {
                        CategoryName = "Кофе",
                        Desc = "Разные виды кофе"
                    },
                    new Category
                    {
                        CategoryName = "Газ водв",
                        Desc = "Жидкость для питья, с газом"
                    },
                    new Category
                    {
                        CategoryName = "Фреш",
                        Desc = "Свежевыжатый сок"
                    },
                    new Category
                    {
                        CategoryName = "Чай черный",
                        Desc = "Разные виды черного чая"
                    },
                    new Category
                    {
                        CategoryName = "Чай зеленый",
                        Desc = "Разные виды зеленого чая"
                    },
                    new Category
                    {
                        CategoryName = "Чай ягодный",
                        Desc = "Чай с ягодами"
                    },
                    new Category
                    {
                        CategoryName = "Чайные напитки",
                        Desc = "Разные виды чайных напиток"
                    },
                    new Category
                    {
                        CategoryName = "Добавки к чаю",
                        Desc = "Разные добавки к чаю"
                    }
                    };


                    category = new Dictionary<string, Category>();


                    foreach (Category el in list)
                        category.Add(el.CategoryName, el);

                }

                return category;
            }
        }
        
    }
}

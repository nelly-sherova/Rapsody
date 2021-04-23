using Rapsody.Interfaces;
using Rapsody.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rapsody.Mocks
{
    public class MockCategory : IFoodsCategory
    {
        public IEnumerable<Category> AllCategories {
            get
            {
                return new List<Category>
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
                        CategoryName = "Напитки",
                        Desc = "Жидкость для питья, без газа"
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
                    },
                };
            }
            
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rapsody.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rapsody.Models
{
    public class RapsodyCart
    {
        private readonly AppDbContent appDbContent;

        public RapsodyCart(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public string RapsodyCartId { get; set; }
        public List<RapsodyCartItem> listRapsodyItem {get; set;}

        public static RapsodyCart GetCart(IServiceProvider services)//добавлял ли пользователь что либо в карзину
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContent>();
            string rapsodyCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString(); // если нет Id он сам его добавит
            session.SetString("CartId", rapsodyCartId);


            return new RapsodyCart(context) { RapsodyCartId = rapsodyCartId };
        }

        public void AddToCart(Food food)
        {
            appDbContent.RapsodyCartItem.Add(new RapsodyCartItem {
                RapsodyCartId = RapsodyCartId,
                Food = food,
                Price = food.Price,


            });
            appDbContent.SaveChanges();
        }

        public List<RapsodyCartItem> getRapsodyItems()
        {

            return appDbContent.RapsodyCartItem.Where(c => c.RapsodyCartId == RapsodyCartId).Include(s => s.Food).ToList();
        }
     }
}

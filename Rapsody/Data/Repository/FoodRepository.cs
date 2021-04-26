using Microsoft.EntityFrameworkCore;
using Rapsody.Interfaces;
using Rapsody.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rapsody.Data.Repository
{
    public class FoodRepository : IAllFoods
    {
        private readonly AppDbContent appDbContent;

        public FoodRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Food> Foods => appDbContent.Food.Include(c => c.Category);

        public IEnumerable<Food> getFavFoods => appDbContent.Food.Where(p => p.IsFavorite).Include(c => c.Category);

        public Food getObjectFood(int foodId) => appDbContent.Food.FirstOrDefault(p => p.Id == foodId);
    }
}

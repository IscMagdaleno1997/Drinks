using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly AddDbContext _addDbContext;

        public CategoryRepository( AddDbContext addDbContext)
        {
            _addDbContext = addDbContext;
        }

        public IEnumerable<Category> Categories => _addDbContext.Categories;
    }
}

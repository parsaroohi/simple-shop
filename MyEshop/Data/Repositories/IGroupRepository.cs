using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyEshop.Models;

namespace MyEshop.Data.Repositories
{
    public interface IGroupRepository
    {
        IEnumerable<Category> GetAllCategries();
        IEnumerable<ShowGroupViewModel> GetGroupForShow();
    }

    public class GroupRepository : IGroupRepository
    {
        private MyEshopContext _context;

        public GroupRepository(MyEshopContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategries()
        {
            return _context.Categories;
        }

        public IEnumerable<ShowGroupViewModel> GetGroupForShow()
        {
            return _context.Categories
                    .Select(c => new ShowGroupViewModel()
                    {
                        GroupId = c.Id,
                        Name = c.Name,
                        ProductCount = _context.CategoryToProducts.Count(g => g.CategoryId == c.Id)
                    }).ToList();
        }
    }
}

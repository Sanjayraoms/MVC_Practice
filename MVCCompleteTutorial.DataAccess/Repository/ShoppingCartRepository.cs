using MVCCompleteTutorial.DataAccess.Data;
using MVCCompleteTutorial.DataAccess.Repository.IRepository;
using MVCCompleteTutorial.Models;
using MVCCompleteTutorial.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVCCompleteTutorial.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShopiingCartRepository
    {
        private ApplicationDbContext _dbContext;

        public ShoppingCartRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(ShoppingCart shoppingCart)
        {
            _dbContext.shoppingCarts.Update(shoppingCart);
        }
    }
}

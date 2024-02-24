using MVCCompleteTutorial.DataAccess.Data;
using MVCCompleteTutorial.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCompleteTutorial.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Category = new CategoryRepository(_dbContext);
            Product = new ProductRepository(_dbContext);
            Company = new CompanyRepository(_dbContext);
            ShoppingCart = new ShoppingCartRepository(_dbContext);
            
        }
        public IcategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }

        public ICompanyRepository Company { get; private set; }

        public IShopiingCartRepository ShoppingCart { get; private set; }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}

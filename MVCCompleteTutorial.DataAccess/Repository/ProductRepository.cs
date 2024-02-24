using MVCCompleteTutorial.DataAccess.Data;
using MVCCompleteTutorial.DataAccess.Repository.IRepository;
using MVCCompleteTutorial.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCompleteTutorial.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Product product)
        {
            var productfroDb = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            if (product != null)
            {
                productfroDb.Title = product.Title;
                productfroDb.Author = product.Author;
                productfroDb.ISBN = product.ISBN;
                productfroDb.Description = product.Description;
                productfroDb.Price100 = product.Price100;
                productfroDb.Price = product.Price;
                productfroDb.Price50 = product.Price;
                productfroDb.ListPrice = product.ListPrice;
                productfroDb.CategoryId = product.CategoryId;
                if (product.ImageUrl !=null)
                {
                    productfroDb.ImageUrl = product.ImageUrl;
                }
            }
            //_context.Products.Update(product);
        }
    }
}

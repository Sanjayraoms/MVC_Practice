using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCCompleteTutorial.Models;
using MVCCompleteTutorial.Models.Models;

namespace MVCCompleteTutorial.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}

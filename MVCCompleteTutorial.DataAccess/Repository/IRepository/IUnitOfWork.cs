using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCompleteTutorial.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IcategoryRepository Category { get; }
        IProductRepository Product { get; }

        ICompanyRepository Company { get; }

        IShopiingCartRepository ShoppingCart { get; }

        IOrderDetailRepository OrderDetail { get; }

        IOrderHeaderRepository OrderHeader { get; }

        IApplicationUserRepository ApplicationUser { get; }
        void Save();
    }
}

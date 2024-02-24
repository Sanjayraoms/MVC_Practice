using MVCCompleteTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCompleteTutorial.DataAccess.Repository.IRepository
{
    public interface IcategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}

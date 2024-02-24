using Microsoft.AspNetCore.Mvc;
using MVCCompleteTutorial.DataAccess.Repository.IRepository;
using MVCCompleteTutorial.Models.Models;

namespace MVCCompleteTutorial.Areas.Company.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var companies = _unitOfWork.Company.GetAll();
            return View(companies);
        }
    }
}

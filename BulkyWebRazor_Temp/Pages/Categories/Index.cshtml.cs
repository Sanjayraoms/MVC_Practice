using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _applicationContext;
        public List<Category> CategoryList { get; set; }

        public IndexModel(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public void OnGet()
        {
        }
    }
}

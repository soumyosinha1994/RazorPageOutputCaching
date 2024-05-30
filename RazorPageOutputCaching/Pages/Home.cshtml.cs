using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.OutputCaching;
using RazorPageOutputCaching.Data;
using RazorPageOutputCaching.Model;

namespace RazorPageOutputCaching.Pages
{
    public class HomeModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Employee> employees { get; set; }
        public HomeModel(ApplicationDbContext? context)
        {
            _context = context;
        }
        [OutputCache(Duration = 360)]
        public void OnGet()
        {
            employees = _context.Employees.ToList();
        }
    }
}

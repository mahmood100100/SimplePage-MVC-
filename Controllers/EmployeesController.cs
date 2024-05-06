using Microsoft.AspNetCore.Mvc;
using SimplePage.Data;

namespace SimplePage.Controllers
{
    public class EmployeesController : Controller
    {
        AplicationDbContext context = new AplicationDbContext();

        public IActionResult Index()
        {
            var employees = context.Employees.ToList();
            return View("Index" , employees);
        }
    }
}

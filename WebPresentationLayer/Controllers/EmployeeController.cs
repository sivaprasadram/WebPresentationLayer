using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IServices;
using ViewModels.ViewModels;

namespace WebPresentationLayer.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeService  employeeService;

        public EmployeeController(IEmployeeService _employeeService)
        {
            employeeService = _employeeService; 
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeeViewModel employeeViewModel)
        {
            employeeService.AddEmployee(employeeViewModel);


            return View();
        }

    }
}

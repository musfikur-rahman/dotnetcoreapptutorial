using Microsoft.AspNetCore.Mvc;
using dotnetcoreapptutorial.Models;

namespace dotnetcoreapptutorial.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }

        public ViewResult Details()
        {
            Employee employee = _employeeRepository.GetEmployee(1);
            return View(employee);
        }
    }
}

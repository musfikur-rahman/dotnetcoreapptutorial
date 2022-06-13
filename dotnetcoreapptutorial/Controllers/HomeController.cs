using Microsoft.AspNetCore.Mvc;
using dotnetcoreapptutorial.Models;
using dotnetcoreapptutorial.ViewModels;

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
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(2),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }
    }
}

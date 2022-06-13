using System.Collections.Generic;
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

        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
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

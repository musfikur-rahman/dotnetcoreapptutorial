﻿using System.Collections.Generic;
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

        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }

        public ViewResult Create()
        {
            return View();
        }
    }
}

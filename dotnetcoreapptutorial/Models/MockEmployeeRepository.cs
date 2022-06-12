using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreapptutorial.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Hridoy", Department = "Welding", Email = "hridoy@email.com" },
                new Employee() { Id = 2, Name = "Rashed", Department = "Furniture", Email = "rashed@email.com" },
                new Employee() { Id = 3, Name = "Nirob", Department = "Sales", Email = "nirob@email.com" },
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}

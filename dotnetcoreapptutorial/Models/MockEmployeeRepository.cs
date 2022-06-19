using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreapptutorial.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Horrid", Department = Dept.HR, Email = "horrid@email.com" },
                new Employee() { Id = 2, Name = "Trashed", Department = Dept.IT, Email = "trashed@email.com" },
                new Employee() { Id = 3, Name = "Nirvana", Department = Dept.Payroll, Email = "nirvana@email.com" },
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}

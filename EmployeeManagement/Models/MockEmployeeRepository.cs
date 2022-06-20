using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
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
                new Employee() { Id = 4, Name = "Rose", Department = Dept.IT, Email = "rose@email.com" },
                new Employee() { Id = 5, Name = "Mufti", Department = Dept.Payroll, Email = "mufti@email.com" }
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id + 1);
            _employeeList.Add(employee);
            return employee;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}

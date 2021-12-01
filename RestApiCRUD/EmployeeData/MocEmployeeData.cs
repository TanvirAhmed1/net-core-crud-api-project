using RestApiCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCRUD.EmployeeData
{
    public class MocEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>(){
            new Employee(){
            Id = Guid.NewGuid(),
            Name = "Tanvir Ahmed"
            },
            new Employee(){
            Id = Guid.NewGuid(),
            Name = "Afroza Parvin"
            }
        };
        public void DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee EditEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee SetEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiCRUD.EmployeeData;
using RestApiCRUD.Model;

namespace RestApiCRUD.Controllers
{
    
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeData _employee;
        public EmployeesController(IEmployeeData employee)
        {
            _employee = employee;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return Ok(_employee.GetEmployees());
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployee(Guid id)
        {
            var employee = _employee.GetEmployee(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound($"Employee with id: {id} was not found");
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddEmployee(Employee employee)
        {
            _employee.SetEmployee(employee);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.Id,
                employee);
        }
    }
}

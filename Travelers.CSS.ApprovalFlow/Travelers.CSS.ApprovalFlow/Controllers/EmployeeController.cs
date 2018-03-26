using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travelers.CSS.ApprovalFlow.Domain.Interfaces;
using Travelers.CSS.ApprovalFlow.Models;

namespace Travelers.CSS.ApprovalFlow.Controllers
{
    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        IEmployeeDomainService _employeeDomainService;

        public EmployeeController(IEmployeeDomainService employeeDomainService)
        {
            _employeeDomainService = employeeDomainService;
        }

        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> GetEmployee()
        {
            return _employeeDomainService.GetAllEmployees();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            return _employeeDomainService.GetEmployeeById(id);
        }
        
        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody]Employee employee)
        {
            _employeeDomainService.AddEmployee(employee);
        }
        
        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Employee employee)
        {
            _employeeDomainService.UpdateEmployee(employee);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeDomainService.DeleteEmployee(id);
        }
    }
}

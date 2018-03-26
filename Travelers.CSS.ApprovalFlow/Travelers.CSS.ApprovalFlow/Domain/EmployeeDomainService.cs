using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travelers.CSS.ApprovalFlow.Domain.Interfaces;
using Travelers.CSS.ApprovalFlow.Models;
using Travelers.CSS.ApprovalFlow.Repositories.Interfaces;

namespace Travelers.CSS.ApprovalFlow.Domain
{
    public class EmployeeDomainService : IEmployeeDomainService
    {
        IUnitOfWork _unitOfWOrk;

        public EmployeeDomainService(IUnitOfWork unitOfWOrk)
        {
            _unitOfWOrk = unitOfWOrk;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _unitOfWOrk.Employees.GetAll();
        }

        public Employee GetEmployeeById(int empId)
        {
            return _unitOfWOrk.Employees.Get(empId);
        }

        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int empId)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}

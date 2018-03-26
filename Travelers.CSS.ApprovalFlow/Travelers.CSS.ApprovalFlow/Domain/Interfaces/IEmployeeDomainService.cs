using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travelers.CSS.ApprovalFlow.Models;

namespace Travelers.CSS.ApprovalFlow.Domain.Interfaces
{
    public interface IEmployeeDomainService
    {
        Employee GetEmployeeById(int empId);
        IEnumerable<Employee> GetAllEmployees();
        //IEnumerable<Employee> FindEmployee(Expression<Func<TEntity, bool>> predicate);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int empId);
    }
}

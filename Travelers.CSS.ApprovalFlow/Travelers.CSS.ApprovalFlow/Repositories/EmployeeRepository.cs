using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travelers.CSS.ApprovalFlow.DLL;
using Travelers.CSS.ApprovalFlow.Models;
using Travelers.CSS.ApprovalFlow.Repositories.Interfaces;

namespace Travelers.CSS.ApprovalFlow.Repositories
{
    public class EmployeeRepository : Repository<Employee> , IEmployeeRepository
    {
        public EmployeeRepository(ApprovalFlowDBContext context):base(context)
        {

        }
    }
}

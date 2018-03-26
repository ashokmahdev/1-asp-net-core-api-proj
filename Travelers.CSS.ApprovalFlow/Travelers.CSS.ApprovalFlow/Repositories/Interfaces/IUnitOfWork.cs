using System;

namespace Travelers.CSS.ApprovalFlow.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employees { get; }
        IApprovalRuleRepository ApprovalRules { get; }
        int Complete();
    }
}
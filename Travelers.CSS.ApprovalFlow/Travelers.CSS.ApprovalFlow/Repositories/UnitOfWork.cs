using Travelers.CSS.ApprovalFlow.DLL;
using Travelers.CSS.ApprovalFlow.Repositories.Interfaces;

namespace Travelers.CSS.ApprovalFlow.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApprovalFlowDBContext _context;

        public UnitOfWork(ApprovalFlowDBContext context)
        {
            _context = context;
            Employees = new EmployeeRepository(_context);
            ApprovalRules = new ApprovalRuleRepository(_context);
        }


        public IEmployeeRepository Employees { get; private set; }

        public IApprovalRuleRepository ApprovalRules { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
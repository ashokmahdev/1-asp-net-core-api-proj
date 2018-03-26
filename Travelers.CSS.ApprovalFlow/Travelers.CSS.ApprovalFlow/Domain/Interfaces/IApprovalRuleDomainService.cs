using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travelers.CSS.ApprovalFlow.Models;

namespace Travelers.CSS.ApprovalFlow.Domain.Interfaces
{
    public interface IApprovalRuleDomainService
    {
        ApprovalRule GetApprovalRuleById(int ruleId);
        IEnumerable<ApprovalRule> GetAllApprovalRules();
        //IEnumerable<Employee> FindRule(Expression<Func<TEntity, bool>> predicate);
        void AddRule(ApprovalRule approvalRule);
        void UpdateRule(ApprovalRule approvalRule);
        void DeleteRule(int ruleId);
    }
}

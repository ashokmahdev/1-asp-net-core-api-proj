using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travelers.CSS.ApprovalFlow.Domain.Interfaces;
using Travelers.CSS.ApprovalFlow.Models;
using Travelers.CSS.ApprovalFlow.Repositories.Interfaces;

namespace Travelers.CSS.ApprovalFlow.Domain
{
    public class ApprovalRuleDomainService : IApprovalRuleDomainService
    {
        IUnitOfWork _unitOfWOrk;

        public ApprovalRuleDomainService(IUnitOfWork unitOfWOrk)
        {
            _unitOfWOrk = unitOfWOrk;
        }

        public IEnumerable<ApprovalRule> GetAllApprovalRules()
        {
            return _unitOfWOrk.ApprovalRules.GetAll();
        }

        public ApprovalRule GetApprovalRuleById(int ruleId)
        {
            return _unitOfWOrk.ApprovalRules.Get(ruleId);
        }

        public void AddRule(ApprovalRule approvalRule)
        {
            throw new NotImplementedException();
        }

        public void DeleteRule(int ruleId)
        {
            throw new NotImplementedException();
        }

        public void UpdateRule(ApprovalRule approvalRule)
        {
            throw new NotImplementedException();
        }
    }
}

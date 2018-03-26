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
    [Route("api/ApprovalRule")]
    public class ApprovalRuleController : Controller
    {
        IApprovalRuleDomainService _approvalRuleDomainService;

        public ApprovalRuleController(IApprovalRuleDomainService approvalRuleDomainService)
        {
            _approvalRuleDomainService = approvalRuleDomainService;
        }

        // GET: api/ApprovalRule
        [HttpGet]
        public IEnumerable<ApprovalRule> GetApprovalRule()
        {
            return _approvalRuleDomainService.GetAllApprovalRules();
        }

        // GET: api/ApprovalRule/5
        [HttpGet("{id}")]
        public ApprovalRule Get(int id)
        {
            return _approvalRuleDomainService.GetApprovalRuleById(id);
        }
        
        // POST: api/ApprovalRule
        [HttpPost]
        public void Post([FromBody]ApprovalRule approvalRule)
        {
            _approvalRuleDomainService.AddRule(approvalRule);
        }
        
        // PUT: api/ApprovalRule/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]ApprovalRule approvalRule)
        {
            _approvalRuleDomainService.UpdateRule(approvalRule);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _approvalRuleDomainService.DeleteRule(id);
        }
    }
}

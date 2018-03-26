using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travelers.CSS.ApprovalFlow.Models;

namespace Travelers.CSS.ApprovalFlow.DLL
{
    public class ApprovalFlowDBContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ApprovalRule> ApprovalRules { get; set; }

        public ApprovalFlowDBContext(DbContextOptions<ApprovalFlowDBContext> options) : base(options)
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }
    }
}

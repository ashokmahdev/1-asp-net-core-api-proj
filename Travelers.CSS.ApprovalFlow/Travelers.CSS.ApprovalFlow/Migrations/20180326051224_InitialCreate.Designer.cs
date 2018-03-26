﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Travelers.CSS.ApprovalFlow.DLL;

namespace Travelers.CSS.ApprovalFlow.Migrations
{
    [DbContext(typeof(ApprovalFlowDBContext))]
    [Migration("20180326051224_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Travelers.CSS.ApprovalFlow.Models.ApprovalRule", b =>
                {
                    b.Property<int>("ApprovalRuleId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HierarchyId");

                    b.HasKey("ApprovalRuleId");

                    b.ToTable("ApprovalRules");
                });

            modelBuilder.Entity("Travelers.CSS.ApprovalFlow.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ntic");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}

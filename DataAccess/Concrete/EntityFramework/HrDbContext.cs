using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace DataAccess.Concrete.EntityFramework
{
    public class HrDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=toall.database.windows.net;Initial Catalog=HRWebDb;User ID=furkanhakan;Password=toall123.;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            //Database = HRWebDb
            //Data Source=DESKTOP-PE0VBS8;Database = HRWebDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            //Data Source = toall.database.windows.net; Initial Catalog = HRWebDb; User ID = furkanhakan; Password = toall123.; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        public DbSet<RequestApprovalStatus> RequestApprovalStatuses { get; set; }

        public DbSet<VocationLeaveType> VocationLeaveTypes { get; set; }

        public DbSet<VocationLeaveRequest> VocationLeaveRequests { get; set; }

        public DbSet<SpendingRequest> SpendingRequests { get; set; }

        public DbSet<AdvanceRequest> AdvanceRequests { get; set; }

        public DbSet<Firm> Firms { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}

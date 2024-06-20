using Microsoft.EntityFrameworkCore;
using SercomApp.Models;
namespace SercomApp.Data;

public class SercomDb : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<JobRole> JobRoles { get; set; }
    public DbSet<EmployeeContract> EmployeeContracts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Resource> Resources { get; set; }
    public DbSet<RolePermissionPatent> RolePermissionPatents { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<DailySchedule> DailySchedules { get; set; }
    public DbSet<Salary> Salaries { get; set; }
    public DbSet<ExtraCompensation> ExtraCompensations { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
    public DbSet<Ticket> Tickets { get; set; } 
    public DbSet<TicketEntry> TicketEntries { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<BusinessLine> BusinessLines { get; set; }
    public DbSet<CompanyContract> CompanyContracts { get; set; }
    public DbSet<PRTGProbe> PRTGProbes { get; set; }
    public DbSet<SalaryAllocation> SalaryAllocations { get; set; }
    public SercomDb(DbContextOptions<SercomDb> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Employee configurations
        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Department)
            .WithMany(d => d.Employees)
            .HasForeignKey(e => e.DepartmentId);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Schedule)
            .WithMany(s => s.Employees)
            .HasForeignKey(e => e.ScheduleId);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.User)
            .WithMany(u => u.Employees)
            .HasForeignKey(e => e.UserId);

        // EmployeeContract configurations
        modelBuilder.Entity<EmployeeContract>()
            .HasOne(ec => ec.Employee)
            .WithMany(e => e.EmployeeContracts)
            .HasForeignKey(ec => ec.EmployeeId);

        modelBuilder.Entity<EmployeeContract>()
            .HasOne(ec => ec.JobRole)
            .WithMany(jr => jr.EmployeeContracts)
            .HasForeignKey(ec => ec.JobRoleId);

        // DailySchedule configurations
        modelBuilder.Entity<DailySchedule>()
            .HasOne(ds => ds.Employee)
            .WithMany(e => e.DailySchedules)
            .HasForeignKey(ds => ds.EmployeeId);

        modelBuilder.Entity<DailySchedule>()
            .HasOne(ds => ds.Schedule)
            .WithMany(s => s.DailySchedules)
            .HasForeignKey(ds => ds.ScheduleId);

        // Salary configurations
        modelBuilder.Entity<Salary>()
            .HasOne(s => s.EmployeeContract)
            .WithMany(ec => ec.Salaries)
            .HasForeignKey(s => s.EmployeeContractId);

        // ExtraCompensation configurations
        modelBuilder.Entity<ExtraCompensation>()
            .HasOne(ec => ec.Salary)
            .WithMany(s => s.ExtraCompensations)
            .HasForeignKey(ec => ec.SalaryId);

        // EmployeeAddress configurations
        modelBuilder.Entity<EmployeeAddress>()
            .HasKey(ea => new { ea.EmployeeId, ea.AddressId });

        modelBuilder.Entity<EmployeeAddress>()
            .HasOne(ea => ea.Employee)
            .WithMany(e => e.EmployeeAddresses)
            .HasForeignKey(ea => ea.EmployeeId);

        modelBuilder.Entity<EmployeeAddress>()
            .HasOne(ea => ea.Address)
            .WithMany(a => a.EmployeeAddresses)
            .HasForeignKey(ea => ea.AddressId);

        // TicketEntries configurations
        modelBuilder.Entity<TicketEntry>()
            .HasOne(te => te.Employee)
            .WithMany(e => e.TicketEntries)
            .HasForeignKey(te => te.EmployeeId);

        modelBuilder.Entity<TicketEntry>()
            .HasOne(te => te.Ticket)
            .WithMany(t => t.TicketEntries)
            .HasForeignKey(te => te.TicketId);

        modelBuilder.Entity<TicketEntry>()
            .HasOne(te => te.SalaryAllocation)
            .WithMany(sa => sa.TicketEntries)
            .HasForeignKey(te => te.SalaryAllocationId);

        // CompanyContract configurations
        modelBuilder.Entity<CompanyContract>()
            .HasOne(cc => cc.Company)
            .WithMany(c => c.CompanyContracts)
            .HasForeignKey(cc => cc.CompanyId);

        modelBuilder.Entity<CompanyContract>()
            .HasOne(cc => cc.BusinessLine)
            .WithMany(bl => bl.CompanyContracts)
            .HasForeignKey(cc => cc.BusinessLineId);

        // PRTGProbe configurations
        modelBuilder.Entity<PRTGProbe>()
            .HasOne(pp => pp.Company)
            .WithMany(c => c.PRTGProbes)
            .HasForeignKey(pp => pp.CompanyId);

        // SalaryAllocation configurations
        modelBuilder.Entity<SalaryAllocation>()
            .HasOne(sa => sa.Salary)
            .WithMany(s => s.SalaryAllocations)
            .HasForeignKey(sa => sa.SalaryId);

        modelBuilder.Entity<SalaryAllocation>()
            .HasOne(sa => sa.BusinessLine)
            .WithMany(bl => bl.SalaryAllocations)
            .HasForeignKey(sa => sa.BusinessLineId);

        // RolePermissionPatent configurations
        modelBuilder.Entity<RolePermissionPatent>()
            .HasKey(rpp => new { rpp.RoleId, rpp.ResourceId, rpp.PermissionName });

        modelBuilder.Entity<RolePermissionPatent>()
            .HasOne(rpp => rpp.Role)
            .WithMany(r => r.RolePermissionPatents)
            .HasForeignKey(rpp => rpp.RoleId);

        modelBuilder.Entity<RolePermissionPatent>()
            .HasOne(rpp => rpp.Resource)
            .WithMany(r => r.RolePermissionPatents)
            .HasForeignKey(rpp => rpp.ResourceId);

        modelBuilder.Entity<RolePermissionPatent>()
            .HasOne(rpp => rpp.Permission)
            .WithMany(p => p.RolePermissionPatents)
            .HasForeignKey(rpp => rpp.PermissionName);

        // Additional configurations for other entities

        // User configurations
        modelBuilder.Entity<User>()
            .HasOne(u => u.Role)
            .WithMany(r => r.Users)
            .HasForeignKey(u => u.RoleId);

        // Role configurations
        modelBuilder.Entity<Role>()
            .HasMany(r => r.Users)
            .WithOne(u => u.Role)
            .HasForeignKey(u => u.RoleId);

        // Permission configurations
        modelBuilder.Entity<Permission>()
            .HasMany(p => p.RolePermissionPatents)
            .WithOne(rpp => rpp.Permission)
            .HasForeignKey(rpp => rpp.PermissionName);

        // Resource configurations
        modelBuilder.Entity<Resource>()
            .HasMany(r => r.RolePermissionPatents)
            .WithOne(rpp => rpp.Resource)
            .HasForeignKey(rpp => rpp.ResourceId);

        // Schedule configurations
        modelBuilder.Entity<Schedule>()
            .HasMany(s => s.Employees)
            .WithOne(e => e.Schedule)
            .HasForeignKey(e => e.ScheduleId);

        modelBuilder.Entity<Schedule>()
            .HasMany(s => s.DailySchedules)
            .WithOne(ds => ds.Schedule)
            .HasForeignKey(ds => ds.ScheduleId);

        // Address configurations
        modelBuilder.Entity<Address>()
            .HasMany(a => a.EmployeeAddresses)
            .WithOne(ea => ea.Address)
            .HasForeignKey(ea => ea.AddressId);

        modelBuilder.Entity<Address>()
            .HasOne(a => a.Company)
            .WithMany(c => c.Addresses)
            .HasForeignKey(a => a.CompanyId);

        // Tickets configurations
        modelBuilder.Entity<Ticket>()
            .HasMany(t => t.TicketEntries)
            .WithOne(te => te.Ticket)
            .HasForeignKey(te => te.TicketId);

        modelBuilder.Entity<Ticket>()
            .HasOne(t => t.BusinessLine)
            .WithMany(bl => bl.Tickets)
            .HasForeignKey(t => t.BusinessLineId);

        modelBuilder.Entity<Ticket>()
            .HasOne(t => t.Company)
            .WithMany(c => c.Tickets)
            .HasForeignKey(t => t.CompanyId);

        // Company configurations
        modelBuilder.Entity<Company>()
            .HasMany(c => c.CompanyContracts)
            .WithOne(cc => cc.Company)
            .HasForeignKey(cc => cc.CompanyId);

        modelBuilder.Entity<Company>()
            .HasMany(c => c.PRTGProbes)
            .WithOne(pp => pp.Company)
            .HasForeignKey(pp => pp.CompanyId);

        modelBuilder.Entity<Company>()
            .HasMany(c => c.Tickets)
            .WithOne(t => t.Company)
            .HasForeignKey(t => t.CompanyId);

        modelBuilder.Entity<Company>()
            .HasMany(c => c.Addresses)
            .WithOne(a => a.Company)
            .HasForeignKey(a => a.CompanyId);

        // BusinessLine configurations
        modelBuilder.Entity<BusinessLine>()
            .HasMany(bl => bl.Tickets)
            .WithOne(t => t.BusinessLine)
            .HasForeignKey(t => t.BusinessLineId);

        modelBuilder.Entity<BusinessLine>()
            .HasMany(bl => bl.CompanyContracts)
            .WithOne(cc => cc.BusinessLine)
            .HasForeignKey(cc => cc.BusinessLineId);

        modelBuilder.Entity<BusinessLine>()
            .HasMany(bl => bl.SalaryAllocations)
            .WithOne(sa => sa.BusinessLine)
            .HasForeignKey(sa => sa.BusinessLineId);

        base.OnModelCreating(modelBuilder);
    }
}



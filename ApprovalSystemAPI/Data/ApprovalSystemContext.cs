// Data/ApprovalSystemContext.cs
using Microsoft.EntityFrameworkCore;
using ApprovalSystemAPI.Models;

public class ApprovalSystemContext : DbContext
{
    public ApprovalSystemContext(DbContextOptions<ApprovalSystemContext> options) : base(options) { }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<RequestStatus> RequestStatuses { get; set; }
    public DbSet<ApprovalLevel> ApprovalLevels { get; set; }
    public DbSet<ApprovalType> ApprovalTypes { get; set; }
    public DbSet<Request> Requests { get; set; }
    public DbSet<RequestStep> RequestSteps { get; set; }
    public DbSet<RequestApproval> RequestApprovals { get; set; }
    public DbSet<ScenarioApproval> ScenarioApprovals { get; set; }
    public DbSet<RequestCase> RequestCases { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>()
            .HasMany(e => e.Subordinates)
            .WithOne(e => e.Manager)
            .HasForeignKey(e => e.ManagerId);

        modelBuilder.Entity<Request>()
            .HasOne(r => r.PreviousStep)
            .WithMany()
            .HasForeignKey(r => r.PreviousStepId);

        modelBuilder.Entity<Request>()
            .HasOne(r => r.CurrentStep)
            .WithMany()
            .HasForeignKey(r => r.CurrentStepId);

        modelBuilder.Entity<RequestStep>()
            .HasOne(rs => rs.CompletedByEmployee)
            .WithMany()
            .HasForeignKey(rs => rs.CompletedBy);
    }
}

using Microsoft.EntityFrameworkCore;
using RegistaMaster.Domain.Entities;
using RegistaMaster.Persistance.Seeds;
using Action = RegistaMaster.Domain.Entities.Action;
using Version = RegistaMaster.Domain.Entities.Version;

namespace RegistaMaster.Persistance.RegistaMasterContextes;

public class RegistaMasterContext : DbContext
{
  public RegistaMasterContext(DbContextOptions options) : base(options)
  {

  }
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfiguration(new ManagerUserConfiguration());
    modelBuilder.ApplyConfiguration(new CustomerConfiguration());
    base.OnModelCreating(modelBuilder);
  }


  public DbSet<Customer> Customers { get; set; }
  public DbSet<User> Users { get; set; }
  public DbSet<Project> Projects { get; set; }
  public DbSet<Action> Actions { get; set; }
  public DbSet<ProjectNote> ProjectNotes { get; set; }
  public DbSet<Request> Requests { get; set; }
  public DbSet<Module> Modules { get; set; }
  public DbSet<Version> Versions { get; set; }
  public DbSet<UserLog> UserLogs { get; set; }
  public DbSet<ErrorLog> ErrorLogs { get; set; }
  public DbSet<HealthCheck> HealthChecks { get; set; }
  public DbSet<ActionNote> ActionNotes { get; set; }
  public DbSet<FoodChart> FoodCharts { get; set; }
  public DbSet<RequestFile> RequestFiles { get; set; }

}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistaMaster.Domain.Entities;

namespace RegistaMaster.Persistance.Seeds;

public class ManagerUserConfiguration : IEntityTypeConfiguration<User>
{
  public void Configure(EntityTypeBuilder<User> builder)
  {
    builder.HasData(new User
    {
      Id = 1,
      Name = "Admin",
      UserName ="Admin",
      SurName = "Admin",
      Image = "-",
      Email = "Admin@Admin.com",
      Password = "123",
      AuthorizationStatus = Domain.Enums.AuthorizationStatus.Admin,
      CustomerId = 1,
      CreatedOn = DateTime.Now,
      LastModifiedOn = DateTime.Now,
      CreatedBy = 1,
      LastModifiedBy = 1,
      ObjectStatus = Domain.Enums.ObjectStatus.NonDeleted,
      Status = Domain.Enums.Status.Active
    });
    builder.HasData(new User
    {
      Id = 2,
      Name = "TeamLeader",
      UserName = "TeamLeader",
      SurName = "TeamLeader",
      Image = "-",
      Email = "TeamLeader@TeamLeader.com",
      Password = "123",
      AuthorizationStatus = Domain.Enums.AuthorizationStatus.Admin,
      CustomerId = 1,
      CreatedOn = DateTime.Now,
      LastModifiedOn = DateTime.Now,
      CreatedBy = 1,
      LastModifiedBy = 1,
      ObjectStatus = Domain.Enums.ObjectStatus.NonDeleted,
      Status = Domain.Enums.Status.Active
    });
    builder.HasData(new User
    {
      Id = 3,
      Name = "Developer",
      UserName = "Developer",
      SurName = "Developer",
      Image = "-",
      Email = "Developer@Developer.com",
      Password = "123",
      AuthorizationStatus = Domain.Enums.AuthorizationStatus.Admin,
      CustomerId = 1,
      CreatedOn = DateTime.Now,
      LastModifiedOn = DateTime.Now,
      CreatedBy = 1,
      LastModifiedBy = 1,
      ObjectStatus = Domain.Enums.ObjectStatus.NonDeleted,
      Status = Domain.Enums.Status.Active
    });
  }
}


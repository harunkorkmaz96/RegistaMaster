using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistaMaster.Domain.Entities;

namespace RegistaMaster.Persistance.Seeds;

public class ManagerUserConfiguration : IEntityTypeConfiguration<User>
{
  public void Configure(EntityTypeBuilder<User> builder) => builder.HasData(new User
  {
    Id = 1,
    Name = "Admin",
    SurName = "Admin",
    Image = "-",
    Email = "admin@admin.com",
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


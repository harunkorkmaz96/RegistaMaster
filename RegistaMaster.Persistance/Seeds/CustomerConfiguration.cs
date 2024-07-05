using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistaMaster.Domain.Entities;

namespace RegistaMaster.Persistance.Seeds;

public class CustomerConfiguration: IEntityTypeConfiguration<Customer>
{
  public void Configure(EntityTypeBuilder<Customer> builder)
  {
    builder.HasData(new Customer
    {
      Id = 1,
      Name = "Customer",
      Adress = "-",
      Email = "customer@customer.com",
      ApiKey = "-",
      CustomerDescriptionId = 1,
      CreatedOn = DateTime.Now,
      LastModifiedOn = DateTime.Now,
      CreatedBy = 1,
      LastModifiedBy = 1,
      ObjectStatus = Domain.Enums.ObjectStatus.NonDeleted,
      Status = Domain.Enums.Status.Active
    });
  }
}

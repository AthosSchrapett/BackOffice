using BackOfficeApi.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackOfficeApi.Data.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");

            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar(150)");

            builder.HasOne(e => e.NaturalPerson).WithMany(x => x.Departments).HasForeignKey(x => x.NaturalPersonId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}

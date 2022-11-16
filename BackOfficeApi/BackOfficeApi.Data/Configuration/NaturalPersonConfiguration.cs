using BackOfficeApi.Model.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackOfficeApi.Data.Configuration
{
    public class NaturalPersonConfiguration : IEntityTypeConfiguration<NaturalPerson>
    {
        public void Configure(EntityTypeBuilder<NaturalPerson> builder)
        {
            builder.ToTable("NaturalPersons");

            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Cep).IsRequired().HasColumnType("varchar(8)");
            builder.Property(x => x.Number).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Address).IsRequired().HasColumnType("varchar(300)");
            builder.Property(x => x.Complement).HasColumnType("varchar(100)");
            builder.Property(x => x.Bairro).HasColumnType("varchar(100)");
            builder.Property(x => x.Cidade).HasColumnType("varchar(100)");
            builder.Property(x => x.Uf).HasColumnType("varchar(100)");
            builder.Property(x => x.Cpf).IsRequired().HasColumnType("varchar(11)");
            builder.Property(x => x.Nickname).IsRequired().HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt);
            builder.Property(x => x.Qualification).IsRequired();
        }
    }
}

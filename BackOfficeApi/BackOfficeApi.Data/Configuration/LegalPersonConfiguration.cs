using BackOfficeApi.Model.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackOfficeApi.Data.Configuration
{
    public class LegalPersonConfiguration : IEntityTypeConfiguration<LegalPerson>
    {
        public void Configure(EntityTypeBuilder<LegalPerson> builder)
        {
            builder.ToTable("LegalPersons");

            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar(150)");
            builder.Property(x => x.Cep).IsRequired().HasColumnType("varchar(8)");
            builder.Property(x => x.Number).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Address).IsRequired().HasColumnType("varchar(300)");
            builder.Property(x => x.Complement).HasColumnType("varchar(100)");
            builder.Property(x => x.Bairro).HasColumnType("varchar(100)");
            builder.Property(x => x.Cidade).HasColumnType("varchar(100)");
            builder.Property(x => x.Uf).HasColumnType("varchar(100)");
            builder.Property(x => x.Cnpj).IsRequired().HasColumnType("varchar(14)");
            builder.Property(x => x.TradeName).IsRequired().HasColumnType("varchar(150)");
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt);
            builder.Property(x => x.Qualification).IsRequired();
        }
    }
}

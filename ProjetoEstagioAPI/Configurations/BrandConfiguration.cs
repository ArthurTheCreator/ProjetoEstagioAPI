using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstagioAPI.Models;

namespace ProjetoEstagioAPI.Configurations;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("marca");

        builder.HasKey(b => b.Id);

        builder.Property(b => b.Name).HasColumnName("nome")
            .IsRequired()
            .HasMaxLength(24);

        builder.Property(b => b.Code).HasColumnName("codigo")
            .IsRequired()
            .HasMaxLength(16);

        builder.Property(b => b.Description).HasColumnName("descricao")
            .IsRequired()
            .HasMaxLength(100);
    }
}
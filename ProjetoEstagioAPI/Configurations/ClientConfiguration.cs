﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstagioAPI.Models;

namespace ProjetoEstagioAPI.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("cliente");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name).HasColumnName("nome")
            .IsRequired()
            .HasMaxLength(64);

        builder.Property(c => c.Email).HasColumnName("email")
            .IsRequired()
            .HasMaxLength(32);

        builder.Property(c => c.Password).HasColumnName("senha")
            .IsRequired()
            .HasMaxLength(16);

        builder.Property(c => c.CPF).HasColumnName("cpf")
            .IsRequired()
            .HasMaxLength(11)
            .IsFixedLength();

        builder.Property(c => c.Phone).HasColumnName("telefone")
            .IsRequired()
            .HasMaxLength(11)
            .IsFixedLength();
    }
}
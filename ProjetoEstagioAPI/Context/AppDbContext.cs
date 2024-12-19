﻿using Microsoft.EntityFrameworkCore;
using ProjetoEstagioAPI.Models;

namespace ProjetoEstagioAPI.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<TEntity> GetDbSet<TEntity>() where TEntity : class
    {
        return Set<TEntity>();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClientConfiguration).Assembly);
    }
}
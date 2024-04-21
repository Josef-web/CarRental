﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class Context:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=ReCapProjectDb;Trusted_Connection=true;TrustServerCertificate=True");
    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Color> Colors { get; set; }
}
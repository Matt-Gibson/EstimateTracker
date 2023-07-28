using System;
using EstimateTracker.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EstimateTracter.Data;

public class EstimateDbContext:DbContext
{
	public EstimateDbContext(DbContextOptions opts):base(opts)
	{
        //Database.EnsureCreated();
	}

	public DbSet<Estimate> Estimates { get; set; }
}

public class EstimateDbContextFactory : IDesignTimeDbContextFactory<EstimateDbContext>
{
    public EstimateDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<EstimateDbContext>();
        optionsBuilder.UseSqlite("Data Source = ../myapp.db");

        return new EstimateDbContext(optionsBuilder.Options);
    }
}


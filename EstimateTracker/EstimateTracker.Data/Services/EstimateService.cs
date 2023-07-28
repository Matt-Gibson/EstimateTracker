using System;
using EstimateTracker.Data.Interfaces;
using EstimateTracker.Data.Models;
using EstimateTracter.Data;
using Microsoft.EntityFrameworkCore;

namespace EstimateTracker.Data.Services;

public class EstimateService:IEstimateService
{
    IDbContextFactory<EstimateDbContext> _dbContextFactory;

	public EstimateService(IDbContextFactory<EstimateDbContext> dbContextfactory)
	{
        _dbContextFactory = dbContextfactory;
	}

    public async Task DeleteEstimateAsync(Estimate estimate)
    {
        var ctx = _dbContextFactory.CreateDbContext();
        ctx.Remove(estimate);
        await ctx.SaveChangesAsync();
    }

    public async Task<Estimate?> GetEstimateByIdAsync(string id)
    {
        var ctx = _dbContextFactory.CreateDbContext();
        return await ctx.Estimates.Where(e => e.Id == id).FirstOrDefaultAsync<Estimate>();
        
    }

    public async Task<List<Estimate>?> GetEstimatesAsync()
    {
        var ctx = _dbContextFactory.CreateDbContext();
        return await ctx.Estimates.ToListAsync<Estimate>();

    }

    public async Task<Estimate?> SaveEstimateAsync(Estimate estimate)
    {
        var ctx = _dbContextFactory.CreateDbContext();

        if(estimate.Id == "")
        {
            estimate.Id = Guid.NewGuid().ToString();
            await ctx.AddAsync(estimate);
        }
        else
        {
            ctx.Entry<Estimate>(estimate).State = EntityState.Modified;
        }
        
        await ctx.SaveChangesAsync();
        return estimate;
    }
}


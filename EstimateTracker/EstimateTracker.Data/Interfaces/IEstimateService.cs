using EstimateTracker.Data.Models;

namespace EstimateTracker.Data.Interfaces;

public interface IEstimateService
{
    Task<List<Estimate>?> GetEstimatesAsync();
    Task<Estimate?> GetEstimateByIdAsync(string id);
    Task<Estimate?> SaveEstimateAsync(Estimate estimate);
    Task DeleteEstimateAsync(Estimate estimate);
}


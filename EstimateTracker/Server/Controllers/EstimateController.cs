using EstimateTracker.Data.Interfaces;
using EstimateTracker.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstimateTracker.Server.Controllers
{
    [Route("api/[controller]")]
    public class EstimateController : ControllerBase
    {
        private IEstimateService _estimateService;

        public EstimateController(IEstimateService estimateService)
        {
            _estimateService = estimateService;

        }

        // GET: api/Estimate
        [HttpGet]
        public async Task<IEnumerable<Estimate>?> GetAsync()
        {
            return await _estimateService.GetEstimatesAsync();
        }

        // GET api/Estimate/id
        [HttpGet("{id}")]
        public async Task<Estimate?> Get(string id)
        {
            return await _estimateService.GetEstimateByIdAsync(id);
        }

        // POST api/Estimate
        [HttpPost]
        public async Task Post([FromBody]Estimate estimate)
        {
            await _estimateService.SaveEstimateAsync(estimate);
        }

        // PUT api/Estimate
        [HttpPut]
        public async Task Put([FromBody]Estimate estimate)
        {
            await _estimateService.SaveEstimateAsync(estimate);
        }

        // DELETE api/Estimate/id
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            var estimate = await _estimateService.GetEstimateByIdAsync(id);
            await _estimateService.DeleteEstimateAsync(estimate!);
        }
    }
}


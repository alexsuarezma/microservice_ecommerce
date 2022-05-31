using Identity.Persistence.Database;
using Identity.Service.Queries.DTOs;
using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;
using Service.Common.Paging;
using Service.Common.Mapping;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Service.Queries
{
    public interface IClaimQueryService
    {
        Task<DataCollection<ClaimDto>> GetAllAsync(int page, int take, IEnumerable<string> claims = null);
        Task<ClaimDto> GetAsync(string id);
    }
    public class ClaimQueryService : IClaimQueryService
    {
        private readonly ApplicationDbContext _context;

        public ClaimQueryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DataCollection<ClaimDto>> GetAllAsync(int page, int take, IEnumerable<string> claims = null)
        {
            var collection = await _context.ApplicationClaims
                                    .Where(x => claims == null || claims.Contains(x.Id))
                                    .OrderBy(x => x.Name)
                                    .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<ClaimDto>>();
        }

        public async Task<ClaimDto> GetAsync(string id)
        {
            return (await _context.ApplicationClaims.SingleAsync(x => x.Id == id)).MapTo<ClaimDto>();
        }
    }
}

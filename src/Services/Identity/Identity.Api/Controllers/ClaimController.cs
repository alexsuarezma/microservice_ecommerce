using Identity.Service.Queries;
using Identity.Service.Queries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Common.Collection;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Identity.Api.Controllers
{
    [EnableCors("MyPolicy")]
    [ApiController]
    [Route("v1/claim")]
    public class ClaimController : ControllerBase
    {
        private readonly ILogger<ClaimController> _logger;
        private readonly IMediator _mediator;
        private readonly IClaimQueryService _claimQueryService;
        public ClaimController(
            ILogger<ClaimController> logger,
            IMediator mediator,
            IClaimQueryService claimQueryService)
        {
            _logger = logger;
            _mediator = mediator;
            _claimQueryService = claimQueryService;
        }

        [HttpGet]
        public async Task<DataCollection<ClaimDto>> GetAll(int page = 1, int take = 10, string ids = null)
        {
            IEnumerable<string> claims = ids?.Split(',');
            return await _claimQueryService.GetAllAsync(page, take, claims);
        }

        [HttpGet("{id}")]
        public async Task<ClaimDto> Get(string id)
        {
            return await _claimQueryService.GetAsync(id);
        }

        //GetAllClaimToUser
        //GetClaimToUser
        //removeClaimToUser
        //agregateClaimToUser
    }
}

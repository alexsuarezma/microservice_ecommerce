using Identity.Domain;
using Identity.Service.EventHandler.Commands;
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
    [Route("v1/role")]
    public class RoleController : ControllerBase
    {
        private readonly ILogger<RoleController> _logger;
        private readonly IMediator _mediator;
        private readonly IRoleQueryService _roleQueryService;

        public RoleController(
            ILogger<RoleController> logger,
            IMediator mediator,
            IRoleQueryService roleQueryService)
        {
            _logger = logger;
            _mediator = mediator;
            _roleQueryService = roleQueryService;
        }

        [HttpPost("agregate/claim")]
        public async Task<IActionResult> AgregateClaimsInRole(ActionClaimsInRoleCommand command)
        {
            command.action = 0;
            await _mediator.Publish(command);
            return Ok();
        }

        [HttpPost("remove/claim")]
        public async Task<IActionResult> RemoveClaimsInRole(ActionClaimsInRoleCommand command)
        {
            command.action = (Common.Enums.AgregateRemoveAction)1;
            await _mediator.Publish(command);
            return Ok();
        }

        [HttpPost("agregate/user")]
        public async Task<IActionResult> AgregateUserInRole(ActionUsersInRoleCommand command)
        {
            command.action = 0;
            await _mediator.Publish(command);
            return Ok();
        }
        [HttpPost("remove/user")]
        public async Task<IActionResult> RemoveUserInRole(ActionUsersInRoleCommand command)
        {
            command.action = (Common.Enums.AgregateRemoveAction)1;
            await _mediator.Publish(command);
            return Ok();
        }

        [HttpGet]
        public async Task<DataCollection<RoleDto>> GetAll(int page = 1, int take = 10, string ids = null)
        {
            IEnumerable<string> roles = ids?.Split(',');
            return await _roleQueryService.GetAllAsync(page, take, roles);

        }

        [HttpGet("{id}")]
        public async Task<ApplicationRole> Get(string id)
        {
            return await _roleQueryService.GetAsync(id);
        }

        [HttpGet("{id}/users")]
        public async Task<RoleDto> GetUsersWithRole(string id)
        {
            return await _roleQueryService.GetUsersWithRoleAsync(id);
        }

        [HttpGet("users")]
        public async Task<DataCollection<RoleDto>> GetUsersWithRoles(int page = 1, int take = 10, string ids = null)
        {
            IEnumerable<string> roles = ids?.Split(',');
            return await _roleQueryService.GetUsersWithRolesAsync(page, take, roles);
        }

    }
}

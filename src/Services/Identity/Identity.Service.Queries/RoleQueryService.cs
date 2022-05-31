using Identity.Domain;
using Identity.Persistence.Database;
using Identity.Service.Queries.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;
using Service.Common.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Text.Json;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Service.Common.Mapping;

namespace Identity.Service.Queries
{
    public interface IRoleQueryService
    {
        Task<DataCollection<RoleDto>> GetAllAsync(int page, int take, IEnumerable<string> claims = null);
        Task<ApplicationRole> GetAsync(string id);
        Task<RoleDto> GetUsersWithRoleAsync(string id);
        Task<DataCollection<RoleDto>> GetUsersWithRolesAsync(int page, int take, IEnumerable<string> ids = null);
    }
    public class RoleQueryService : IRoleQueryService
    {

        private readonly ApplicationDbContext _context;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public RoleQueryService(RoleManager<ApplicationRole> roleManager, ApplicationDbContext context)
        {
            _context = context;
            _roleManager = roleManager;
        }

        public async Task<DataCollection<RoleDto>> GetAllAsync(int page, int take, IEnumerable<string> roles = null)
        {
            var collection = await _context.Roles
                                .Where(x => roles == null || roles.Contains(x.Id))
                                .OrderBy(x => x.Name)
                                .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<RoleDto>>();
        }

        public async Task<ApplicationRole> GetAsync(string id)
        {
            return (await _context.Roles.SingleAsync(x => x.Id == id)).MapTo<ApplicationRole>();
        }

        public async Task<RoleDto> GetUsersWithRoleAsync(string id)
        {
            return (await _context.Roles.Include(x => x.UserRoles)
                        .ThenInclude(x => x.User).SingleAsync(x => x.Id == id)).MapTo<RoleDto>();
        }

        public async Task<DataCollection<RoleDto>> GetUsersWithRolesAsync(int page, int take, IEnumerable<string> ids = null)
        {
            var collection = await _context.Roles
                .Include(x => x.UserRoles)
                .ThenInclude(x => x.User)
                .Where(x => ids == null || ids.Contains(x.Id))
                .OrderBy(x => x.Name)
                .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<RoleDto>>();
        }
    }
}

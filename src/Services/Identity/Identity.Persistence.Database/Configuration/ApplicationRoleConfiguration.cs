using Identity.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Identity.Persistence.Database.Configuration
{
    class ApplicationRoleConfiguration
    {
        public ApplicationRoleConfiguration(EntityTypeBuilder<ApplicationRole> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);

            var roles = new List<ApplicationRole>();

            roles.Add(new ApplicationRole
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                Name = "Administrador",
                NormalizedName = "admin"
            });

            roles.Add(new ApplicationRole
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                Name = "Usuario",
                NormalizedName = "user"
            });

            roles.Add(new ApplicationRole
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                Name = "Super Administrador",
                NormalizedName = "super_admin"
            });

            entityBuilder.HasData(roles);

            entityBuilder.HasMany(e => e.UserRoles).WithOne(e => e.Role).HasForeignKey(e => e.RoleId).IsRequired();
        }
    }
}

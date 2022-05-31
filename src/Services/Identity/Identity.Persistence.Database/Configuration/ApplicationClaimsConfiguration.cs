using Identity.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Persistence.Database.Configuration
{
    class ApplicationClaimsConfiguration
    {
        public ApplicationClaimsConfiguration(EntityTypeBuilder<ApplicationClaims> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            var claims = new List<ApplicationClaims>();

            claims.Add(new ApplicationClaims
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                Name = "user.create"
            });

            claims.Add(new ApplicationClaims
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                Name = "user.update"
            });

            claims.Add(new ApplicationClaims
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                Name = "user.view"
            });

            claims.Add(new ApplicationClaims
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                Name = "user.delete"
            });

            entityBuilder.HasData(claims);
        }
    }
}

using Identity.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Identity.Persistence.Database.Configuration
{
    class ApplicationUserConfiguration
    {
        public ApplicationUserConfiguration(EntityTypeBuilder<ApplicationUser> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);

            entityBuilder.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            //entityBuilder.Property(x => x.Username).IsRequired().HasMaxLength(100);
            //entityBuilder.Property(x => x.Phone).IsRequired().HasMaxLength(100);
            //entityBuilder.Property(x => x.Address).IsRequired().HasMaxLength(100);
            //entityBuilder.Property(x => x.CompanyId).IsRequired().HasMaxLength(100);

            var adminRole = new ApplicationUserRole();

            entityBuilder.HasData(new ApplicationUser
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                FirstName = "Alex Aarón",
                LastName = "Suárez Macías",
                Email = "alexotrowe@gmail.com",
                UserName = "alsuarez"
            });

            entityBuilder.HasMany(e => e.UserRoles).WithOne(e => e.User).HasForeignKey(e => e.UserId).IsRequired();
        }
    }
}

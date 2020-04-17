using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace oSport.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Name = "League Admin",
                    NormalizedName = "LEAGUE Admin",
                },
                new IdentityRole
                {
                    Name = "Coach",
                    NormalizedName = "COACH",
                },
                new IdentityRole
                {
                    Name = "Referee",
                    NormalizedName = "REFEREE",
                },
                new IdentityRole
                {
                    Name = "Player",
                    NormalizedName = "PLAYER",
                }
                );
        }
    }
}

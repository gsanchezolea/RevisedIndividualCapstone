using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using oSport.Models;

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
                    NormalizedName = "LEAGUE ADMIN",
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
            builder.Entity<Sport>()
                .HasData(
                new Sport
                {
                    Id = 1,
                    Name = "Soccer"
                },
                new Sport
                {
                    Id = 2,
                    Name = "Football"
                },
                new Sport
                {
                    Id = 3,
                    Name = "Basketball"
                },
                new Sport
                {
                    Id = 4,
                    Name = "Hockey"
                },
                new Sport
                {
                    Id = 5,
                    Name = "Rugby"
                }
                );

        }


        public DbSet<LeagueAdmin> LeagueAdmins { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<League> Leagues { get; set; }
    }
}

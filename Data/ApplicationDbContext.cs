using Highscore.Models;
using Highscore.Models.Entities;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace Highscore.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<Game> Game { get; set; }

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var games = new List<Game>
            {
                new Game(1, "Tetris", "Lorem ipsum dolor", new Uri("http://via.placeholder.com/640x480.png?text=Tetris")),
                new Game(2, "Donkey Kong", "Lorem ipsum dolor", new Uri("http://via.placeholder.com/640x480.png?text=Donkey+Kong"))
            };

            games.ForEach(x => builder.Entity<Game>().HasData(x));
        }
    }
}

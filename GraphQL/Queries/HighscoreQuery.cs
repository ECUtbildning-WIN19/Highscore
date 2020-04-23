using GraphQL.Types;
using Highscore.Data;
using Highscore.GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Highscore.GraphQL.Queries
{
    public class HighscoreQuery : ObjectGraphType
    {
        public HighscoreQuery(ApplicationDbContext dbContext)
        {
            Field<ListGraphType<GameType>>(
                "games",
                resolve: context => dbContext.Game.ToList());
        }
    }
}

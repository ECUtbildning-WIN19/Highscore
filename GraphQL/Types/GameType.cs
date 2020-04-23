using GraphQL.Types;
using Highscore.Models.Entities;

namespace Highscore.GraphQL.Types
{
    public class GameType : ObjectGraphType<Game>
    {
        public GameType()
        {
            Field(t => t.Id);
            Field(t => t.Title);
            Field(t => t.Description);
            //Field(t => t.ImageUrl);
        }
    }
}

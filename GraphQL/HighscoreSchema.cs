using GraphQL;
using GraphQL.Types;
using Highscore.GraphQL.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Highscore.GraphQL
{
    public class HighscoreSchema : Schema
    {
        public HighscoreSchema(IDependencyResolver resolver)
        {
            Query = resolver.Resolve<HighscoreQuery>();
        }
    }
}

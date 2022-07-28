using System.Linq;
using GraphQLDotnet.Data;
using GraphQLDotnet.Models;
using HotChocolate;
using System.Collections.Generic;

namespace GraphQLDotnet.GraphQL
{
    public class Query
    {
        public List<Platform> GetPlatform()
        {
            var platforms = new List<Platform>()
            {
                new Platform{Id = 1, Name = ".Net 5"},
                new Platform{Id = 2, Name = "Windows"},
                new Platform{Id = 3, Name = "Docker"}
            };
            return platforms;
        }
    }
}
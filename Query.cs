using GraphQL;

namespace PokeAPI
{
    public class Query
    {
        [GraphQLMetadata("pokemon")]
        public Pokemon GetPokemon()
        {
            return new Pokemon { Id = "1", Name = "Pikachu" };
        }
    }
}
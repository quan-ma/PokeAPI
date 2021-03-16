using GraphQL;
using GraphQL.Types;

namespace PokeAPI
{
    public class Query : ObjectGraphType
    {
        public Query()
        {
            Field<PokemonType>
            (
                "pokemon",
                resolve: context => new Pokemon
                {
                    Id = "1",
                    Name = "Pikachu"
                }
            );
        }
    }
}
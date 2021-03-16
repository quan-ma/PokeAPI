using GraphQL.Types;

namespace PokeAPI
{
    public class PokemonType : ObjectGraphType<Pokemon>
    {
        public PokemonType()
        {
            Field(x => x.Id).Description("The Id of the Pokemon");
            Field(x => x.Name).Description("The Name of the Pokemon");
        }
    }
}
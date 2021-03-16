using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.NewtonsoftJson;
using GraphQL.Types;

namespace PokeAPI
{
    class Program
    {
  public static async Task Main(string[] args)
  {
    var schema = Schema.For(@"
      type Pokemon {
        id: String!
        name: String!
      }

      type Query{
        pokemon: Pokemon
      }
    ", _ => {
      _.Types.Include<Query>();
    });
 
    var json = await schema.ExecuteAsync(_ =>
    {
      _.Query = "{ pokemon {id name} }";
    });
 
    Console.WriteLine(json);
  }
    }
}

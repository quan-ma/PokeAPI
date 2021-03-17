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
    var schema = new Schema
    {
      Query = new Query()
    };
    
 
    var json = await schema.ExecuteAsync(_ =>
    {
      _.Query = "{ pokemon {id name type} }";
    });
 
    Console.WriteLine(json);
  }
    }
}

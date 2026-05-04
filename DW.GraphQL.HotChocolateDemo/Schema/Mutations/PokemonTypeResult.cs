using DW.GraphQL.HotChocolateDemo.Schema.Enums;

namespace DW.GraphQL.HotChocolateDemo.Schema.Mutations
{
    public class PokemonTypeResult
    {
        public string Name { get; set; }
        public IEnumerable<ElementType> ElementTypes { get; set; }
    }
}

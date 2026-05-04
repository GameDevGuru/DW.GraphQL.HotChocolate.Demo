using DW.GraphQL.HotChocolateDemo.Schema.Enums;

namespace DW.GraphQL.HotChocolateDemo.Schema.Queries
{
    public class PokemonType
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public IEnumerable<ElementType> ElementTypes { get; set; } = Enumerable.Empty<ElementType>();
    }
}

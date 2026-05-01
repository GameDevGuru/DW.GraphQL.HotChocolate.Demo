namespace DW.GraphQL.HotChocolateDemo.Schema
{
    public enum ElementType
    {
        Unknown,
        Grass,
        Fire,
        Water,
        Electric,
        Flying,
        Fighting,
        Normal
    }
    public class PokemonType
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public IEnumerable<ElementType> ElementTypes { get; set; } = Enumerable.Empty<ElementType>();
    }
}

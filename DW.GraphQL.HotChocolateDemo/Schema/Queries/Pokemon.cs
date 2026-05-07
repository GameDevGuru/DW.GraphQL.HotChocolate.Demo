namespace DW.GraphQL.HotChocolateDemo.Schema.Queries
{
    public class Pokemon
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Number { get; set; }
        public required string Name { get; set; }
        [GraphQLNonNullType] // Makes PokemonType not nullable
        public required PokemonType PokemonType { get; set; }
        public required PokemonBaseStats Stats { get; set; }
        public required IEnumerable<AttackType> AttackList { get; set; } = Enumerable.Empty<AttackType>();
        public string ImageUrl { get; } = "gs://pokedexflutterapp.firebasestorage.app/assets/pokemon_placeholder.png";

        public string PokemonSummary()
        {
            return $"{Name} is Pokemon #{Number} and has {string.Join(',', PokemonType.ElementTypes.Select(x => x.ToString()))} types.";
        }
    }
}

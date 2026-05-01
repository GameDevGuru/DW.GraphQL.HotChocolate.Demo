namespace DW.GraphQL.HotChocolateDemo.Schema
{
    public class PokemonBaseStats
    {
        public int HP { get; set; }
        public int Speed { get; set; }
        public int Stamina { get; set; }
        [GraphQLName("shiny")]
        public bool IsShiny { get; set; }
    }
}

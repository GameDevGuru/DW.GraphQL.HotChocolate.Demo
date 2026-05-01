namespace DW.GraphQL.HotChocolateDemo.Schema
{
    public class Query
    {
        private readonly IEnumerable<Pokemon> _pokemons;

        public Query()
        {
            _pokemons = new List<Pokemon>()
            {
                {
                    new Pokemon()
                    {
                        Name = "Charmander",
                        Number = 1,
                        PokemonType = new PokemonType()
                        {
                            ElementTypes = new List<ElementType>() { ElementType.Fire },
                        },
                        Stats = new PokemonBaseStats()
                        {
                            HP = 100,
                            IsShiny = false,
                            Speed = 10,
                            Stamina = 50
                        },
                        AttackList = new List<AttackType>()
                        {
                            { new AttackType() { Name = "Flamethrower", PP = 15 } },
                            { new AttackType() { Name = "Tackle", PP = 25 } },
                            { new AttackType() { Name = "Growl", PP = 20 } }
                        }
                    }
                },
                {
                    new Pokemon()
                    {
                        Name = "Squirtle",
                        Number = 2,
                        PokemonType = new PokemonType()
                        {
                            ElementTypes = new List<ElementType>() { ElementType.Grass },
                        },
                        Stats = new PokemonBaseStats()
                        {
                            HP = 100,
                            IsShiny = false,
                            Speed = 5,
                            Stamina = 60
                        },
                        AttackList = new List<AttackType>()
                        {
                            { new AttackType() { Name = "Razor Leaf", PP = 15 } },
                            { new AttackType() { Name = "Tackle", PP = 25 } },
                            { new AttackType() { Name = "Leer", PP = 20 } }
                        }
                    }
                },
                {
                    new Pokemon()
                    {
                        Name = "Zapdos",
                        Number = 3,
                        PokemonType = new PokemonType()
                        {
                            ElementTypes = new List<ElementType>() { ElementType.Electric, ElementType.Flying },
                        },
                        Stats = new PokemonBaseStats()
                        {
                            HP = 250,
                            IsShiny = false,
                            Speed = 100,
                            Stamina = 100,
                        },
                        AttackList = new List<AttackType>()
                        {
                            { new AttackType() { Name = "Thunder", PP = 10 } },
                            { new AttackType() { Name = "Drill Peck", PP = 15 } },
                            { new AttackType() { Name = "Fly", PP = 20 } }
                        }
                    }
                },
            };
        }
        public IEnumerable<Pokemon> GetAllPokemon()
        {
            return _pokemons;
        }

        public async Task<List<Pokemon>?> GetPokemonByNumber(List<int> numbers)
        {
            await Task.Delay(1000);

            return _pokemons.Where(x => numbers.Contains(x.Number))?.ToList(); // FirstOrDefault(x => x.Number == number);
        }

        [GraphQLDeprecated("This was a tutorial.")]
        public string HelloWorld => "Hello World";
    }
}

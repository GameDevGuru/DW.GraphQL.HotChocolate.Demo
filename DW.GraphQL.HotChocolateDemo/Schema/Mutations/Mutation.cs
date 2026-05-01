using DW.GraphQL.HotChocolateDemo.Schema.Enums;
using DW.GraphQL.HotChocolateDemo.Schema.Queries;

namespace DW.GraphQL.HotChocolateDemo.Schema.Mutations
{
    public class Mutation
    {
        private readonly List<PokemonTypeResult> _pokemonTypes = new List<PokemonTypeResult>();
        private readonly List<Pokemon> _pokemon = new List<Pokemon>();

        public PokemonTypeResult CreatePokemonType(string name, IEnumerable<ElementType> type)
        {
            _pokemonTypes.Add(new PokemonTypeResult()
            {
                Name = name,
                ElementTypes = type,
            });

            return _pokemonTypes.Last();
        }

        public PokemonTypeResult UpdatePokemonType(string name, IEnumerable<ElementType> types)
        {
            PokemonTypeResult? type = _pokemonTypes.FirstOrDefault(x => string.Equals(name, x.Name, StringComparison.InvariantCultureIgnoreCase));

            if(type == null)
            {
                throw new GraphQLException(
                    ErrorBuilder.New()
                        .SetMessage($"{name} not found.")
                        .SetCode("NOT_FOUND")
                        .SetExtension("httpStatusCode", 404)
                        .Build());
            }

            type.ElementTypes = types;
            return type;
        }

        public bool DeletePokemonType(string name)
        {
            return _pokemonTypes.RemoveAll(x => string.Equals(x.Name, name, StringComparison.InvariantCultureIgnoreCase)) >= 1;
        }
    }
}

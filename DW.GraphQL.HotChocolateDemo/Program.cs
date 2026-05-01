using DW.GraphQL.HotChocolateDemo.Schema.Mutations;
using DW.GraphQL.HotChocolateDemo.Schema.Queries;

var builder = WebApplication.CreateBuilder(args);

// Register Hot Chocolate services
builder.Services
        .AddGraphQLServer()
        .AddQueryType<Query>()
        .AddMutationType<Mutation>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
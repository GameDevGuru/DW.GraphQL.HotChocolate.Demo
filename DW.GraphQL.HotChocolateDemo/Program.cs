using DW.GraphQL.HotChocolateDemo.Schema;

var builder = WebApplication.CreateBuilder(args);

// Register Hot Chocolate services
builder.Services
        .AddGraphQLServer()
        .AddQueryType<Query>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
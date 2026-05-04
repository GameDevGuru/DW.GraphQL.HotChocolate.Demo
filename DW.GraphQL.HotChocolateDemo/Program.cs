using DW.GraphQL.HotChocolateDemo.Schema.Mutations;
using DW.GraphQL.HotChocolateDemo.Schema.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFlutter", policy =>
    {
        policy.WithOrigins("http://127.0.0.1:8081")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Register Hot Chocolate services
builder.Services
        .AddGraphQLServer()
        .AddQueryType<Query>()
        .AddMutationType<Mutation>();



var app = builder.Build();
app.UseRouting();
app.UseCors("AllowFlutter");
app.MapGraphQL();

app.Run();
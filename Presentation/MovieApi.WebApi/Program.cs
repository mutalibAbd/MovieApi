using Microsoft.OpenApi.Models;
using MovieApi.Aplication.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.CatagoryHandlers;
using MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.MovieHandlers;
using MovieApi.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<MovieContext>();

builder.Services.AddScoped<GetCatagoryQueryHandler>();
builder.Services.AddScoped<GetCatagoryByIdQueryHandler>();
builder.Services.AddScoped<UpdateCatagoryCommandHandler>();
builder.Services.AddScoped<RemoveCatagoryCommandHandler>();
builder.Services.AddScoped<CreatCatagoryCommandHandler>();

builder.Services.AddScoped<GetMovieQueryHandler>();
builder.Services.AddScoped<GetMovieByIdQueryHandlers>();
builder.Services.AddScoped<UpdateMoviecommandHandler>();
builder.Services.AddScoped<RemoveMovieCommandHandler>();
builder.Services.AddScoped<CreatMovieCommandHandleer>();


builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddOpenApi(); instead of that we add:
builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc("v1", new OpenApiInfo{ Title = "My Api", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi();  Again instead of that we use
    app.UseSwagger();
    app.UseSwaggerUI(x =>
    {
        x.SwaggerEndpoint("/swagger/v1/swagger.json", "My apiv1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

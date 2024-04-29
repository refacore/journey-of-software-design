using Microsoft.AspNetCore.Mvc;
using BubbleSort.Commands;
using BubbleSort.Comparer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IComparerFactory, ComparerFactory>();

builder.Services.AddTransient<IntBubbleSortCommand>();

builder.Services.AddTransient<StringBubbleSortCommand>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.MapPost("/sort-integers", ([FromBody] int[] input, IntBubbleSortCommand bubbleSort) =>
{
    return bubbleSort.Sort(input);
})
.WithName("Sort Int")
.WithOpenApi();

app.MapPost("/sort-strings", ([FromBody] string[] input, StringBubbleSortCommand bubbleSort) =>
{
    return bubbleSort.Sort(input);
})
.WithName("Sort String")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

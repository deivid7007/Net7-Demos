using Demos.Services.Interfaces;
using Demos.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IFakeService, FakeService>();


var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/cars", (IFakeService fakeService) =>
{
    var cars = fakeService.GetCarBrands();
    return cars;
});

app.Run();
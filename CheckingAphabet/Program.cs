using CheckingAphabet.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IAlphabetService, AlphabetService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{

    options.SwaggerDoc("v1", new OpenApiInfo

    {
        Title = "Alphabet Checker API",
        Version = "v1",
        Description = "This API checks whether a string contains all the letters of the alphabet.",
        Contact = new OpenApiContact
        {
            Name = "Vijaykumar Jakune",
            Email = "jakunevijaykumar@gmail.com",
           
        }
    });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

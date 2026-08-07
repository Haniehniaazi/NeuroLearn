using NeuroLearn.API.Services;
using NeuroLearn.API.Services.Interfaces;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register application services
builder.Services.AddScoped<ICrosswordService, CrosswordService>();
builder.Services.AddScoped<IWordGenerationService, WordGenerationService>();
builder.Services.AddScoped<ICrosswordService, CrosswordService>();

// Build object 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
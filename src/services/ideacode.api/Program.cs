using ideacode.api.Infra.Data;
using ideacode.core.Mediator;
using Microsoft.EntityFrameworkCore;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var configuration = builder.Configuration;

builder.Services.AddDbContext<IdeaCodeContext>(options => 
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IMediatorHandler, MediatorHandler>();
builder.Services.AddMediatR(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using var serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope();
var context = serviceScope.ServiceProvider.GetRequiredService<IdeaCodeContext>();
context.Database.Migrate();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();


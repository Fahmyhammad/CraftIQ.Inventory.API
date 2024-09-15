using CraftIQ.Inventory.Infrastructure;
using CraftIQ.Inventory.Services;
using huzcodes.Extensions.Exceptions;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInventoryDbContext(builder.Configuration.GetSection("ConnectionStrings:InventoryConnection").Value!);
builder.Services.AddInfrastructureRegistrations();
builder.Services.AddServicesRegistrations();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.AddExceptionHandlerExtension();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

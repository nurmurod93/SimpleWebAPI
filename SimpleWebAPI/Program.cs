using Microsoft.EntityFrameworkCore;
using SimpleWebAPI.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SimpleDbContext>(options => 
options.UseNpgsql(builder.Configuration.GetConnectionString("SqlConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

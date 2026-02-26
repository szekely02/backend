using GameStore.Data;
using GameStore.Endpoints;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddDbContext<netContext>(options =>
    options.UseMySql(connString, ServerVersion.AutoDetect(connString)));

var app = builder.Build();



app.MapRendelesekEndpoints();
app.MapTermekekEndpoints();
app.MapVasarlokEndpoints();

await app.MigrateDB();

app.Run();

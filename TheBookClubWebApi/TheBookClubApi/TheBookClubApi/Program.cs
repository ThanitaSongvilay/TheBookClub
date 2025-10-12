using Microsoft.EntityFrameworkCore;
using TheBookClubApi.DataAccess;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var path = "/Users/thanitasongvilay/Desktop/repos/" ;
var dbPath = Path.Combine(path, "bookClub.db");

//register DbContext to the DI container
builder.Services.AddDbContext<BookClubContext>(options =>
    options.UseSqlite($"Data Source={dbPath}"));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<BookClubContext>();
    db.Database.Migrate(); // <- This line creates/updates the database at runtime
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

using Microsoft.EntityFrameworkCore;
using TheBookClubApi.DataAccess.Models;

namespace TheBookClubApi.DataAccess;
public class BookClubContext : DbContext
{
    DbSet<Book> Book { get; set; }
    public string DbPath { get; }

    public BookClubContext(DbContextOptions<BookClubContext> options)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "bookClub.db");
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
}
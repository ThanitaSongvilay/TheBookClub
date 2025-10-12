using Microsoft.EntityFrameworkCore;
using TheBookClubApi.DataAccess.Models;

namespace TheBookClubApi.DataAccess;

public class BookClubContext(DbContextOptions<BookClubContext> options) : DbContext(options)
{
    public DbSet<Book> Book { get; set; }
}
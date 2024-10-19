using Microsoft.EntityFramewor
namespace AmazonBooks.Data;
using AmazonBooks.Models;



public class ApplicationDbContext:DbContext
{
public ApplicationDbContext(DbContextOptions<ApplicationDbContext>option):base(option){
    
}
public DbSet<BooksEntity> Books { get;}
}
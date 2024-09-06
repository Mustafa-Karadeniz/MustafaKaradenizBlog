using BlogUygulama.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BlogUygulama.Data.Context;

public class AppDbContext : DbContext //ctrl + . ile basarak direk hızlı işlem yapabilirsin
{
    public AppDbContext()
    {
        
    }
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Article> Articles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Image>   Images { get; set; }
    
    protected override void  OnModelCreating(ModelBuilder builder)
    {
        //builder.Entity<Article>().Property(x => x.Title).HasMaxLength(125); => bu hiç doğru bir kullanım değil
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//IEntityTypeConfiguration kalıtım alan tüm sınıfların tanımlanmasına yarar.
    }

}

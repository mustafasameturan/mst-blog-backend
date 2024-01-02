using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MstBlog.Core.Entities;

namespace MstBlog.Repository.Contexts;

public class MstBlogDbContext : IdentityDbContext<User, IdentityRole, string>
{
    public MstBlogDbContext(DbContextOptions<MstBlogDbContext> options) : base(options)
    {
        
    }    
    
    public DbSet<Post> Posts { get; set; }
    public DbSet<PostCategory> PostCategories { get; set; }
    public DbSet<PostContent> PostContents { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Subscribe> Subscribes { get; set; }
    
    /// <summary>
    /// This method is used to set the CreatedDate and UpdatedDate properties of the entities. For async operations.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var item in ChangeTracker.Entries())
        {
            if(item.Entity is BaseEntity  entityReference)
            {
                switch(item.State)
                {
                    case EntityState.Added:
                    {
                        entityReference.CreatedDate=DateTime.UtcNow;
                        break;
                    }
                    case EntityState.Modified:
                    {
                        Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;

                        entityReference.UpdatedDate = DateTime.UtcNow;
                        break;
                    }
                }
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
    
    /// <summary>
    /// This method is used to configure the entities.
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // This code is used to configure the entities by using the Fluent API approach.
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
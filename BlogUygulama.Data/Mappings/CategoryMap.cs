using BlogUygulama.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogUygulama.Data.Mappings;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(new Category
        {
            Id = Guid.Parse("52B35AC9-C1C4-498C-AE60-3642B55DD160"),
            Name = "Asp.Net Core",
            CreatedBy = "Admin Test 1",
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        },
        new Category
        {
            Id = Guid.Parse("01724477-E4E7-46EC-A3BB-495663C7F953"),
            Name = "Asp.Net Core",
            CreatedBy = "Admin Test 2",
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        });
    }
}

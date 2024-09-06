using BlogUygulama.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogUygulama.Data.Mappings;

public class ImageMap : IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.HasData(new Image
        {
            Id = Guid.Parse("EC79553F-E5E0-445F-A239-7DC1A3AB1486"),
            FileName = "images/testimage",
            FileType = "jpg",
            CreatedBy = "Admin Test 1",
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        }, 
        new Image
        {
            Id = Guid.Parse("A2C46D1B-E450-4D2F-A301-900E51393D1F"),
            FileName = "images/testimage2",
            FileType = "png",
            CreatedBy = "Admin Test 2",
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        });
    }
}

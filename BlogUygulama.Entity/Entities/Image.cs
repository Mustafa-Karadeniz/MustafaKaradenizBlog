using BlogUygulama.Core.Entities;

namespace BlogUygulama.Entity.Entities;
public class Image : EntityBase
{
    public Guid Id { get; set; }
    public string FileName { get; set; }
    public string  FileType { get; set; }
}

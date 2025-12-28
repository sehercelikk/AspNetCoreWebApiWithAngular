using Blog.Domain.Entities.Common;

namespace Blog.Domain.Entities;

public class Blogy : BaseEntity
{
    public string Title { get; set; }
    public string CoverImage { get; set; }
    public string BlogImage { get; set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}

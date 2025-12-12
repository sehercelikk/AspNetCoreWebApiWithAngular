using Blog.Domain.Entities.Common;

namespace Blog.Domain.Entities;

public class Category : BaseEntity
{
    public string CategoryName { get; set; }
    public IList<Blog> Blogs { get; set; }

}

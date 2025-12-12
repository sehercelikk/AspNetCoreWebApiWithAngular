using Blog.Domain.Entities.Common;

namespace Blog.Domain.Entities;

public class ContactInfo : BaseEntity
{
    public string Address { get; set; }
    public string EMail { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string MapUrl { get; set; }
}

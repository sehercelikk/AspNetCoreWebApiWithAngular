using Blog.Domain.Entities.Common;

namespace Blog.Domain.Entities;

public class Message : BaseEntity
{
    public string SenderName { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string MessageBody { get; set; }
    public bool IsRead { get; set; }
}

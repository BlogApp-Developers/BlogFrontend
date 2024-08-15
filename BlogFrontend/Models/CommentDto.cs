using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogFrontend.Models;

public class CommentDto
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid BlogId { get; set; }
    public Guid UserId { get; set; }
    public UserDto User { get; set; }
}

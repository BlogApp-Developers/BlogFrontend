using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogFrontend.Models;

public class Notification
{
    [Key]
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string? Message { get; set; }
    public string? Type { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string? UserName { get; set; }
    public string? BlogAvatar { get; set; }
    public bool IsRead { get; set; } = false;
}
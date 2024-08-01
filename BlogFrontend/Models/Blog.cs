using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogFrontend.Models;

public class Blog
{
    [Key]
    public int Id { get; set; }
    [Required]
    public required string Title { get; set; }
    [Required]
    public required string Text { get; set; }
    [ForeignKey("TopicId"), Required]
    public required int TopicId { get; set; }
    public Topic? Topic { get; set; }
    [ForeignKey("UserId"), Required]
    public required int UserId { get; set; }
    public User? User { get; set; }
    public string? PictureUrl { get; set; } 
    [Required]
    public required DateTime CreationDate{set; get;}
}
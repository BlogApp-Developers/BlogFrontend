using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlogFrontend.Models;

public class Topic
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [JsonIgnore]
    public ICollection<Blog> Blogs { get; set; } = new List<Blog>();
    
    [JsonIgnore]
    public ICollection<UserTopic> Users { get; set; } = new List<UserTopic>();
}
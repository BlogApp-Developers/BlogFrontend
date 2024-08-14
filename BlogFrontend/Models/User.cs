using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlogFrontend.Models;

public class User
{
    public string? AvatarUrl { get; set; }

    public ICollection<UserTopic> Topics { get; set; } = new List<UserTopic>();

    public string? AboutMe { get; set; }
    [JsonIgnore]
    public ICollection<Blog> Blogs { get; set; } = new List<Blog>();

    public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public ICollection<Like> Likes { get; set; } = new List<Like>();
}
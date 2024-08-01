using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogFrontend.Models;

public class User
{
    [Required]
    public string? Name { get; set; }
    public string? AvatarUrl { get; set; }
    public IEnumerable<UserTopic>? Topics {set; get;}
}
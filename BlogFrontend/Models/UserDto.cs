using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogFrontend.Models;

public class UserDto
{
    public Guid Id { get; set; }         
    public string UserName { get; set; } 
    public string Email { get; set; }    
    public string AvatarUrl { get; set; }
    public string AboutMe { get; set; }  
    public ICollection<Follow>? Followers { get; set; }

}

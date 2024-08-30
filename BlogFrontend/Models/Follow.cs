using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogFrontend.Models;

public class Follow
{
    public Guid Id { get; set; }
    public Guid FollowerId { get; set; }
    public User? Follower { get; set; }
    public Guid? FollowingId { get; set; }
    public User? Following { get; set; }
}
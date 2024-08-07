using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogFrontend.Models;

public class UserTopic
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Topic")]
    public int TopicId { get; set; }
    public Topic Topic { get; set; }

    [ForeignKey("User")]
    public Guid UserId { get; set; }
    public User User { get; set; }
}
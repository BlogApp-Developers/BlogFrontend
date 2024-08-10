using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogFrontend.Models
{
    public class Like
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime LikedAt { get; set; }

        [ForeignKey("Blog")]
        public Guid BlogId { get; set; }
        public Blog Blog { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
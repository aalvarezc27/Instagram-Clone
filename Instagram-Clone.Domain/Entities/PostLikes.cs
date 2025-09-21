using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram_Clone.Domain.Entities
{
    public class PostLikes
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public DateOnly CreatedAt { get; set; }
        public User User { get; set; } = null!;
        public Post Post { get; set; } = null!;
    }
}

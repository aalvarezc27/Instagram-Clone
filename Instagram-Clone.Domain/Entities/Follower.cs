using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instagram_Clone.Domain.Base;

namespace Instagram_Clone.Domain.Entities
{
    public class Follower : BaseModel
    {
        [ForeignKey("FollowerUser")]
        public int FollowerId { get; set; }
        [ForeignKey("FollowedUser")]
        public int FollowedId { get; set; }
        public DateOnly FollowDate { get; set; }
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
        public User FollowedUser { get; set; } = null!;
        public User FollowerUser { get; set; } = null!;
    }
}

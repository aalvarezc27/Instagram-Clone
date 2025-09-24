using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instagram_Clone.Domain.Base;

namespace Instagram_Clone.Domain.Entities
{
    public class Post : BaseModel
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string FileUrl {  get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
        public User User { get; set; } = null!;
        public ICollection<PostLikes> PostLikes { get; set; } = [];
        public ICollection<PostComments> PostComments { get; set; } = [];

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instagram_Clone.Domain.Base;

namespace Instagram_Clone.Domain.Entities
{
    public class PostComments : BaseModel
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public string Text { get; set; } = string.Empty;
        public DateOnly CreatedAt { get; set; }
        public User User { get; set; } = null!;
        public Post Post { get; set; } = null!;
    }
}

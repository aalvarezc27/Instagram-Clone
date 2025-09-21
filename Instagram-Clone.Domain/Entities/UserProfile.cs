using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instagram_Clone.Domain.Base;

namespace Instagram_Clone.Domain.Entities
{
    public class UserProfile : BaseModel
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string ProfilePictureUrl {  get; set; } = string.Empty;
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
        public User User { get; set; } = null!;
    }
}

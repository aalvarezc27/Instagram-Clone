using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instagram_Clone.Domain.Base;

namespace Instagram_Clone.Domain.Entities
{
    public class User : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateOnly CreatedAt { get; set; } 
        public DateOnly UpdatedAt { get; set; } 
        public bool Enabled { get; set; }
    }
}

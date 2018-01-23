using System;
using System.Collections.Generic;

namespace MotoSaleSite.Models
{
    public partial class UserType
    {
        public UserType()
        {
            User = new HashSet<User>();
        }

        public int UserTypeId { get; set; }
        public string Type { get; set; }

        public ICollection<User> User { get; set; }
    }
}

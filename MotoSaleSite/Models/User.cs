using System;
using System.Collections.Generic;

namespace MotoSaleSite.Models
{
    public partial class User
    {
        public User()
        {
            Advertisement = new HashSet<Advertisement>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Region { get; set; }
        public string Location { get; set; }
        public DateTime BirthDate { get; set; }
        public int UserTypeId { get; set; }

        public UserType UserType { get; set; }
        public ICollection<Advertisement> Advertisement { get; set; }
    }
}

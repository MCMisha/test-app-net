using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class User
    {
        public User()
        {
            Events = new HashSet<Event>();
            Participants = new HashSet<Participant>();
            Settings = new HashSet<Setting>();
        }

        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
        public virtual ICollection<Setting> Settings { get; set; }
    }
}

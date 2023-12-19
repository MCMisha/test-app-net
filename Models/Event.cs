using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class Event
    {
        public Event()
        {
            Participants = new HashSet<Participant>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Category { get; set; } = null!;
        public DateOnly Date { get; set; }
        public int ParticipantNumber { get; set; }
        public int Organizer { get; set; }

        public virtual User OrganizerNavigation { get; set; } = null!;
        public virtual ICollection<Participant> Participants { get; set; }
    }
}

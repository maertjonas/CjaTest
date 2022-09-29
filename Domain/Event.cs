using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Shared;

namespace Domain
{
    public class Event
    {
        public long Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Organizer { get; set; }
        public string Location { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public TargetAudienceType TargetAudience { get; set; }
        public string EventLink { get; set; }
        public Admin CreatedBy { get; set; }
        public Admin LastModifiedBy { get; set; }

        public IEnumerable<Candidate> Candidates { get; set; }

        public Event()
        {

        }

        public Event(long id, string Name)
        {

        }
    }
}

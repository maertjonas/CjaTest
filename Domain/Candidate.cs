using System.Collections.ObjectModel;
using Domain.Shared;
using Microsoft.VisualBasic;

namespace Domain
{
    public class Candidate
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Specialization { get; set; }
        public DateTime DateOfGraduation { get; set; }
        public CandidateType CandidateType { get; set; }
        public string PictureLink { get; set; }

        /*?*/
        public Event Event { get; set; }
        public IEnumerable<Interest> Interests { get; set; }

        public Candidate()
        {
                
        }
    }
}
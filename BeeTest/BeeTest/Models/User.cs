using BeeTest.Enumerations;

namespace BeeTest.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } 
        public Role Role { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<Participant_Schedule> Participant_Schedules { get; set; }
    }
}

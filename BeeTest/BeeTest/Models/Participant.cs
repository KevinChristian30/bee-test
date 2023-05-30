using BeeTest.Enumerations;

namespace BeeTest.Models
{

    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Participant_Schedule> Participant_Schedules { get; set; }
    }
}

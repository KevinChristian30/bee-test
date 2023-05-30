using BeeTest.Data;
using BeeTest.Enumerations;
using BeeTest.Models;

namespace BeeTest
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            this._context = context;
        }

        public void SeedDataContext()
        {
            SeedQuestionTypes();
            SeedParticipants();
        }

        public void SeedQuestionTypes()
        {
            if (!_context.QuestionTypes.Any())
            {
                var questionTypes = new List<QuestionType>()
                {
                    new QuestionType()
                    {
                        Name = "Multiple Choice"
                    },
                    new QuestionType() 
                    { 
                        Name = "Boolean"
                    },
                    new QuestionType()
                    {
                        Name = "Checkboxes"
                    },
                    new QuestionType()
                    {
                        Name = "Essay"
                    },
                    new QuestionType()
                    {
                        Name = "File"
                    }
                };

                _context.QuestionTypes.AddRange(questionTypes);
                _context.SaveChanges();
            }
        }
    
        public void SeedParticipants()
        {
            if (!_context.Participants.Any())
            {
                var participants = new List<Participant>()
                {
                    new Participant()
                    {
                        Name = "Kevin Christian",
                        Email = "kevinchristian@gmail.com",
                        Password = "kevinchristian",
                        Gender = Gender.Male,
                        DateOfBirth = new DateTime(2003, 5, 24, 0, 0, 0)
                    },
                    new Participant()
                    {
                        Name = "Rico Gunawan",
                        Email = "ricogunawan@gmail.com",
                        Password = "ricogunawan",
                        Gender = Gender.Male,
                        DateOfBirth = new DateTime(2003, 6, 13, 0, 0, 0)
                    },
                    new Participant()
                    {
                        Name = "Richard Gregorius",
                        Email = "richardgregorius@gmail.com",
                        Password = "richardgregorius",
                        Gender = Gender.Male,
                        DateOfBirth = new DateTime(2003, 3, 21, 0, 0, 0)
                    },
                    new Participant()
                    {
                        Name = "Glory Daniella",
                        Email = "glorydaniella@gmail.com",
                        Password = "glorydaniella",
                        Gender = Gender.Female,
                        DateOfBirth = new DateTime(2003, 4, 14, 0, 0, 0)
                    },
                    new Participant()
                    {
                        Name = "Jaysie Lestari",
                        Email = "jaysielestari@gmail.com",
                        Password = "jaysielestari",
                        Gender = Gender.Female,
                        DateOfBirth = new DateTime(2002, 7, 19, 0, 0, 0)
                    }
                };
                
                _context.Participants.AddRange(participants);
                _context.SaveChanges();
            }
        }
    }
}

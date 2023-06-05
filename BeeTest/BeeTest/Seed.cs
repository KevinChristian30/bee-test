using BeeTest.Data;
using BeeTest.Enumerations;
using BeeTest.Models;
using BeeTest.Services.Interfaces;

namespace BeeTest
{
    public class Seed
    {
        private readonly DataContext _context;
        private readonly IRoleService _roleService;
        private readonly ITestService _testService;
        private readonly IQuestionTypeService _questionTypeService;
        private readonly IUserService _userService;
        private readonly IScheduleService _scheduleService;

        public Seed(DataContext context, IRoleService roleService, ITestService testService, IQuestionTypeService questionTypeService, IUserService userService, IScheduleService scheduleService)
        {
            this._context = context;
            this._roleService = roleService;
            this._testService = testService;
            this._questionTypeService = questionTypeService;
            this._userService = userService;
            this._scheduleService = scheduleService;
        }

        public void SeedDataContext()
        {
            SeedQuestionTypes();
            SeedRoles();
            SeedUsers();
            SeedTests();
            SeedQuestions().ConfigureAwait(false).GetAwaiter().GetResult();
            SeedSchedules().ConfigureAwait(false).GetAwaiter().GetResult();
            SeedParticipant_Schedule().ConfigureAwait(false).GetAwaiter().GetResult();
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
    
        public void SeedRoles()
        {
            if (!_context.Roles.Any()) 
            {
                var roles = new List<Role>()
                {
                    new Role()
                    {
                        Name = "Admin"
                    },
                    new Role()
                    {
                        Name = "Participant"
                    }
                };

                _context.Roles.AddRange(roles);
                _context.SaveChanges();
            }
        }

        public void SeedUsers()
        {
            if (!_context.Users.Any())
            {
                var users = new List<User>()
                {
                    new User()
                    {
                        Name = "Admin",
                        Email = "admin@gmail.com",
                        Password = BCrypt.Net.BCrypt.HashPassword("Admin"),
                        Role = _roleService.Get("Admin"),
                        Gender = Gender.Male,
                        DateOfBirth = new DateTime(2003, 5, 24, 0, 0, 0),
                    },
                    new User()
                    {
                        Name = "Kevin Christian",
                        Email = "kevinchristian@gmail.com",
                        Password = BCrypt.Net.BCrypt.HashPassword("Kevin Christian"),
                        Role = _roleService.Get("Participant"),
                        Gender = Gender.Male,
                        DateOfBirth = new DateTime(2003, 5, 24, 0, 0, 0)
                    },
                    new User()
                    {
                        Name = "Rico Gunawan",
                        Email = "ricogunawan@gmail.com",
                        Password = BCrypt.Net.BCrypt.HashPassword("Rico Gunawan"),
                        Role = _roleService.Get("Participant"),
                        Gender = Gender.Male,
                        DateOfBirth = new DateTime(2003, 6, 13, 0, 0, 0)
                    },
                    new User()
                    {
                        Name = "Glory Daniella",
                        Email = "glorydaniella@gmail.com",
                        Password = BCrypt.Net.BCrypt.HashPassword("Glory Daniella"),
                        Role = _roleService.Get("Participant"),
                        Gender = Gender.Female,
                        DateOfBirth = new DateTime(2003, 4, 14, 0, 0, 0)
                    },
                    new User()
                    {
                        Name = "Jaysie Lestari",
                        Email = "jaysielestari@gmail.com",
                        Password = BCrypt.Net.BCrypt.HashPassword("Jaysie Lestari"),
                        Role = _roleService.Get("Participant"),
                        Gender = Gender.Female,
                        DateOfBirth = new DateTime(2002, 7, 19, 0, 0, 0)
                    }
                };

                _context.Users.AddRange(users);
                _context.SaveChanges();
            }
        }

        public void SeedTests()
        {
            if (!_context.Tests.Any())
            {
                var tests = new List<Test>()
                {
                    new Test
                    {
                        Name = "Algorithm Final Exam",
                        PassingScore = 65,
                    },
                    new Test
                    {
                        Name = "Database System Final Exam",
                        PassingScore = 55,
                    },
                };

                _context.Tests.AddRange(tests);
                _context.SaveChanges();
            }
        }
    
        public async Task SeedQuestions()
        {
            if (!_context.Questions.Any())
            {
                var questions = new List<Question>()
                {
                    new Question {
                        Title = "Apa warna balon yang meletus?",
                        Details = "{\"Choices\":{\"a\":\"Merah\",\"b\":\"Kuning\",\"c\":\"Hijau\",\"d\":\"Pink\",\"e\":\"Putih\"},\"Key\":\"c\"}",
                        QuestionPoints = 20,
                        Test = await _testService.Get(1),
                        QuestionType = await _questionTypeService.Get("Multiple Choice")
                    },
                    new Question {
                        Title = "Sapi bisa terbang",
                        Details = "{\"Key\":false}",
                        QuestionPoints = 20,
                        Test = await _testService.Get(1),
                        QuestionType = await _questionTypeService.Get("Boolean")
                    },
                    new Question {
                        Title = "Manakah dari pernyataan dibawah ini yang benar?",
                        Details = "{\"CheckboxQuestionData\":{\"1\":{\"IsTrue\":true,\"Statement\":\"Binus kemanggisan ada di Jakarta\"},\"2\":{\"IsTrue\":true,\"Statement\":\"Binus alsut ada di alam sutera\"},\"3\":{\"IsTrue\":false,\"Statement\":\"Binus bandung ada di bekasi\"},\"4\":{\"IsTrue\":true,\"Statement\":\"Binus malang ada di malang\"}}}",
                        QuestionPoints = 20,
                        Test = await _testService.Get(1),
                        QuestionType = await _questionTypeService.Get("Checkboxes")
                    },
                    new Question {
                        Title = "Jelaskan apa yang anda ketahui tentang binus?",
                        Details = "{}",
                        QuestionPoints = 20,
                        Test = await _testService.Get(1),
                        QuestionType = await _questionTypeService.Get("Essay")
                    },
                    new Question {
                        Title = "Kerjakan soal ini",
                        Details = "{\"filePath\":\"questions/acaae490-cae6-42e2-a6d0-a875438bfa41\",\"fileURL\":\"https://firebasestorage.googleapis.com/v0/b/beetest-d2a84.appspot.com/o/questions%2Facaae490-cae6-42e2-a6d0-a875438bfa41.zip?alt=media&token=4b7c2fc1-0c8c-483f-a79d-28f35c8422f6\"}",
                        QuestionPoints = 20,
                        Test = await _testService.Get(2),
                        QuestionType = await _questionTypeService.Get("Essay")
                    },
                };

                _context.Questions.AddRange(questions);
                _context.SaveChanges();
            }
        }
    
        public async Task SeedSchedules()
        {
            if (!_context.Schedules.Any())
            {
                var schedules = new List<Schedule>()
                {
                    new Schedule { 
                        Test = await _testService.Get(1),
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now.AddHours(12),
                    },
                    new Schedule {
                        Test = await _testService.Get(2),
                        StartTime = DateTime.Now.AddDays(1),
                        EndTime = DateTime.Now.AddDays(1).AddHours(12),
                    },
                };

                _context.Schedules.AddRange(schedules);
                _context.SaveChanges();
            }
        }
    
        public async Task SeedParticipant_Schedule()
        {
            if (!_context.Participant_Schedules.Any())
            {
                var participant_Schedules = new List<Participant_Schedule>()
                {
                    new Participant_Schedule
                    {
                        Participant = await _userService.Get(2),
                        Schedule = await _scheduleService.Get(1)
                    },
                    new Participant_Schedule
                    {
                        Participant = await _userService.Get(3),
                        Schedule = await _scheduleService.Get(1)
                    },
                    new Participant_Schedule
                    {
                        Participant = await _userService.Get(4),
                        Schedule = await _scheduleService.Get(1)
                    },
                    new Participant_Schedule
                    {
                        Participant = await _userService.Get(2),
                        Schedule = await _scheduleService.Get(2)
                    },
                    new Participant_Schedule
                    {
                        Participant = await _userService.Get(3),
                        Schedule = await _scheduleService.Get(2)
                    },
                    new Participant_Schedule
                    {
                        Participant = await _userService.Get(4),
                        Schedule = await _scheduleService.Get(2)
                    }
                };

                _context.Participant_Schedules.AddRange(participant_Schedules);
                _context.SaveChanges();
            }
        }
    }
}
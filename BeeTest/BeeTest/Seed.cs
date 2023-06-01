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

        public Seed(DataContext context, IRoleService roleService)
        {
            this._context = context;
            this._roleService = roleService;
        }

        public void SeedDataContext()
        {
            SeedQuestionTypes();
            SeedRoles();
            SeedUsers();
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
    }
}
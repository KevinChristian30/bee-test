using BeeTest.Enumerations;
using BeeTest.Models;

namespace BeeTest.Authentication
{
    public class UserAuthService
    {
        private List<User> _users;
        public UserAuthService()
        {
            _users = new List<User>
            {
                new User()
                {
                    Name = "Admin",
                    Email = "admin@gmail.com",
                    Password = "admin",
                    Role = new Role
                    {
                        Id = 1,
                        Name= "Admin"
                    },
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(2003, 5, 24, 0, 0, 0)
                },
                new User()
                {
                    Name = "Kevin Christian",
                    Email = "kevinchristian@gmail.com",
                    Password = "kevinchristian",
                    Role = new Role
                    {
                        Id = 2,
                        Name = "Participant"
                    },
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(2003, 5, 24, 0, 0, 0)
                },
            };
        }

        public User GetUser(String email)
        {
            return _users.FirstOrDefault(x => x.Email == email);
        }
    }
}

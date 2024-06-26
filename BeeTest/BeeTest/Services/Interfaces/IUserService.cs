﻿using BeeTest.Models;

namespace BeeTest.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> AddOrUpdate(User user);
        Task<User> Get(int id);
        Task<User> Get(string email);
        Task<List<User>> GetAllParticipants();
        Task<List<User>> Search(string query);
    }
}

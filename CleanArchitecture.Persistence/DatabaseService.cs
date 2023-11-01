using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Persistence
{
    public class DatabaseService : IDatabaseService
    {
        public User GetUser(int id) => new() { Id = id, Name = "Mary" };
    }
}
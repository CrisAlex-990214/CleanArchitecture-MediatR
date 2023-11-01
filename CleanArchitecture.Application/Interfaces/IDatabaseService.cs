using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IDatabaseService
    {
        User GetUser(int id);
    }
}

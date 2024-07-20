using EventManagementAPI.Models;

namespace EventManagementAPI.Repositorie
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByUsernameAsync(string username);
    }
}

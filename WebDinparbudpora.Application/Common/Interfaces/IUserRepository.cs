using WebDinparbudpora.Domain.Entities;

namespace WebDinparbudpora.Application.Common.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByUsernameAsync(string username);
    // Task<User?> GetByPassword(string password);
}
using WebDinparbudpora.Domain.Entities;

namespace WebDinparbudpora.Application.Common.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByUsername(string username);
    Task<User?> GetByPassword(string password);
}
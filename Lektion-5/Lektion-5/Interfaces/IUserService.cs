using Lektion_5.Models;
using System.Linq.Expressions;

namespace Lektion_5.Interfaces;

internal interface IUserService
{
    public void CreateUser(UserCreateRequest userCreateRequest);
    public User GetUser(Func<User, bool> expression);
    public IEnumerable<User> GetUsers();
}

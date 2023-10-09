using Lektion_5.Interfaces;
using Lektion_5.Models;
using System.Linq.Expressions;

namespace Lektion_5.Services;

internal class UserService : IUserService
{
    private List<User> _users = new List<User>();
    public void CreateUser(UserCreateRequest userCreateRequest)
    {
        _users.Add(new User
        {
            Id = Guid.NewGuid(),
            FirstName = userCreateRequest.FirstName,
            LastName = userCreateRequest.LastName,
            Email = userCreateRequest.Email,
        });

        //Lösenordet får vi hantera separat av säkerhetsskäl...
    }

    public User GetUser(Func<User, bool> expression)
    {
        var user = _users.FirstOrDefault(expression, null!);
        return null!;
    }

    public User GetUser(Expression<Func<User, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetUsers()
    {
        return _users;
    }
}

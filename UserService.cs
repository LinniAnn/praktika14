using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

public class UserService
{
    private readonly List<User> _users;
    private readonly ILogger _logger;

    public UserService(ILogger logger)
    {
        _users = new List<User>();
        _logger = logger;
    }

    public void AddUser(User user)
    {
        _users.Add(user);
        _logger.Log($"Added user: {user.Name}");
    }

    public User GetUserById(int id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        if (user == null)
        {
            _logger.Log($"User with id {id} not found");
        }
        return user;
    }
}
public List<User> GetAllUsers()
    {
        _logger.Log("Retrieving all users");
        return _users.ToList();
    }
}

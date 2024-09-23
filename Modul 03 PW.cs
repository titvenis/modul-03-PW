public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }

    public User(string name, string email, string role)
    {
        Name = name;
        Email = email;
        Role = role;
    }
}

public class UserManager
{
    private List<User> users = new List<User>();

    public void AddUser(User user) => users.Add(user);

    public void RemoveUser(string email)
    {
        var user = users.FirstOrDefault(u => u.Email == email);
        if (user != null) users.Remove(user);
    }

    public void UpdateUser(string email, string newName, string newRole)
    {
        var user = users.FirstOrDefault(u => u.Email == email);
        if (user != null)
        {
            user.Name = newName;
            user.Role = newRole;
        }
    }
}


public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class UserManager
{
    private static readonly Lazy<UserManager> _instance = new Lazy<UserManager>(()=>new UserManager());
    public static UserManager Instance => _instance.Value;

    public IEnumerable<User> Users { get; set; } = Enumerable.Empty<User>();
    private UserManager()
    {
        Users = new List<User>
        {
            new(){ Id = 1, Name = "Subrahmanya"},
            new(){ Id = 1, Name = "Ananth"}
        };
    }

    public void PrintUsers()
    {
        foreach (var user in Users)
        {
            Console.WriteLine($"{user.Name}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        UserManager.Instance.PrintUsers();
    }
}

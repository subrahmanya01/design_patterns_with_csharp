public interface IUser
{
    string Name { get; }
    string Email { get; }

    string Address { get; }
}

public class User : IUser
{
    public string Name { get; private set; }

    public string Email { get; private set; }

    public string Address { get; private set; }

    private User()
    {

    }

    public class Builder
    {
        private readonly User user;
        public Builder()
        {
            user = new User();
        }

        public Builder WithName(string name)
        {
            user.Name = name;
            return this;
        }


        public Builder WithEmail(string email)
        {
            user.Email = email;
            return this;
        }

        public Builder WithAddress(string address)
        {
            user.Address = address;
            return this;
        }

        public IUser Build()
        {
            return user;
        }
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        var builderObject = new User.Builder().WithName("Subrahmanya").WithEmail("subgb98@gmail.com").WithAddress("Address").Build();
    }
}
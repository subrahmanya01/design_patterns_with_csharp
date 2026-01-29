using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public enum EmailType
{
    Success,
    Failure,
    Warning
}

public class EmailContext
{
    private IEnumerable<IEmail> _emailInstance { get; set; }
    public EmailContext(IEnumerable<IEmail> emailInstance)
    {
        _emailInstance = emailInstance;
    }

    public void SendEmail(EmailType type, string email)
    {
        var emailInstance = _emailInstance.FirstOrDefault(x=> x.CanHandle == type);
        if (emailInstance == null) {
            throw new Exception($"Handler not defined for selected email type {type}");
        }
        emailInstance.SendEmail(email);
    }
}

public interface IEmail
{
    public EmailType CanHandle { get; }
    public void SendEmail(string email);
}

public class SuccessEmail : IEmail
{
    public EmailType CanHandle => EmailType.Success;

    public void SendEmail(string email)
    {
        Console.WriteLine($"Success Email - Message : {email}");
    }
}

public class FailureEmail : IEmail
{
    public EmailType CanHandle => EmailType.Failure;

    public void SendEmail(string email)
    {
        Console.WriteLine($"Failure Email - Message : {email}");
    }
}

public class WarningEmail : IEmail
{
    public EmailType CanHandle => EmailType.Warning;

    public void SendEmail(string email)
    {
        Console.WriteLine($"Warning Email - Message : {email}");
    }
}

public class Program
{

    public static void Main(string[] args)
    {
        using IHost host = Host.CreateDefaultBuilder(args)
           .ConfigureServices((context, services) =>
           {
               services.AddSingleton<EmailContext>();
               services.AddSingleton<IEmail, SuccessEmail>();
               services.AddSingleton<IEmail, FailureEmail>();
               services.AddSingleton<IEmail, WarningEmail>();
           }).Build();

        var emailContext = host.Services.GetRequiredService<EmailContext>();

        emailContext.SendEmail(EmailType.Success, "Hello Success");
        emailContext.SendEmail(EmailType.Warning, "Hello Warning");
        emailContext.SendEmail(EmailType.Failure, "Hello Fail");

    }
}
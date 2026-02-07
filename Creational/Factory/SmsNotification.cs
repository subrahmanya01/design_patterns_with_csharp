
namespace Creational.Factory
{
    internal class SmsNotification : INotification
    {
        public void Send(IDictionary<string, object> attributes, string message)
        {
            Console.WriteLine("Sending SMS Notification");
            attributes.TryGetValue("phone", out var phoneNumber);
            Console.WriteLine($"{phoneNumber}");
            Console.WriteLine(message);
        }
    }
}

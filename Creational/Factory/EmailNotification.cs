namespace Creational.Factory
{
    internal class EmailNotification : INotification
    {
        public void Send(IDictionary<string, object> attributes, string message)
        {
            Console.WriteLine("Sending Email Notification");

            attributes.TryGetValue("to", out var to);
            attributes.TryGetValue("cc", out var cc);
            Console.WriteLine($"{to} {cc}");
            Console.WriteLine(message);
        }
    }
}

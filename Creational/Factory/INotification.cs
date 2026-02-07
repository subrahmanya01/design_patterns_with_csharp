namespace Creational.Factory
{
    internal interface INotification
    {
        void Send(IDictionary<string, object> attributes, string message);
    }
}

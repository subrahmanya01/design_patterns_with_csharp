namespace Creational.Factory
{
    internal static class NotificationFactory
    {
        public static INotification Get(NotificationType type)
        {
            switch (type)
            {
                case NotificationType.Email: return new EmailNotification();
                case NotificationType.Sms: return new SmsNotification();
                default: throw new ArgumentException("Does not find the implementation for given notification type");
            }
        }
    }
}

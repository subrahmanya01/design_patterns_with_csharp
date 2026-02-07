using Creational.Factory;

var notificationInstance1 = NotificationFactory.Get(NotificationType.Sms);

notificationInstance1.Send(
     new Dictionary<string, object>
     {
         { "phone", 0986423454 }
     },
     "Hey how are you, Can we catch up for tea break?"
    );

var notificationInstance2 = NotificationFactory.Get(NotificationType.Email);

notificationInstance2.Send(
     new Dictionary<string, object>
     {
         { "to", new List<string>{"abc@gnail.com" } },
         { "cc", new List<string>{"bcd@gnail.com" } }
     },
     "Hey how are you, Can we catch up for tea break?"
    );
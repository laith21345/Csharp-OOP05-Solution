using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Question_03
{
    // Question 03:
    //1- we define the INotificationService interface with a method SendNotification that takes
    //   a recipient and a message as parameters.

    //2- We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService,
    //   which implement the INotificationService interface.

    //3- In each implementation, we provide the logic to send notifications through the respective
    //   communication channel:
    //4- The EmailNotificationService class simulates sending an email by outputting a message to the console.
    //5- The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
    //6- The PushNotificationService class simulates sending a push notification by outputting a message to the console.
    //7- In the Main method, we create instances of each notification service class and call the SendNotification method with sample recipient and message values.
    //This implementation allows you to easily switch between different notification channels by creating new classes that implement the INotificationService interface and provide the specific logic for each channel.

    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"{recipient} you have new Email :{message}");
        }
    }
}

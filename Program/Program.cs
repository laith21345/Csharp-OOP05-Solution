using Program.Question_01;
using Program.Question_02;
using Program.Question_03;

namespace Program
{
    //بسم الله الرحمن الرحيم
    //Assignment 05 OOP
    internal class Program
    {
        static void Main(/*string[] args*/)
        {
            #region Question 01
            // Question 01:
            //Define an interface named IShape with a property Area and a method DisplayShapeInfo.
            //Create two interfaces, ICircle and IRectangle, that inherit from IShape.
            //Implement these interfaces in classes Circle and Rectangle.
            //Test your implementation by creating instances of both classes and displaying their shape information.


            //Circle circle = new Circle() { Radius = 10 };
            //circle.DisplayShapeInfo();

            //Rectangle rectangle = new Rectangle() { Height = 2, Width = 3 };
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Question 02
            //Question 02:
            //In this example,
            //1-We start by defining the IAuthenticationService interface with two methods:
            //  AuthenticateUser & AuthorizeUser.
            //  The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.

            //2-In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored credentials.
            //  It returns true if the user is authenticated and false otherwise.
            //  The AuthorizeUser method checks if the user with the given username has the specified role.
            //  It returns true if the user is authorized and false otherwise.

            //3-In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type IAuthenticationService.
            //  We then call the AuthenticateUser and AuthorizeUser methods using this interface reference..
            //This implementation allows you to switch the authentication service implementation easily by creating a new class that implements the IAuthenticationService interface and providing the desired logic for authentication and authorization.

            //IAuthenticationService iAuthenticationService = new BasicAuthenticationService("Laith","0123456789","admin");
            //if (iAuthenticationService.AuthenticateUser("Laith", "000"))
            //{
            //    Console.WriteLine("Laith was login");
            //}
            //if (iAuthenticationService.AuthorizeUser("Laith", "admin"))
            //{
            //    Console.WriteLine("Laith is a admin");
            //}

            #endregion

            #region Question03
            // Question 03:
            //1-we define the INotificationService interface :
            //      with a method SendNotification that takes a recipient and a message as parameters.
            //2-We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.
            //3-In each implementation, we provide the logic to send notifications through the respective communication channel:
            //4-The EmailNotificationService class simulates sending an email by outputting a message to the console.
            //5-The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
            //6-The PushNotificationService class simulates sending a push notification by outputting a message to the console.
            //7- In the Main method,
            //   we create instances of each notification service class and call the SendNotification method with sample recipient and message values.
            //This implementation allows you to easily switch between different notification channels by creating new classes that implement the INotificationService interface and provide the specific logic for each channel.

            //INotificationService iNotificationService;

            //iNotificationService = new EmailNotificationService();
            //iNotificationService.SendNotification("Laith","Hi Laith, This message is for you");

            //iNotificationService = new SmsNotificationService();
            //iNotificationService.SendNotification("Laith","Hi Laith, This message is for you");

            //iNotificationService = new PushNotificationService();
            //iNotificationService.SendNotification("Laith","Hi Laith, This message is for you");

            #endregion
        }
    }
}

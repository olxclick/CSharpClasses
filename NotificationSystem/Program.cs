// Exercise: Implement a Notification System

// Create a notification system that allows different components of a software application to communicate with each other using events.

// Define a Publisher class that contains an event named MessagePublishedEvent.
// Define a Subscriber class that subscribes to the MessagePublishedEvent and implements a method to handle the event.
// Implement a method in the Publisher class to publish a message by raising the MessagePublishedEvent.

// Create instances of the Publisher and Subscriber classes in your main program.
// Demonstrate the communication between the Publisher and Subscriber by publishing a message and ensuring the Subscriber receives and handles the message appropriately.

using System.Runtime.InteropServices;

namespace NotificationSystem
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var message = new Publisher();
				var verified = new Subscriber();

				message.MessagePublishedEvent += verified.OnMessagePublished;
				message.Publish("This is kinda suspect");
			}
			catch (Exception ex)
			{
				System.Console.WriteLine("Some error was found: " + ex.Message);
			}
			
		}
	}
}
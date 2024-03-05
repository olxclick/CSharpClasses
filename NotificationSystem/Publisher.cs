// Exercise: Implement a Notification System

// Create a notification system that allows different components of a software application to communicate with each other using events.

// Define a Publisher class that contains an event named MessagePublishedEvent.
// Define a Subscriber class that subscribes to the MessagePublishedEvent and implements a method to handle the event.
// Implement a method in the Publisher class to publish a message by raising the MessagePublishedEvent.

// Create instances of the Publisher and Subscriber classes in your main program.
// Demonstrate the communication between the Publisher and Subscriber by publishing a message and ensuring the Subscriber receives and handles the message appropriately.

namespace NotificationSystem
{
	class Publisher
	{
		public delegate void MessageEventHandler(object src, EventArgs args);
		public event MessageEventHandler MessagePublishedEvent;
		public void Publish(string message)
		{
			System.Console.WriteLine("Waiting for message to be verified: " + message);
			Thread.Sleep(3000);

			OnMessagePublished();
		}
		protected virtual void OnMessagePublished()
		{
			if (MessagePublishedEvent != null)
				MessagePublishedEvent(this, EventArgs.Empty);
		}
	}
}
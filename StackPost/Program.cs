// Design a class called Post. This class models a StackOverflow post. It should have properties
// for title, description and the date/time it was created. We should be able to up-vote or down-vote
// a post. We should also be able to see the current vote value. In the main method, create a post,
// up-vote and down-vote it a few times and then display the the current vote value.
// In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
// and down-voting. You should not give the ability to set the Vote property from the outside,
// because otherwise, you may accidentally change the votes of a class to 0 or to a random
// number. And this is how we create bugs in our programs. The class should always protect its
// state and hide its implementation detail. 

namespace StackPost
{
	class Program
	{
		static void Main(string[] args)
		{
			var post = new Post("Need help", "I have no idea what i am doing");

			while (true)
			{
				System.Console.WriteLine($"Title: {post.Title}\nDescription: {post.Description}\nDate: {post.Date}");
				System.Console.WriteLine($"Current Vote value is: {post.UpdateVote()}");
				System.Console.WriteLine("UpVote or DownVote:");
				System.Console.WriteLine("Exit to leave.");

				var input = Console.ReadLine().ToLower();
				switch (input)
				{
					case "upvote":
						post.UpVote();
						break;
					case "downvote":
						post.DownVote();
						break;
					case "exit":
						System.Console.WriteLine($"Vote Closed at: {post.UpdateVote()}");
						return;
					default:
						System.Console.WriteLine("Know your input!");
						break;
				}
			}
		}
	}
}
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
	class Post
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime Date { get; set; }
		private int _upVote = 0;
		private int _currentVote = 0;
		private int _downVote = 0;

		public Post(string title, string description)
		{
			this.Title = title;
			this.Description = description;
			DefineDate();
		}
		public void DefineDate()
		{
			this.Date = DateTime.Now;
		}
		public int UpdateVote()
		{
			_currentVote = _upVote + _downVote;
			return _currentVote;
		}
		public void UpVote()
		{
			_upVote++;
			UpdateVote();
		}
		public void DownVote()
		{
			_downVote--;
			UpdateVote();
		}
	}
}
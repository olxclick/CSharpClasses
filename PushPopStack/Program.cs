// The Push() method stores the given object on top of the stack. We use the “object” type here so
// we can store any objects inside the stack. Remember the “object” class is the base of all classes
// in the .NET Framework. So any types can be automatically upcast to the object. Make sure to
// take into account the scenario that null is passed to this object. We should not store null
// references in the stack. So if null is passed to this method, you should throw an
// InvalidOperationException. Remember, when coding every method, you should think of all
// possibilities and make sure the method behaves properly in all these edge cases. That’s what
// distinguishes you from an “average” programmer.

// The Pop() method removes the object on top of the stack and returns it. Make sure to take into
// account the scenario that we call the Pop() method on an empty stack. In this case, this method
// should throw an InvalidOperationException. Remember, your classes should always be in a valid
// state and used properly. When they are misused, they should throw exceptions. Again, thinking
// of all these edge cases, separates you from an average programmer. The code written this way
// will be more robust and with less bugs.

// The Clear() method removes all objects from the stack. 

namespace PushPopStack
{
	class Stack
	{
		private readonly List<object> _items = new List<object>();

		public void Push(object obj)
		{
			if (obj == null)
				throw new InvalidOperationException("Cannot push null onto the stack.");
			
			_items.Add(obj);
		}

		public object Pop()
		{
			if (_items.Count == 0)
				throw new InvalidOperationException("The stack is empty.");
			
			int lastIndex = _items.Count - 1;
			object poppedItem = _items[lastIndex];
			_items.RemoveAt(lastIndex);
			return poppedItem;
		}

		public void Clear()
		{
			_items.Clear();
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			var stack = new Stack();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
		}
	}
}
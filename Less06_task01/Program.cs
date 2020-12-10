using System;

namespace Less06_task01
{
	class Program
	{
		static void Main(string[] args)
		{
			MyClass inst = new MyClass();
			MyClass.x = 10;

			Console.WriteLine(MyClass.x);

			Console.ReadKey();
		}
	}

	class MyClass
	{
		public static int x = 5;
	}
}


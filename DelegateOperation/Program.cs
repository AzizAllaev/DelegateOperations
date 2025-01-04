using System.Security.Cryptography.X509Certificates;

namespace DelegateOperation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Operation minus = MinusForDelegate;
			Operation plus = PlusForDelegate;
			Console.WriteLine(minus(2, 2));
			Console.WriteLine(plus(2, 2));
		}

		public static int PlusForDelegate(int a, int b) => a + b;
		public static int MinusForDelegate(int a, int b) => a - b;
		public delegate int Operation(int x, int y);
	}
}
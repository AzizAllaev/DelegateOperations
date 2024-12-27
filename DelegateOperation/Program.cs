using System.Security.Cryptography.X509Certificates;

namespace DelegateOperation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Operation Operation1 = Minus;
			Operation Operation2 = Plus;
			Console.WriteLine(Operation1(2, 2));
			Console.WriteLine(Operation1(2, 2));
		}

		public static int Plus(int a, int b) => a + b;
		public static int Minus(int a, int b) => a - b;
		public delegate int Operation(int x, int y);
	}
}
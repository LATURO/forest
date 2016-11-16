using System;

namespace blabla
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			int size;
			Console.WriteLine("Введите количество эелементов в массиве:");
			size = int.Parse(Console.ReadLine());
			int[] a = new int[Math.Abs(size)];
			string aa;
			for (int i = 0; i <Math.Abs(size); i++)
			{
				Console.Write("Введите элемент номер {0} :", i+1);
				aa = Console.ReadLine();
				a[i] = Convert.ToInt16(aa);
			}
			Console.Write("Массив:");
			foreach (int j in a)
			{
				Console.Write("{0} ", j);
			}
		}
	}
}

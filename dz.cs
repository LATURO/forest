using System;
using System.Linq;
namespace blabla
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			int size, ch1 = 0, ch2 = 0;
			Console.WriteLine("Введите количество эелементов в массиве:");
			size = int.Parse(Console.ReadLine());
			int[] a = new int[Math.Abs(size)];
			string aa;
			for (int i = 0; i < Math.Abs(size); i++)
			{
				Console.Write("Введите элемент номер {0} :", i + 1);
				aa = Console.ReadLine();
				a[i] = Convert.ToInt16(aa);
				int res = ((a[i] % 2 == 0) ? ch2++ : ch1++);
			}
			int[] m1 = new int[ch1];
			int[] m2 = new int[ch2];
			for (int i = 0, k = 0, k2 = 0; i < size; i++)
			{
				if (a[i] % 2 == 0)
				{
					m2[k] = a[i];
					k++;
				}
				else {
					m1[k2] = a[i];
					k2++;
				}
			}
			foreach (int j in a)
			{
				Console.Write("{0} ", j);
			}
			Console.WriteLine("\r\nЧетные:");
			foreach (int j in m2)
			{
				Console.Write("{0} ", j);
			}
			Console.WriteLine("\r\nНечетные:");
			foreach (int j in m1)
			{
				Console.Write("{0} ", j);
			}
		}
	}
}

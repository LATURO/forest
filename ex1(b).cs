using System;
namespace tsett
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			int[] array = new int[size];
			int[] array2 = new int[size];
			for (int i = 0; i < size; i++)
			{
				Console.Write("Введите элемент номер {0} :", i + 1);
				array[i] = int.Parse(Console.ReadLine());
			}
			Console.Write("Массив: ");
			foreach (int i in array)
			{
				Console.Write("{0} ", i);
			}
			for (int i = 0, j = size-1; i < size; i++, j--)
			{
				array2[i] = array[j];
			}
			Console.Write("\r\nНовый массив: ");
			foreach (int i in array2)
			{
				Console.Write("{0} ", i);
			}
		}
	}
}

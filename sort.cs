using System;
namespace tsett
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			int[] array = new int[size];
			for (int i = 0; i < size; i++)
			{

				array[i] = int.Parse(Console.ReadLine());
			}
			Console.Write("По-возрастанию:");
			int buff;
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size - 1; j++)
				{
					if (array[j] >= array[j + 1])
					{
						buff = array[j];
						array[j] = array[j + 1];
						array[j + 1] = buff;
					}
				}
			}
			foreach (int i in array)
			{
				Console.Write("{0} ", i);
			}
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size - 1; j++)
				{
					if (array[j] <= array[j + 1])
					{
						 buff = array[j];
						array[j] = array[j + 1];
						array[j + 1] = buff;
					}
				}
			}
			Console.WriteLine("");
			Console.Write("По-убыванию:");
			foreach (int i in array)
			{
				Console.Write("{0} ", i);
			}
		}
	}
}

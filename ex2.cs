using System;
namespace tsett
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			int[] array = new int[size];
			for (int i = 0; i < size;i++){

				array[i] = int.Parse(Console.ReadLine());
			}
			Console.Write("Массив: ");
			foreach (int i in array) {
				Console.Write("{0} ", i);
			}
			for (int i = 0, j = size - 1; i < size / 2; i++,j--) {
				int buff = array[j];
				array[j] = array[i];
				array[i] = buff;
			}
			Console.Write("\r\nНовый массив: ");
			foreach (int i in array)
			{
				Console.Write("{0} ", i);
			}
		}
	}
}

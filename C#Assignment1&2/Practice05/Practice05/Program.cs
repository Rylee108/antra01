// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApplication
{
	public class Program
	{
		public static void Main()
		{


			DateTime currentDateTime = DateTime.Now;
			//DateTime currentDateTime = new DateTime(2017, 9, 3, 8, 4, 0); //Test data
			int currentHour = currentDateTime.Hour;
			int startMorningHour = 6;
			int startAfternoonHour = 12;
			int startEveningHour = 17;
			int startNightHour = 22;

			if (startMorningHour <= currentHour && currentHour < startAfternoonHour)
			{
				Console.WriteLine("Good morning!");
			}

			;
			if (startAfternoonHour <= currentHour && currentHour < startEveningHour)
			{
				Console.WriteLine("Good Afternoon!");
			}

			;
			if (startEveningHour <= currentHour && currentHour < startNightHour)
			{
				Console.WriteLine("Good Evening!");
			}

			;
			if (startNightHour <= currentHour || currentHour < startMorningHour)
			{
				Console.WriteLine("Good Night!");
			}

			;

			Console.WriteLine("Right now it is {0}:{1} o'clock.", currentDateTime.Hour, currentDateTime.Minute);
		}
	}
}

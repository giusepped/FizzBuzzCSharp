using System;
using System.Collections.Generic;

namespace FizzBuzzConsole
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var fizzbuzz = new FizzBuzz ();

			var numberList = fizzbuzz.GetFizzBuzz (15);

			numberList.ForEach (i => Console.WriteLine (i));
		
		}
	}
}

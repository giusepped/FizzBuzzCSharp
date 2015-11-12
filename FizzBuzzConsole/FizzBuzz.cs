using System;
using System.Collections.Generic;

namespace FizzBuzzConsole
{
	public class FizzBuzz
	{
		
		public List<string> GetFizzBuzz(int upperLimit) 
		{
			var numberList = new List<String> ();

			for (int ii = 1; ii < upperLimit + 1; ii++) {
				if (ii % 15 == 0) {
					numberList.Add ("FizzBuzz");
				} else if (ii % 3 == 0) {
					numberList.Add ("Fizz");
				} else if (ii % 5 == 0) {
					numberList.Add ("Buzz");
				} else {
					numberList.Add (ii.ToString ());
				}
			}

			return numberList;
		}
	}
}


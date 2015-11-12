using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FizzBuzzConsole
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestFizzBuzz_until_two ()
		{
			var fizzbuzz = new FizzBuzz ();
			var expected = new List<String> { "1", "2", "Fizz", "4", "Buzz", 
											  "Fizz", "7", "8", "Fizz", "Buzz", 
											  "11", "Fizz", "13", "14", "FizzBuzz" };

			var actual = fizzbuzz.GetFizzBuzz (15);
			CollectionAssert.AreEqual (expected, actual);
		}
	}
}

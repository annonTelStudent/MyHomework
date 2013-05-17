using System;

class T4Test
{
	static void Main()
	{
		Console.WriteLine("Please enter a digit");
		int digit = int.Parse(Console.ReadLine());
		switch(digit)
		{
			case 0 : Console.WriteLine("The ASCI code of {0} is {1}.", 0, (int)'0'); break;
			case 1 : Console.WriteLine("The ASCI code of {0} is {1}.", 1, (int)'1'); break;
			case 2 : Console.WriteLine("The ASCI code of {0} is {1}.", 2, (int)'2'); break;
			case 3 : Console.WriteLine("The ASCI code of {0} is {1}.", 3, (int)'3'); break;
			case 4 : Console.WriteLine("The ASCI code of {0} is {1}.", 4, (int)'4'); break;
			case 5 : Console.WriteLine("The ASCI code of {0} is {1}.", 5, (int)'5'); break;
			case 6 : Console.WriteLine("The ASCI code of {0} is {1}.", 6, (int)'6'); break;
			case 7 : Console.WriteLine("The ASCI code of {0} is {1}.", 7, (int)'7'); break;
			case 8 : Console.WriteLine("The ASCI code of {0} is {1}.", 8, (int)'8'); break;
			case 9 : Console.WriteLine("The ASCI code of {0} is {1}.", 9, (int)'9'); break;
			default: Console.WriteLine("Invalid Digit"); break;
		}
	}
}
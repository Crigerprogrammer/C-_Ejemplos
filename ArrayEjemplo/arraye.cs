using System;

class Tester{
	static void Main(string[] args){
		String[] myArray = {"Who", "is", "John", "Doe"};

		PrintMyArray(myArray);
		Array.Reverse(myArray);
		PrintMyArray(myArray);

		String[] myOtherArray = {"We", "Hold", "These", "Truths", "To", "Be", "Self", "Evident"};

		PrintMyArray(myOtherArray);
		Array.Sort(myOtherArray);
		PrintMyArray(myOtherArray);
		Console.ReadLine();

	}

	public static void PrintMyArray(object[] theArray){
		foreach (object obj in theArray){
			Console.WriteLine("Value: {0}", obj);
		}
		Console.WriteLine();
	}
}
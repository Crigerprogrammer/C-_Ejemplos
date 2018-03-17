using System;
using System.Collections;

class TestForeach {
	static void Main() {

		string s = "abc123";
		Console.WriteLine(s is IEnumerable + "\n");

		foreach (char c in s) Console.WriteLine(c);

		Console.WriteLine("\n---\n");

		IEnumerator ie = s.GetEnumerator();
		while (ie.MoveNext()){
			char c = (char) ie.Current;
			Console.WriteLine(c);
		}
		Console.ReadLine();
	}
}
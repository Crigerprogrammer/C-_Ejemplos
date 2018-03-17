using System;
using System.Collections;

	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			ArrayList testsql= new ArrayList();
            ArrayList testinfor= new ArrayList();

            testsql.Add("1");
            testsql.Add("2");
            testsql.Add("3");


            testinfor.Add("2");
            testinfor.Add("3");
            testinfor.Add("4");
            testinfor.Add("5");

            int a = 1;

            foreach (var s1 in testsql)
            {
                foreach (var s2 in testinfor)
                {
                    if (s1.Equals(s2))
                    {
                    	Console.WriteLine("s1" +s1 + "s2" +s2);
                        break;
                    }
                }
                a++;
            }
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}

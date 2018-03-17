using System;

class Mayor{
	static void Main(string[] args){
		//Programa para saber quien es el numero mayor despues de ingresar 5
		int n1;
		int n2;
		int n3;
		int n4;
		int n5;

		Console.WriteLine("Bienvenido al programa");
		Console.WriteLine("Ingrese el numero 1");
		n1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese el numero 2");
		n2 = int.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese el numero 3");
		n3 = int.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese el numero 4");
		n4 = int.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese el numero 5");
		n5 = int.Parse(Console.ReadLine());

		if(n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5){
			Console.Write(n1 + " Es el numero mayor");
		}
		else if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5){
			Console.Write(n2 + " Es el numero mayor");
		}
		else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5){
			Console.Write(n3 + " Es el numero mayor");
		}
		else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5){
			Console.Write(n4 + " Es el numero mayor");
		}
		else if (n5 > n1 && n5 > n2 && n5 > n3 && n5 > n4){
			Console.Write(n5 + " Es el numero mayor");
		}
		else{
			Console.Write("Ingrese un numero valido");
		}
	}
}
using System;
using System.Collections;

class Ejercicio2{
	static void Main(String[] args){
		//ArrayList, Ingrese en un arraylist 10 valores enteros y luego determine cual es el valor mayor
		//y el menor, imprima el valor.

		ArrayList numeros = new ArrayList();

		string numero;
		int num1;

		for(int i = 1; i < 11; i++){
			Console.WriteLine("Ingrese el numero {0}", i);
			numero = Console.ReadLine();
			num1 = int.Parse(numero);
			numeros.Add(num1);
		}

		numeros.Sort();

		foreach(var valor in numeros){
			Console.WriteLine("numero {0}", valor);
		}
		Console.WriteLine("=========================");
		Console.WriteLine("El numero mayor es: {0}", numeros[9]);
		Console.WriteLine("=======================");
	}
}
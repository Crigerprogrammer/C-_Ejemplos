using System;

class Tablas{
	static void Main(string[] args){
		//Programa que lea un entero y coloca la tabla de multiplicar de este
		int num;
		int resultado;
		Console.WriteLine("Programa para Tablas de multiplicar");
		Console.WriteLine("Ingrese el numero que le quiere colocar la tabla de multiplicar");
		num = int.Parse(Console.ReadLine());
		for(int i=0;i<11;i++){
			resultado = num * i;
			Console.WriteLine(num + "*" + i + "=" + resultado);
		}
	}
}
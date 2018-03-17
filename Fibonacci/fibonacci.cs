using System;

class Fibonacci{
	static void Main(String[] args){
		//Calcule la suma de los terminos de la serie FIBONACCI cuyos valores se encuentran entre 100 y 10,000 y realizar suma de todos

		int A = 0;
		int B = 1;
		int C = A+B;
		int suma=0;

		Console.WriteLine("Serie Fibonacci: ");
		Console.Write(A + " ");
		Console.Write(B + " ");
		while(C < 10000){
			Console.Write(C + " ");
			if(C>100 && C <10000){
				suma = suma + C;
			}
			A = B;
			B = C;
			C = A+B;
		}
		Console.WriteLine();
		Console.WriteLine("La suma es: " + suma);
		Console.ReadLine();
	}
}
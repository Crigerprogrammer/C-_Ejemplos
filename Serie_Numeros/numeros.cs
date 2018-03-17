using System;

class SerieNumeros{
	static void Main(String[] args){
		//Realizar un programa que imprima la siguiente serie de numeros: 11, 12, 13, 14, 15, 21, 22, 23, 24, 25
		//Declaramos las 2 variables entereas que almacenaran los valores de la serie de numeros
		int num = 0;
		//Esta la inicializamos en 10 ya que desde el numero 11 empezamos
		int aux = 10;

		//Formato a la aplicacion de consola
		Console.WriteLine("Serie de Numeros: ");
		Console.WriteLine("==================");
		Console.WriteLine();

		//Ciclo donde iteramos
		for(int i = 1; i<=5; i++){
			for(int j = 1; j<=5; j++){
				num = aux + j;
				Console.Write(num + " ");
			}
			aux = num + 5;
		}
		Console.ReadLine();
	}
}
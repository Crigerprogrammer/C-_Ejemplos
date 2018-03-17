using System;

class Switch{
	static void Main(string[] args){
		//Estas son las estructuras condicionales 
		//If / Else en C#
		Console.WriteLine("Ingrese el numero 1");
		int q = int.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese el numero 2");
		int p = int.Parse(Console.ReadLine());
		if(q > p){
			Console.Write(q + " Es el mayor");
		} else{
			Console.Write(p + " Es el mayor"); 
		}
		Console.WriteLine("Ingrese un numero para mostrar el numero de mes: ");
		int numero = int.Parse(Console.ReadLine());

		switch (numero) {
			case 1: 
				Console.WriteLine("Enero");
				break;
			case 2:
				Console.WriteLine("Febrero");
				break;
			case 3:
				Console.WriteLine("Marzo");
				break;
			case 4:
				Console.WriteLine("Abril");
				break;
			case 5:
				Console.WriteLine("Mayo");
				break;
			case 6:
				Console.WriteLine("Junio");
				break;
			case 7:
				Console.WriteLine("Julio");
				break;
			case 8:
				Console.WriteLine("Agosto");
				break;
			case 9:
				Console.WriteLine("Septiembre");
				break;
			case 10:
				Console.WriteLine("Octubre");
				break;
			case 11:
				Console.WriteLine("Noviembre");
				break;
			case 12:
				Console.WriteLine("Diciembre");
				break;
			default:
				Console.WriteLine("Ingrese un numero valido");
				break;
		} 
	}
}
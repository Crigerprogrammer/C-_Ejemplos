using System;

class Ejemplo{
	static void Main(string[] args){
		int calif;
		int numero=3;
		string myText;

		calif = 70;
		Console.WriteLine("Esta es la calificacion: " + calif);
		myText = "Hola!";
		Console.WriteLine("Este es el texto: " + myText);
		calif = 90;
		Console.WriteLine("Este es el nuevo valor de la calificacion: " + calif);
		Console.WriteLine("----------------------------");

		//Estructura IF
		if(calif >= 90){
			Console.WriteLine("A");
		}else{
			if(calif >= 80){
				Console.WriteLine("B");
			}else{
				if(calif >= 70){
					Console.WriteLine("C");
				}else{
					if(calif >= 60){
						Console.WriteLine("D");
					}else{
						Console.WriteLine("F");
					}
				}
			}
		}
		Console.WriteLine("-----------------");


		//Estructura Switch

		switch(calif){
			case 10 :
				Console.WriteLine("diez");
				break;
			case 20 :
				Console.WriteLine("veinte");
				break;
			case 30 :
				Console.WriteLine("treinta");
				break;
			case 40 :
				Console.WriteLine("cuarenta");
				break;
			case 50 :
				Console.WriteLine("cincuenta");
				break;
			case 90 :
				Console.WriteLine("noventa");
				break;
			default :
				Console.WriteLine("otro");
				break;
		}

		Console.WriteLine("----------------------");

		//Ciclo While

		while (numero <= 100){
			numero = 3 * numero;
			Console.WriteLine(numero);
		}
		Console.WriteLine("----------------");

		//Ciclo For
		for(numero=5; numero<=15; numero++){
			Console.WriteLine(numero);
		}

		Console.WriteLine("-----------------");

		//Ciclo do While

		numero = 1;
		do{
			Console.WriteLine(numero);
			numero = numero +1;
		}

		while(numero <= 12);

	}
}
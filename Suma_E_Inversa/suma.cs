using System;

class Suma_Inversa{
	static void Main(string[] args){
		//Hallar la suma de un numero entero mas el mismo numero solo que inverso
		//Declaramos dos variables de tipo entero y la segunda inicializada
		string numCad;
		string invCad = "";

		//Estas 3 variables numericas seran para ser numerico y recibir los valores numericos de la consola
		int num1;
		int num2;
		int R;

		//Imprimimos el mensaje para leer el valor numerico
		Console.Write("Ingrese un valor numerico: ");
		//Igualamos numCAD (STRING) a readline
		numCad = Console.ReadLine();
		//Lo casteamos a entero para que pueda recibir el valor numerico 
		num1 = int.Parse(numCad);

		//Recorremos la longitud del numero ingresado en su formato crudo (entero)
		for(int i = numCad.Length - 1;i>-1;i--)
		{
			//la nueva variable va a almacenar cada valor de la cadena del ultimo al nuevo
			invCad += numCad[i];
		}
		//Le asignamos el valor a la variable entero
		num2 = int.Parse(invCad);

		//R = Resultado de amvos
		R =num1 + num2;

		//Imprimimos los valores
		Console.WriteLine();
		Console.WriteLine(num1 + " + ");
		Console.WriteLine(num2);
		Console.WriteLine("------");
		Console.WriteLine(R);

		Console.ReadLine();
	}
}
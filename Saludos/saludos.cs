using System;

class Saludos{
		//En una reunion asistieron "n" personas, realizar un programa para 
		//calcular el numero de saludos suponiendo que todos los presentes se saludaros
	class calculo{
		public int factorial(int x){
			int fact = 1;
			for(int i = 1; i<= x; i++){
				fact = fact * i;
			}
			return fact;
		}
	}

		static void Main(string[] args){
			int k;
			int y;
			int num;
			int result;

			Console.Write("Ingrese cantidad de personas asistentes: ");
			num = int.Parse(Console.ReadLine());

			calculo objFact = new calculo();

			k = 2;
			y = num - k;

			result = objFact.factorial(num) / (objFact.factorial(k) * objFact.factorial(y));

			Console.WriteLine();
			Console.Write("Saludos efectuados: " + result);
			Console.ReadLine();
	}
}
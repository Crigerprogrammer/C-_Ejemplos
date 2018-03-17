using System;
using System.Collections;

class Ejercicio{
	static void Main(string[] args){
		//Estructuras
		//HashTable, Ingrese por consola el carne y nombre de 10 alumnos y luego imprima en pantalla
		//solamente el nombre de los dias Alumnos
		Hashtable alumnos = new Hashtable();

		string carne;
		string nombre;

		for(int i = 0; i < 11; i++){
			Console.WriteLine("Ingrese el numero de Carne: ");
			carne = Console.ReadLine();
			Console.WriteLine("Ingrese el nombre del alumno: ");
			nombre = Console.ReadLine(); 
			alumnos.Add(carne, nombre);
		}

		foreach(DictionaryEntry valor in alumnos){
			Console.WriteLine("Nombre Alumno: {0} ", valor.Value);
		}
	}
}
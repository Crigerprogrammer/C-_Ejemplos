using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{

	public class Persona{

		public void ImprimirPersona(){
			Console.WriteLine("Ingrese el nombre de la persona: ");
			string nombre = Console.ReadLine();
			Console.WriteLine("Ingrese la edad de la persona: ");
			string edad = Console.ReadLine();
			int edad1 = int.Parse(edad);
			Console.WriteLine("El nombre de la persona es: " + nombre);
			Console.WriteLine("La edad de la persona es: " + edad1);
		}

	}

	public class Empleado : Persona {


		public void ImprimirEmpleado(){
			Console.WriteLine("Ingrese el nombre del empleado: ");
			string nombre = Console.ReadLine();
			Console.WriteLine("Ingrese la edad del empleado: ");
			string edad = Console.ReadLine();
			int edad1 = int.Parse(edad);
			Console.WriteLine("El nombre del empleado es: " + nombre);
			Console.WriteLine("La edad del empleado es: " + edad1);
		}

	}

	public class Program{
		static void Main(string[] args){
			Console.WriteLine("Bienvenido al programa: ");
			Persona persona1 = new Persona();
			Empleado empleado1 = new Empleado();
			persona1.ImprimirPersona();
			empleado1.ImprimirEmpleado();

		}
	}

}
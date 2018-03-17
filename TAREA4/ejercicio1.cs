using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{

    public class Empleado
    {
        

        public void Name()
        {
            Console.WriteLine("Ingrese el nombre del empleado:");
            string name = Console.ReadLine();
            Console.WriteLine("El nombre del empleado es: " + name);
        }

        public void Direction()
        {
            Console.WriteLine("Ingrese la direccion del empleado:");
            string direction = Console.ReadLine();
            Console.WriteLine("La direccion del empleado es: " + direction);
        }

        public void Age()
        {
            Console.WriteLine("Ingrese la edad del empleado");
            string age = Console.ReadLine();
            int Edad1 = int.Parse(age);
            if (Edad1 >= 30)
            {
                Console.WriteLine("El empleado es mayor de 30 años");
            }
            else
            {
                Console.WriteLine("El empleado es menor de 30 años");
            }

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //Defina una clase llamada Empleado y que tenga como atributos nombre, direccion y edad.
            //En el constructor debe ingresar los datos. Definir otros dos metodos para imprimir los datos ingresados y un mensaje
            //Si es mayor de 30 años (edad >= 30).
            Empleado empleado = new Empleado();
            Console.WriteLine("Estos son los datos del empleado");
            empleado.Name();
            empleado.Direction();
            empleado.Age();
            Console.ReadKey();
        }
    }
}

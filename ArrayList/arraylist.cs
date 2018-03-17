using System;
using System.Collections;

public class Employee{
	private int empID;

	public Employee(int empID){
		this.empID = empID;
	}

	public override string ToString(){
		return empID.ToString();
	}

}

public class Tester{
	static void Main() {

		ArrayList empArray = new ArrayList();
		ArrayList intArray = new ArrayList();

		//Llenamos los arreglos
		for(int i = 0; i < 5; i++) empArray.Add(new Employee(i+100));
		for(int i = 0; i < 17; i++) intArray.Add(i);

		//Imprimimos el contenido del ArrayList de enteros
		for(int i = 0; i < intArray.Count; i++) Console.Write("{0} ", intArray[i]);
		Console.WriteLine("\n\n intArray.Capacity: {0}", intArray.Capacity);

		//Imprimimos el contenido del ArrayList de empleados
		for(int i = 0; i < empArray.Count; i++) Console.Write("{0} ", empArray[i]);
		Console.WriteLine("\n\n empArray.Capacity: {0}", empArray.Capacity);
		Console.ReadLine();


	}
}
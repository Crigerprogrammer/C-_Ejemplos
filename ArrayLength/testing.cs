using System;

class TestLength{

	int[,] MyArray = new int[2,5];

	static void Main(string[] args){
		//Indica cuantos objetos hay en un arreglo, retornando el tamaño
		//total de este

		TestLength c = new TestLength();
		Console.WriteLine(c.MyArray.Length);
		Console.WriteLine(c.MyArray.GetLength(0));
		Console.WriteLine(c.MyArray.GetLength(1));
	 
	}
}
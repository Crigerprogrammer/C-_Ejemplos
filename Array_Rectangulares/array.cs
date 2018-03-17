using System;

class Tester{
	public void Run() {
		const int rows = 4;
		const int colums = 3;

		//declara un arreglo rectangular 4x3 de enteros
		int[,] rectangularArray = {{0,1,2}, {3,4,5}, {6,7,8}, {9,10,11} };

		//imprime el contenido del arreglo
		for(int i = 0; i < rows; i++){
			for(int j= 0; j < colums; j++)
			Console.WriteLine("[{0},{1}] = {2}", i, j, rectangularArray[i,j]);
		}

	}

	static void Main(){
		Tester t = new Tester();
		t.Run();
		Console.ReadLine();
	}
}